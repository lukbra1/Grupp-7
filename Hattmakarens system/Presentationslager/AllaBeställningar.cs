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
    public partial class AllaBeställningar : Form
    {
        static OrderController db = new OrderController(new AppDbContext());

        public AllaBeställningar()
        {
            InitializeComponent();
        }

        private void AllaBeställningar_Load(object sender, EventArgs e)
        {

            var ordrar = db.HämtaAllaOrdrar(); // 🧠 Metoden du redan har

            lvAlla.Items.Clear(); // Rensa först

            foreach (var order in ordrar)
            {
                // Skapa en rad i listview
                var rad = new ListViewItem(order.OrderId.ToString());

                rad.SubItems.Add(order.Skapad.ToShortDateString());
                rad.SubItems.Add(order.Status.ToString());
                rad.SubItems.Add(order.Express ? "Ja" : "Nej");
                rad.SubItems.Add($"{order.TotalPris} kr");

                // Lägg till hela orderobjektet som tag (så du kan använda det sen)
                rad.Tag = order;

                // Lägg till i listview
                lvAlla.Items.Add(rad);
            }
        }

        private void lvAlla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRedigera_Click(object sender, EventArgs e)
        {

            if (lvAlla.SelectedItems.Count > 0)
            {
                var valdRad = lvAlla.SelectedItems[0];
                var valdOrder = valdRad.Tag as Order;

                if (valdOrder != null)
                {
                    // Öppna redigeringsformuläret och skicka med OrderId
                    var redigeraForm = new RedigeraOrder(valdOrder);
                    redigeraForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Välj en order först!", "Ingen vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSkapaFraktSedel_Click(object sender, EventArgs e)
        {
            if (lvAlla.SelectedItems.Count > 0)
            {
                var valdRad = lvAlla.SelectedItems[0];
                var valdOrder = valdRad.Tag as Order;

                if (valdOrder != null)
                {
                    // Öppna formulär för fraktsedel
                    var fraktForm = new SkapaFraktsedelForm(valdOrder);
                    fraktForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Välj en order först!", "Ingen vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


