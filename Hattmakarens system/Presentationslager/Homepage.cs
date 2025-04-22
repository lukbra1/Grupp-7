using Hattmakarens_system.Presentationslager;
using System;
using System.Collections.Generic;
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

        // 🆕 Lägg till denna konstruktor:
        public Homepage(User user)
        {
            InitializeComponent();
            _currentUser = user;

        }

        public Homepage()
        {
            InitializeComponent();
        }



        private void beställningarToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void lagerToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void Homepage_Load(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar1.SelectionEnd = DateTime.Today;
            UppdateraVeckooversikt(DateTime.Today);

            // Dölja menyval för icke-admin
            if (_currentUser != null && !_currentUser.Behorighet)
            {
                hanteraMedarbetareToolStripMenuItem.Visible = false;
            }

            // 🆕 Visa alla orderrader som ej påbörjats
            VisaEjPåbörjadeOrderRader();
        }

        private void VisaEjPåbörjadeOrderRader()
        {
            // Hämta från DbContext
            var rader = _context.Orderrader
                                .Include(or => or.Order)
                                .Where(or => or.StatusOrderrad == StatusOrderradEnum.EjPaborjad)
                                .ToList();

            // Rensa listbox och fyll på
            ordrarList.Items.Clear();
            foreach (var rad in rader)
            {
                ordrarList.Items.Add(
                    $"Order #{rad.OrderId} – Rad {rad.OrderRadId}: {rad.TypEnum} ({rad.Storlek})");
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

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

        private void textBoxUppgift_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void richTextBoxVecka_TextChanged(object sender, EventArgs e) { }

        private void specialbeställningToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void nyBeställningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var VäljKund = new VäljKund();
            VäljKund.Show();
            this.Hide();
        }

        private void seAlltMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            var materialForm = new SeMaterialbehov();
            materialForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ordrarList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
