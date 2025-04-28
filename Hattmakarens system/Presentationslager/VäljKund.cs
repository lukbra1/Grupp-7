using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;

namespace Hattmakarens_system.Presentationslager
{
    public partial class VäljKund : Form
    {
        private AppDbContext _context;
        private KundController _kundController;
        private OrderController _ordercontroller;

        private bool klickatVidareKnapp = false;
        private Dictionary<string, int> _listBoxKund_KundId;

        public VäljKund()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _kundController = new KundController(_context);
            _ordercontroller = new OrderController(_context);
            _listBoxKund_KundId = new Dictionary<string, int>();
        }
        private void VäljKund_Load(object sender, EventArgs e)
        {
            LaddaKunder();
            textBox1.Select();
        }

        public void LaddaKunder()
        {
            List<Kund> KundLista = _kundController.AllaAktivaKunder();

            listBox1.Items.Clear();

            foreach (var enKund in KundLista)
            {
                string listBoxText = enKund.Fornamn + " " + enKund.Efternamn + " " + enKund.Epost;
                listBox1.Items.Add(listBoxText);
                _listBoxKund_KundId[listBoxText] = enKund.KundId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string valdKund = (string) listBox1.SelectedItem;

            try
            {
                int kundId = _listBoxKund_KundId[valdKund];
                Kund kund = _kundController.HamtaKundFranId(kundId);
                Order Order = _ordercontroller.SkapaNyOrder(kundId);

                klickatVidareKnapp = true;
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
           
            string sökNamn = textBox1.Text;
            List<Kund> kundLista = _kundController.HamtaKunderMedNamn(sökNamn);

            listBox1.Items.Clear();
            _listBoxKund_KundId.Clear();
            foreach (var kund in kundLista)
            {
                string visning = $"{kund.KundId} {kund.Fornamn} {kund.Efternamn} {kund.TelefonNr} {kund.Epost}";
                listBox1.Items.Add(visning);
                _listBoxKund_KundId[visning] = kund.KundId;
            }
        }


        private void tiibakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            klickatVidareKnapp = true;
            Program.homepage.Show();
            this.Close();
        }
        private void btnRegistrera_Click(object sender, EventArgs e)
        {
           
            var Förnamn = txtForNamn.Text;
            var Efternamn = txtEfterName.Text;
            var Telefon = txtTel.Text;
            var Epost = txtEmail.Text;
            var Adress = txtAddress.Text;

            _kundController.SkapaNyKund(Förnamn, Efternamn, Telefon, Epost, Adress);

            MessageBox.Show("Kunden är tillagd");
            LaddaKunder();

        }

        private void VäljKund_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!klickatVidareKnapp)
            {
                Program.homepage.Close();
            }
        }
    }
}
