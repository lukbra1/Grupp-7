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

        public Homepage(User user)
        {
            InitializeComponent();
            _context = new AppDbContext();

            var dbUser = _context.User.FirstOrDefault(u => u.UserId == user.UserId);
            _currentUser = dbUser ?? user;
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
            UppdateraVeckooversikt(DateTime.Today);
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
            var order = orderController.HämtaAllaOrdrarMedKund().FirstOrDefault(o => o.OrderId == orderId);
            if (order == null) return;

            var orderrader = orderController.HämtaAllaOrderRader(order);
            foreach (var rad in orderrader)
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

            if (ordrarList.SelectedItems.Count == 0 || lvOrderRadLista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Välj en order och en orderrad att tilldela.");
                return;
            }

            // Hämta vald orderrad
            var selectedOrderRadItem = lvOrderRadLista.SelectedItems[0];
            var orderrad = selectedOrderRadItem.Tag as OrderRad;

            if (orderrad == null || orderrad.TilldeladOrder)
            {
                MessageBox.Show("Denna orderrad är redan tilldelad eller ogiltig.");
                return;
            }

            // Tilldela orderraden
            orderController.TilldelaOrderRad(orderrad, _currentUser.UserId, selectedDate);

            // Lägg till i todoList och listBoxDagens
            string kundNamn = orderrad.Order?.Kund != null
                ? $"{orderrad.Order.Kund.Fornamn} {orderrad.Order.Kund.Efternamn}"
                : "Okänd kund";
            string uppgift = $"🧵 Order #{orderrad.OrderId} – {kundNamn}";

            if (!todoList.ContainsKey(selectedDate))
                todoList[selectedDate] = new List<string>();
            if (!todoList[selectedDate].Contains(uppgift))
                todoList[selectedDate].Add(uppgift);

            listBoxDagens.Items.Clear();
            foreach (var task in todoList[selectedDate])
                listBoxDagens.Items.Add(task);

            UppdateraVeckooversikt(selectedDate);

            // Ta bort order från ordrarList
            foreach (ListViewItem item in ordrarList.SelectedItems)
            {
                if (item.Text == orderrad.OrderId.ToString())
                {
                    ordrarList.Items.Remove(item);
                    break;
                }
            }

            // Töm orderrad-listan och ladda om ordrar
            lvOrderRadLista.Items.Clear();
            LaddaAllaOrdrar();
        }

        private void btnVeckoöversikt_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            DateTime startOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1);
            richTextBoxVecka.Clear();

            for (int i = 0; i < 7; i++)
            {
                var day = startOfWeek.AddDays(i);
                richTextBoxVecka.AppendText($"📅 {day:dddd (d MMMM)}\n");

                if (todoList.ContainsKey(day))
                {
                    foreach (var task in todoList[day])
                        richTextBoxVecka.AppendText($" - {task}\n");
                }
                else
                {
                    richTextBoxVecka.AppendText(" (Inga uppgifter)\n");
                }
                richTextBoxVecka.AppendText("\n");
            }
        }

        private void UppdateraVeckooversikt(DateTime selectedDate)
        {
            DateTime start = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1);
            richTextBoxVecka.Clear();

            for (int i = 0; i < 7; i++)
            {
                DateTime dag = start.AddDays(i);
                richTextBoxVecka.AppendText($"📅{dag:dddd (d MMMM)}\n");

                if (todoList.TryGetValue(dag, out var tasks))
                {
                    foreach (var t in tasks)
                        richTextBoxVecka.AppendText($" - {t}\n");
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
            var AllaBeställningar = new AllaBeställningar();
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
            var TaBortKund = new TaBortKund();
            TaBortKund.Show();
            this.Hide();
        }


        private void lvOrderRadLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LaddaTilldeladeOrderrader()
        {
            var tilldelade = orderController.HämtaAllaOrderRaderTilldelade();

            foreach (var rad in tilldelade)
            {
                var datum = rad.TilldelningsDatum?.Date ?? DateTime.Today;
                string kundNamn = rad.Order?.Kund != null ? $"{rad.Order.Kund.Fornamn} {rad.Order.Kund.Efternamn}" : "Okänd kund";
                string uppgift = $"🧵 Order #{rad.OrderId} – {kundNamn}";

                if (!todoList.ContainsKey(datum))
                    todoList[datum] = new List<string>();

                if (!todoList[datum].Contains(uppgift))
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

        private void btnSchemalägg_Click(object sender, EventArgs e)
        {
            if (ordrarList.SelectedItems.Count == 0 || lvOrderRadLista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Välj både en order och en orderrad.");
                return;
            }

            var selectedOrderRadItem = lvOrderRadLista.SelectedItems[0];
            var orderrad = selectedOrderRadItem.Tag as OrderRad;
            var selectedDate = monthCalendar1.SelectionStart.Date;

            if (orderrad == null || orderrad.TilldeladOrder)
            {
                MessageBox.Show("Denna orderrad är redan tilldelad.");
                return;
            }

            // Tilldela
            orderController.TilldelaOrderRad(orderrad, _currentUser.UserId, selectedDate);

            // Lägg till i todo-lista
            string kundNamn = orderrad.Order?.Kund != null
                ? $"{orderrad.Order.Kund.Fornamn} {orderrad.Order.Kund.Efternamn}"
                : "Okänd kund";
            string uppgift = $"🧵 Order #{orderrad.OrderId} – {kundNamn}";

            if (!todoList.ContainsKey(selectedDate))
                todoList[selectedDate] = new List<string>();

            if (!todoList[selectedDate].Contains(uppgift))
                todoList[selectedDate].Add(uppgift);

            // Visa
            listBoxDagens.Items.Clear();
            foreach (var task in todoList[selectedDate])
                listBoxDagens.Items.Add(task);

            UppdateraVeckooversikt(selectedDate);

            // Uppdatera vy
            lvOrderRadLista.Items.Clear();
            ordrarList.Items.Remove(ordrarList.SelectedItems[0]);
        }
    }
}
