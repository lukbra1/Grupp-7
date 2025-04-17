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
            // Skapa beställning med ny kund
            var RegisteraKund = new RegistreraKund();
            RegisteraKund.Show();
            this.Close();
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

        }
    }
}
