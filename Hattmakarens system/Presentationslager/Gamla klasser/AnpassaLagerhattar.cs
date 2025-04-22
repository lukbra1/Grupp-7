using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using Microsoft.EntityFrameworkCore;
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
    public partial class AnpassaLagerhattar : Form
    {
        private LagerOrderrad _orderrad;
        private Order _order;
        public Material ValdMaterial { get; private set; }
        static MaterialController materialController = new MaterialController(new AppDbContext());
        Dictionary<string, int> namnTillId = new Dictionary<string, int>();
        public AnpassaLagerhattar(Order order, LagerOrderrad orderrad)
        {
            InitializeComponent();
            _order = order;
            _orderrad = orderrad;

        }

        private void txtFörnamn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string söktext = textBox1.Text;
            List<Material> materialLista = materialController.HamtaMaterialMedNamn(söktext);

            listBox1.Items.Clear();
            namnTillId.Clear();

            foreach (var material in materialLista)
            {
                string visning = $"{material.MaterialId} - {material.Namn} ({material.Farg}) - {material.PrisPerEnhet} kr/{material.Enhet}";
                listBox1.Items.Add(visning);
                namnTillId[visning] = material.MaterialId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vald = (string)listBox1.SelectedItem;

            if (vald != null && namnTillId.TryGetValue(vald, out int id))
            {
                ValdMaterial = materialController.HamtaMaterialMedId(id);

                try
                {
                    // Anropa den statiska metoden i controllerklassen
                    materialController.LäggTillMaterialTillOrderRad(_orderrad.OrderRadId, ValdMaterial.MaterialId);
                    _order.TotalPris += ValdMaterial.PrisPerEnhet;

                    MessageBox.Show("✅ Materialet har lagts till orderraden.");
                    //this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fel vid läggning av material: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("⚠️ Vänligen välj ett material från listan.");
            }
            //string vald = (string)listBox1.SelectedItem;

            //if (vald != null && namnTillId.TryGetValue(vald, out int id))
            //{
            //    ValdMaterial = materialController.HamtaMaterialMedId(id);

            //    using (var context = new AppDbContext())
            //    {
            //        // Attach orderrad så EF vet att den finns
            //        context.Attach(_orderrad);

            //        var materialOrderrad = new MaterialOrderrad
            //        {
            //            MaterialId = ValdMaterial.MaterialId,
            //            OrderRadId = _orderrad.OrderRadId,
            //            OrderRad = _orderrad, // denna rad är viktig!
            //            AntalMaterial = 1
            //        };

            //        context.MaterialOrderrader.Add(materialOrderrad);
            //        try
            //        {
            //            context.SaveChanges();
            //            MessageBox.Show("✅ Materialet har lagts till orderraden.");
            //        }
            //        catch (DbUpdateException ex)
            //        {
            //            MessageBox.Show($"Error: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            //        }


            //    }
            //}
            //else
            //{
            //    MessageBox.Show("⚠️ Vänligen välj ett material från listan.");
            //}

        }

        private void AnpassaLagerhattar_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            var GåVidare = new RegistreraNyttMaterial(_order, _orderrad);
            GåVidare.Show();
            this.Close();
        }

        private void btnGaVidare_Click(object sender, EventArgs e)
        {
            var GåVidare = new Beställning(_order);
            GåVidare.Show();
            this.Close();

        }
    }
}
