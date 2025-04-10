using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hattmakarens_system
{
    public partial class Homepage : Form
    {
        Dictionary<DateTime, List<string>> todoList = new Dictionary<DateTime, List<string>>();

        public Homepage()
        {
            InitializeComponent();

        }

        private void beställningarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // panelMenu.Visible = !panelMenu.Visible;

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            // Sätt dagens datum som standard på MonthCalendar
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar1.SelectionEnd = DateTime.Today;

            // Anropa metoden som uppdaterar dagens uppgifter och veckoöversikten
            UppdateraVeckooversikt(DateTime.Today);
        }

        private void UppdateraVeckooversikt(DateTime selectedDate)
        {
            // Uppdatera dagens uppgifter
            listBoxDagens.Items.Clear();
            if (todoList.ContainsKey(selectedDate))
            {
                foreach (var task in todoList[selectedDate])
                {
                    listBoxDagens.Items.Add(task);
                }
            }

            // Uppdatera veckoöversikten
            DateTime startOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1); // Måndag
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
            DateTime startOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + 1); // måndag

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

        private void textBoxUppgift_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxVecka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
