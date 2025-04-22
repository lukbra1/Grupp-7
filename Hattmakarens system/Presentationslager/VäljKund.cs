using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hattmakarens_system.Presentationslager
{
    public partial class VäljKund : Form
    {
        static KundController Kundcontroller = new KundController(new AppDbContext());
        static OrderController Ordercontroller = new OrderController(new AppDbContext());

        Dictionary<string, int> namnTillId = new Dictionary<string, int>();

        public VäljKund()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Skapa beställning med existerande kund
            var valdKund = (string)listBox1.SelectedItem;

            try
            {

                var kundId = namnTillId[valdKund];
                Kund kund = VäljKund.Kundcontroller.HamtaKundFranId(kundId);

                Order Order = Ordercontroller.SkapaNyOrder(kundId);

                var LaggTillLagerhattar = new LaggTillLagerhattar(Order);

                LaggTillLagerhattar.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vänligen välj kund från listan");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sök kund
            string sökNamn = textBox1.Text;
            List<Kund> kundLista = VäljKund.Kundcontroller.HamtaKunderMedNamn(sökNamn);

            listBox1.Items.Clear();
            namnTillId.Clear();
            foreach (var kund in kundLista)
            {
                string visning = $"{kund.KundId} {kund.Fornamn} {kund.Efternamn} {kund.TelefonNr} {kund.Epost}";
                listBox1.Items.Add(visning);
                namnTillId[visning] = kund.KundId;
            }
        }

        private void VäljKund_Load(object sender, EventArgs e)
        {
            List<Kund> KundLista = Kundcontroller.AllaAktivaKunder();

            listBox1.Items.Clear();

            foreach (var enKund in KundLista)
            {
                string listBoxText = enKund.Fornamn + " " + enKund.Efternamn + " " + enKund.Epost;
                listBox1.Items.Add(listBoxText);
                namnTillId[listBoxText] = enKund.KundId;
            }

            textBox1.Select();
            
        }

        private void tiibakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.homepage.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {

            var Förnamn = txtForNamn.Text;
            var Efternamn = txtEfterName.Text;
            var Telefon = txtTel.Text;
            var Epost = txtEmail.Text;
            var Adress = txtAddress.Text;

            Kundcontroller.SkapaNyKund(Förnamn, Efternamn, Telefon, Epost, Adress);

            MessageBox.Show("Kunden är tillagd");
            VäljKund_Load(sender, e);

        }

        private void VäljKund_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
