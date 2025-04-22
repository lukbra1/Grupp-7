using Hattmakarens_system.Presentationslager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Hattmakarens_system.ModelsNy;
using Hattmakarens_system.Database;
using Microsoft.EntityFrameworkCore;

namespace Hattmakarens_system
{
    public partial class Homepage : Form
    {
        Dictionary<DateTime, List<string>> todoList = new Dictionary<DateTime, List<string>>();
        private readonly AppDbContext _context = new AppDbContext();
        private User _currentUser;

        // Dictionary för att koppla order till datum och användare
        private Dictionary<int, Dictionary<DateTime, User>> orderTilldelningar = new Dictionary<int, Dictionary<DateTime, User>>();

        public Homepage(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar1.SelectionEnd = DateTime.Today;
            UppdateraVeckooversikt(DateTime.Today);

            if (_currentUser != null && !_currentUser.Behorighet)
            {
                hanteraMedarbetareToolStripMenuItem.Visible = false;
            }

            InitializeListView();
            LaddaAllaOrdrar();
        }

        private void InitializeListView()
        {
            ordrarList.Items.Clear();
            ordrarList.Columns.Clear();

            ordrarList.Columns.Add("OrderId", 70);
            ordrarList.Columns.Add("Kund", 150);
            ordrarList.Columns.Add("Datum", 120);
            ordrarList.Columns.Add("Express", 70);

            ordrarList.View = View.Details;
            ordrarList.FullRowSelect = true;
            ordrarList.MultiSelect = true;
        }

        private void LaddaAllaOrdrar()
        {
            var ordrar = _context.Ordrar
                .Include(o => o.Kund)
                .OrderBy(o => o.OrderId)
                .ToList();

            if (ordrar.Count == 0)
            {
                MessageBox.Show("Inga ordrar hittades.");
            }

            foreach (var order in ordrar)
            {
                var item = new ListViewItem(order.OrderId.ToString());
                var kundnamn = order.Kund != null ? $"{order.Kund.Fornamn} {order.Kund.Efternamn}" : "Okänd kund";
                item.SubItems.Add(kundnamn);
                item.SubItems.Add(order.Skapad.ToShortDateString());
                item.SubItems.Add(order.Express ? "Ja" : "Nej");

                ordrarList.Items.Add(item);
            }
        }

        private void UppdateraVeckooversikt(DateTime selectedDate)
        {
            listBoxDagens.Items.Clear();
            if (todoList.ContainsKey(selectedDate))
            {
                foreach (var task in todoList[selectedDate])
                {
                    listBoxDagens.Items.Add(task);
                }
            }

            DateTime startOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1);
            richTextBoxVecka.Clear();

            for (int i = 0; i < 7; i++)
            {
                DateTime day = startOfWeek.AddDays(i);
                richTextBoxVecka.AppendText($"📅 {day:dddd (d MMMM)}\n");

                if (todoList.ContainsKey(day))
                {
                    foreach (string task in todoList[day])
                    {
                        richTextBoxVecka.AppendText($" - {task}\n");
                    }
                }
                else
                {
                    richTextBoxVecka.AppendText(" (Inga uppgifter)\n");
                }

                richTextBoxVecka.AppendText("\n");
            }
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            string task = textBoxUppgift.Text.Trim();

            if (string.IsNullOrEmpty(task)) return;

            if (!todoList.ContainsKey(selectedDate))
            {
                todoList[selectedDate] = new List<string>();
            }

            todoList[selectedDate].Add(task);
            listBoxDagens.Items.Add(task);
            textBoxUppgift.Clear();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            // Tilldela order till datum om något är valt
            if (ordrarList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in ordrarList.SelectedItems)
                {
                    string orderText = $"🧵 Order #{item.SubItems[0].Text} – {item.SubItems[1].Text}";

                    if (!todoList.ContainsKey(selectedDate))
                    {
                        todoList[selectedDate] = new List<string>();
                    }

                    if (!todoList[selectedDate].Contains(orderText))
                    {
                        todoList[selectedDate].Add(orderText);
                    }

                    // Lägg till ordern i den temporära tilldelningsdictionaries
                    int orderId = int.Parse(item.SubItems[0].Text);
                    if (!orderTilldelningar.ContainsKey(orderId))
                    {
                        orderTilldelningar[orderId] = new Dictionary<DateTime, User>();
                    }
                    orderTilldelningar[orderId][selectedDate] = _currentUser; // Tilldela order till användare och datum

                    // Ta bort order från listan
                    var itemToRemove = ordrarList.Items.Cast<ListViewItem>()
                        .FirstOrDefault(i => i.Text == item.SubItems[0].Text);
                    if (itemToRemove != null)
                    {
                        ordrarList.Items.Remove(itemToRemove);
                    }
                }

                ordrarList.SelectedItems.Clear(); // Avmarkera efter tilldelning
            }

            // Visa dagens uppgifter
            listBoxDagens.Items.Clear();
            if (todoList.ContainsKey(selectedDate))
            {
                foreach (var task in todoList[selectedDate])
                {
                    listBoxDagens.Items.Add(task);
                }
            }
        }

        private void btnVeckoöversikt_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            DateTime startOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1);

            richTextBoxVecka.Clear();

            for (int i = 0; i < 7; i++)
            {
                DateTime day = startOfWeek.AddDays(i);
                richTextBoxVecka.AppendText($"📅 {day:dddd (d MMMM)}\n");

                if (todoList.ContainsKey(day))
                {
                    foreach (string task in todoList[day])
                    {
                        richTextBoxVecka.AppendText($" - {task}\n");
                    }
                }
                else
                {
                    richTextBoxVecka.AppendText(" (Inga uppgifter)\n");
                }

                richTextBoxVecka.AppendText("\n");
            }
        }

        private void VisaEjPåbörjadeOrderRader()
        {
            var rader = _context.Orderrader
                .Include(or => or.Order)
                .Where(or => or.StatusOrderrad == StatusOrderradEnum.EjPaborjad)
                .ToList();

            ordrarList.Items.Clear();
            foreach (var rad in rader)
            {
                ordrarList.Items.Add($"Order #{rad.OrderId} – Rad {rad.OrderRadId}: {rad.TypEnum} ({rad.Storlek})");
            }
        }

        // Tomma event eller menyer
        private void beställningarToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void lagerToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void textBoxUppgift_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void richTextBoxVecka_TextChanged(object sender, EventArgs e) { }
        private void ordrarList_SelectedIndexChanged(object sender, EventArgs e) { }
        private void specialbeställningToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void seAlltMaterialToolStripMenuItem_Click(object sender, EventArgs e) { }

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
    }
}
