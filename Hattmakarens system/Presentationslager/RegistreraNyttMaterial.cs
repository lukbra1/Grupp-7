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
    public partial class RegistreraNyttMaterial : Form
    {

        private LagerOrderrad _orderrad;
        private Order _order;

        static MaterialController materialController = new MaterialController(new AppDbContext());

        public RegistreraNyttMaterial(Order order, LagerOrderrad orderrad)
        {
            _order = order;
            this._orderrad = orderrad;
            InitializeComponent();
        }

        private void btnGaVidare_Click(object sender, EventArgs e)
        {
            var GåVidare = new AnpassaLagerhattar(_order, _orderrad);
            GåVidare.Show();
            this.Close();
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {

            var Namn = txtNamn.Text;
            var PrisPerEnhet = txtPrisPerEnhet.Text;
            var Enhet = txtEnhet.Text;
            var Farg = txtFarg.Text;
            var Beskrivning = txtBeskrivning.Text;

            if (decimal.TryParse(PrisPerEnhet, out decimal DecimalPrisPerEnhet))
            {
                // Allt okej – anropa metoden med konverterat decimalvärde
                materialController.SkapaNyttMaterial(Namn, DecimalPrisPerEnhet, Enhet, Farg, Beskrivning);
                MessageBox.Show("Materialet är tillagd i lager");
            }
            else
            {
                // Visa felmeddelande om priset inte går att tolka
                MessageBox.Show("⚠️ Ange ett giltigt pris (ex: 99,90)");
            }

        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var previousForm = new Homepage();
            previousForm.Show();
        }
    }
}
