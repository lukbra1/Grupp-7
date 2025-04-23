using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hattmakarens_system.Presentationslager
{
    public partial class KundStatistik : Form
    {

        static KundController Kundcontroller = new KundController(new AppDbContext());
        static StatistikController StatistikController = new StatistikController(new AppDbContext());

        Dictionary<string, int> namnTillId = new Dictionary<string, int>();
        public KundStatistik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KundStatistik_Load(object sender, EventArgs e)
        {
            List<Kund> KundLista = Kundcontroller.AllaAktivaKunder();

            listBox2.Items.Clear();

            foreach (var enKund in KundLista)
            {
                string listBoxText = enKund.Fornamn + " " + enKund.Efternamn + " " + enKund.Epost;
                listBox2.Items.Add(listBoxText);
                namnTillId[listBoxText] = enKund.KundId;
            }

            textBox1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sök kund
            string sökNamn = textBox1.Text;
            List<Kund> kundLista = Kundcontroller.HamtaKunderMedNamn(sökNamn);

            listBox2.Items.Clear();
            namnTillId.Clear();
            foreach (var kund in kundLista)
            {
                string visning = $"{kund.KundId} {kund.Fornamn} {kund.Efternamn} {kund.TelefonNr} {kund.Epost}";
                listBox2.Items.Add(visning);
                namnTillId[visning] = kund.KundId;
            }
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            var kundVal = (string)listBox2.SelectedItem;

            int kundId = namnTillId[kundVal];

            var startDatumVal = dateTimePicker1.Value;
            var slutDatumVal = dateTimePicker2.Value;

            if (kundVal != null)
            {
                decimal summan = StatistikController.HämtaTotalSumma(startDatumVal, slutDatumVal, kundId);
                int antalHattar = StatistikController.HämtaAntalHattar(startDatumVal, slutDatumVal, kundId);
                int antalOdrar = StatistikController.HämtaAntalOrdrar(startDatumVal, slutDatumVal, kundId);

                listBox1.Items.Clear();
                listBox1.Items.Add($"Totalt antal sålda hattar: {antalHattar}");
                listBox1.Items.Add($"Totalt antal beställningar: {antalOdrar}");
                listBox1.Items.Add($"Total försäljningssumma: {summan}kr");
            }
            else
            {
                MessageBox.Show("Vänligen välj en kund");
            }
        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.homepage.Show();
        }
    }
}
