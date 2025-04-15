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

            var fraktsedel = db.SkapaFraktsedel(2, vikt, värde, exportKod, moms);

            MessageBox.Show("Fraktsedel skapad!\nPris inkl. moms: " + fraktsedel.PrisInkMoms);

            MessageBox.Show($@"Fraktsedel:
            - OrderID: {fraktsedel.OrderID}
            - Vikt: {fraktsedel.Vikt} kg
            - Värde: {fraktsedel.Värde} kr
            - Moms: {fraktsedel.Moms} %
            - Total: {fraktsedel.PrisInkMoms} kr
            - Exportkod: {fraktsedel.ExportKod}
            - Datum: {fraktsedel.SkapatDatum}");

        }

    }
}
