using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
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

        private void btnRedigera_Click(object sender, EventArgs e)
        {
            if (lvAlla.SelectedItems.Count == 0)
            {
                MessageBox.Show("Välj en order först.");
                return;
            }

            // Hämta den valda raden
            var valdRad = lvAlla.SelectedItems[0];

            // Vi sparade order-objektet i Tag tidigare
            if (valdRad.Tag is Hattmakarens_system.ModelsNy.Order valdOrder)
            {
                // Öppna RedigeraOrder och skicka med OrderId
                var redigeraForm = new RedigeraOrder(valdOrder.OrderId);
                redigeraForm.Show(); // eller .ShowDialog() om du vill blockera
            }
        }
    }
}

