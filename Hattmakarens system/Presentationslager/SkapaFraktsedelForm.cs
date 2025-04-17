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

namespace Hattmakarens_system.Presentationslager
{
    public partial class SkapaFraktsedelForm : Form
    {
        Order order;
        private OrderController controller = new OrderController(new AppDbContext());
        static FraktSedelController db = new FraktSedelController(new AppDbContext());
        public SkapaFraktsedelForm(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void SkapaFraktsedelForm_Load(object sender, EventArgs e)
        {
            lblOrderId.Text = $"Order-ID: {order.OrderId}";
        }
        private void btnSkapa_Click(object sender, EventArgs e)
        {
            int vikt = int.Parse(txtVikt.Text);
            int exportKod = int.Parse(txtExportkod.Text);
            decimal värde = decimal.Parse(txtKostnad.Text);
            double moms = double.Parse(txtMoms.Text);
            string adress = txtAdress.Text;
            string avsändare =txtAvsandare.Text;
            string mottagre = txtMottagare.Text;
            string beskrivning = rchtxtBeskrivning.Text;


            var fraktsedel = db.SkapaFraktsedel(order, vikt, värde, exportKod, moms, adress, avsändare,mottagre,beskrivning );

            MessageBox.Show("Fraktsedel skapad!\nPris inkl. moms: " + fraktsedel.PrisInkMoms);

            MessageBox.Show($@"Fraktsedel:
            - Adress: {fraktsedel.Adress}
            - Avsändare: {fraktsedel.Avsändare}
            -Mottagre: {fraktsedel.Mottagare}
            -Beskrivning: {fraktsedel.Beskrivning}
            -Exportkod: {fraktsedel.ExportKod}
            -Pris {fraktsedel.Värde} kr
            - Vikt: {fraktsedel.Vikt} kg
            - Moms: {fraktsedel.Moms} %
            - Total: {fraktsedel.PrisInkMoms} kr
            - Datum: {fraktsedel.SkapatDatum}");


        }

        private void txtVikt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
