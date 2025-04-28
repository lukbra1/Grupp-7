using Hattmakarens_system.Presentationslager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Hattmakarens_system.ModelsNy;
using Hattmakarens_system.Database;
using Microsoft.EntityFrameworkCore;
using Hattmakarens_system.Controllers;

namespace Hattmakarens_system
{
    public partial class Homepage : Form
    {
        private User _currentUser;
        private readonly AppDbContext _context = new AppDbContext();
        private readonly OrderController orderController;
        private readonly KundController kundController;
        private Dictionary<DateTime, List<string>> todoList = new();
        private DateTime aktuellVeckaStart = DateTime.Today;


        public Homepage(User user)
        {
            InitializeComponent();
            _currentUser = user;
            orderController = new OrderController(_context);
            kundController = new KundController(_context);

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar1.SelectionEnd = DateTime.Today;

            if (_currentUser is { Behorighet: false })
                hanteraMedarbetareToolStripMenuItem.Visible = false;

            InitializeListView();
            LaddaAllaOrdrar();
            ordrarList.SelectedIndexChanged += ordrarList_SelectedIndexChanged;

            LaddaTilldeladeOrderrader();
            UppdateraVeckooversikt(aktuellVeckaStart);
            LaddaMinaUppgifter();
        }

        private void InitializeListView()
        {
            ordrarList.Items.Clear();
        }

        private void LaddaAllaOrdrar()
        {
            var ordrar = orderController.HämtaAllaOrdrarMedKund()
                .Where(o => o.Kund != null && o.Kund.Aktiv)
                .OrderBy(o => o.OrderId)
                .ToList();

            ordrarList.Items.Clear();

            foreach (var order in ordrar)
            {
                var item = new ListViewItem(order.OrderId.ToString());
                item.SubItems.Add($"{order.Kund.Fornamn} {order.Kund.Efternamn}");
                item.SubItems.Add(order.Skapad.ToShortDateString());
                item.SubItems.Add(order.Express ? "Ja" : "Nej");
                item.Tag = order;
                ordrarList.Items.Add(item);
            }
        }

        private void ordrarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvOrderRadLista.Items.Clear();
            if (ordrarList.SelectedItems.Count == 0) return;

            int orderId = int.Parse(ordrarList.SelectedItems[0].Text);
            var order = _context.Ordrar
                .AsNoTracking()
                .Include(o => o.Kund)
                .Include(o => o.OrderRader)
                .FirstOrDefault(o => o.OrderId == orderId);
            if (order == null) return;

            var orderrader = orderController.HämtaAllaOrderRader(order);
            foreach (var rad in orderrader.Where(r => r.StatusOrderrad != StatusOrderradEnum.Färdig))
            {
                var item = new ListViewItem(rad.OrderRadId.ToString());
                item.SubItems.Add(rad.TypEnum.ToString());
                item.SubItems.Add(rad.Storlek.ToString());
                item.SubItems.Add(rad.StatusOrderrad.ToString());
                item.SubItems.Add(rad.TilldeladOrder ? "Ja" : "Nej");
                item.SubItems.Add(rad.pris.HasValue ? $"{rad.pris.Value} kr" : "Ingen");
                item.Tag = rad;
                lvOrderRadLista.Items.Add(item);
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var selectedDate = monthCalendar1.SelectionStart.Date;

            aktuellVeckaStart = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1);


            if (_currentUser == null || _currentUser.UserId <= 0)
            {
                MessageBox.Show("Användaren är inte giltig eller inloggad.");
                return;
            }

            if (lvOrderRadLista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Välj en eller flera hattar att schemalägga.");
                return;
            }

            foreach (ListViewItem item in lvOrderRadLista.SelectedItems)
            {
                if (item.Tag is not OrderRad orderrad) continue;

                if (orderrad.TilldeladOrder)
                {
                    MessageBox.Show($"Orderrad {orderrad.OrderRadId} är redan tilldelad.");
                    continue;
                }

                try
                {
                    orderController.TilldelaOrderRad(orderrad, _currentUser.UserId, selectedDate);

                    var uppdateradRad = _context.Orderrader
                    .Include(r => r.Order)
                    .ThenInclude(o => o.Kund)
                    .FirstOrDefault(r => r.OrderRadId == orderrad.OrderRadId);

                    if (uppdateradRad == null) continue;
                    string kundNamn = orderrad.Order?.Kund != null
                        ? $"{orderrad.Order.Kund.Fornamn} {orderrad.Order.Kund.Efternamn}"
                        : "Okänd kund";

                    string ansvarig = _currentUser != null ? $"{_currentUser.Namn}" : "Okänd användare";


                    string text = $"Hatt #{orderrad.OrderRadId} – {orderrad.TypEnum} – {kundNamn} – {ansvarig} – Status: {orderrad.StatusOrderrad}";


                    if (!todoList.ContainsKey(selectedDate))
                        todoList[selectedDate] = new List<string>();

                    todoList[selectedDate].Add(text);


                    lvOrderRadLista.Items.Remove(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fel vid tilldelning: {ex.Message}");
                }
            }

            UppdateraVeckooversikt(selectedDate);
            ordrarList_SelectedIndexChanged(null, null);

            LaddaMinaUppgifter();

        }

        private void UppdateraVeckooversikt(DateTime selectedDate)
        {
            DateTime start = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1);
            richTextBoxVecka.Clear();

            for (int i = 0; i < 7; i++)
            {
                DateTime dag = start.AddDays(i);
                richTextBoxVecka.AppendText($"{dag:dddd (d MMMM)}\n");

                if (todoList.TryGetValue(dag, out var tasks))
                {
                    var ickeFardiga = tasks
                        .Where(t => !t.Contains("Status: Färdig"))
                        .ToList();

                    if (ickeFardiga.Any())
                    {
                        foreach (var t in ickeFardiga)
                            richTextBoxVecka.AppendText($" - {t}\n");
                    }
                    else
                    {
                        richTextBoxVecka.AppendText(" (Inga uppgifter)\n");
                    }
                }
                else
                {
                    richTextBoxVecka.AppendText(" (Inga uppgifter)\n");
                }

                richTextBoxVecka.AppendText("\n");
            }
        }

        private void nyBeställningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var VäljKund = new VäljKund();
            VäljKund.Show();
            this.Hide();
        }

        private void allaBeställningarToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            var AllaBeställningar = new AllaBeställningar(this);
            AllaBeställningar.Show();
            this.Hide();
        }

        private void loggaUtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vill du logga ut?", "Logga ut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var loginForm = new LoggaInGränsnittt();
                loginForm.Show();
                this.Close();
            }
        }

        private void hanteraMedarbetareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var medarbetare = new HanteraMedarbetare();
            medarbetare.Show();
            this.Hide();
        }

        private void marealLagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var materialForm = new SeMaterialbehov();
            materialForm.Show();
        }


        private void hanteraKunderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TaBortKund = new TaBortKund(this);
            TaBortKund.Show();
            this.Hide();
        }

        private void lvOrderRadLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LaddaTilldeladeOrderrader()
        {
            todoList.Clear();

            _context.ChangeTracker.Clear();

            var tilldelade = orderController.HämtaAllaOrderRaderTilldelade()
                        .Where(r => r.StatusOrderrad != StatusOrderradEnum.Färdig &&
                        r.Order?.Kund != null &&
                        r.Order.Kund.Aktiv
                        )
                        .ToList();


            foreach (var rad in tilldelade)
            {
                var datum = rad.TilldelningsDatum?.Date ?? DateTime.Today;

                string kundNamn = rad.Order?.Kund != null
                    ? $"{rad.Order.Kund.Fornamn} {rad.Order.Kund.Efternamn}"
                    : "Okänd kund";

                string ansvarig = rad.User != null
                ? $"{rad.User.Namn}"
                : "Ingen ansvarig";

                string uppgift = $"Hatt #{rad.OrderRadId} – {rad.TypEnum} – {kundNamn} – {ansvarig} – Status: {rad.StatusOrderrad}";

                if (!todoList.ContainsKey(datum))
                    todoList[datum] = new List<string>();
                todoList[datum].Add(uppgift);
            }

        }

        private void hattStatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var öppna = new HattStatistik();
            öppna.Show();
        }

        private void kundStatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var öppna = new KundStatistik();
            öppna.Show();
        }



        private void Homepage_Activated(object sender, EventArgs e)
        {
            todoList.Clear();
            lvOrderRadLista.Items.Clear();
            richTextBoxVecka.Clear();

            LaddaAllaOrdrar();

            var tilldelade = orderController.HämtaAllaOrderRaderTilldelade()
            .Where(r => r.StatusOrderrad != StatusOrderradEnum.Färdig &&
                r.Order?.Kund != null &&
                r.Order.Kund.Aktiv)
                .ToList();

            foreach (var rad in tilldelade)
            {
                var datum = rad.TilldelningsDatum?.Date ?? DateTime.Today;
                string kundNamn = rad.Order?.Kund != null
                    ? $"{rad.Order.Kund.Fornamn} {rad.Order.Kund.Efternamn}"
                    : "Okänd kund";

                string ansvarig = rad.User?.Namn ?? "Ingen ansvarig";

                string text = $"Hatt #{rad.OrderRadId} – {rad.TypEnum} (strl {rad.Storlek}) – {kundNamn} – {ansvarig} – Status: {rad.StatusOrderrad}";

                if (!todoList.ContainsKey(datum))
                    todoList[datum] = new List<string>();

                todoList[datum].Add(text);
            }
            UppdateraVeckooversikt(aktuellVeckaStart);
            LaddaMinaUppgifter();
        }
        public void UppdateraData()
        {
            todoList.Clear();
            lvOrderRadLista.Items.Clear();
            listBoxMinaUppgifter.Items.Clear();
            richTextBoxVecka.Clear();
            LaddaAllaOrdrar();
            LaddaTilldeladeOrderrader();
            LaddaMinaUppgifter();
            UppdateraVeckooversikt(aktuellVeckaStart);

            DateTime idag = DateTime.Today;
            
        }


        private void btnTaBortTilldelning_Click(object sender, EventArgs e)
        {
            if (lvOrderRadLista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Välj en hatt att ta bort tilldelning från.");
                return;
            }

            foreach (ListViewItem item in lvOrderRadLista.SelectedItems)
            {
                if (item.Tag is not OrderRad orderrad) continue;

                if (!orderrad.TilldeladOrder)
                {
                    MessageBox.Show($"Hatt #{orderrad.OrderRadId} är inte tilldelad.");
                    continue;
                }

                if (orderrad.UserId != _currentUser.UserId)
                {
                    MessageBox.Show("Du kan bara ta bort tilldelning från hattar du själv arbetar med.");
                    continue;
                }

                try
                {
                    orderController.AvTilldelaOrderRad(orderrad);
                    MessageBox.Show($"Tilldelningen för Hatt #{orderrad.OrderRadId} har tagits bort.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kunde inte ta bort tilldelning: {ex.Message}");
                }
            }

            UppdateraData();


        }
        private void LaddaMinaUppgifter()
        {
            listBoxMinaUppgifter.Items.Clear(); 

            var minaUppgifter = orderController.HämtaAllaOrderRaderTilldelade()
                .Where(r =>
                    r.StatusOrderrad != StatusOrderradEnum.Färdig &&
                    r.UserId == _currentUser.UserId &&
                    r.Order?.Kund != null &&
                    r.Order.Kund.Aktiv
                    )
                .OrderBy(r => r.TilldelningsDatum)
                .ToList();

            foreach (var rad in minaUppgifter)
            {
                string orderRadId = rad.OrderRadId.ToString();
                string kundNamn = rad.Order?.Kund != null
                    ? $"{rad.Order.Kund.Fornamn} {rad.Order.Kund.Efternamn}"
                    : "Okänd kund";
                string hattTyp = rad.TypEnum.ToString();
                string skapadDatum = rad.Order?.Skapad.ToString("yyyy-MM-dd") ?? "Okänt";
                string tilldeladDatum = rad.TilldelningsDatum?.ToString("yyyy-MM-dd") ?? "Ej tilldelad";

                var item = new ListViewItem(orderRadId);
                item.SubItems.Add(kundNamn);
                item.SubItems.Add(hattTyp);
                item.SubItems.Add(skapadDatum);
                item.SubItems.Add(tilldeladDatum);

                item.Tag = rad; 

                listBoxMinaUppgifter.Items.Add(item);
            }
        }

        private void btnForraVeckan_Click(object sender, EventArgs e)
        {
            aktuellVeckaStart = aktuellVeckaStart.AddDays(-7);
            UppdateraVeckooversikt(aktuellVeckaStart);
        }

        private void btnNastaVeckan_Click(object sender, EventArgs e)
        {
            aktuellVeckaStart = aktuellVeckaStart.AddDays(7);
            UppdateraVeckooversikt(aktuellVeckaStart);
        }
    }
}
