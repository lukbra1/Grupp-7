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
        OrderController db;
        AppDbContext _context;
        private Homepage _homepage;

        public AllaBeställningar(Homepage homepage)
        {
            InitializeComponent();
            _context = new AppDbContext();
            this.db = new OrderController(_context);
            this._homepage = homepage;
        }

        private void AllaBeställningar_Load(object sender, EventArgs e)
        {

            var ordrar = db.SorteraOdrar();

            lvAlla.Items.Clear();

            foreach (var order in ordrar)
            {
                var rad = new ListViewItem(order.OrderId.ToString());
                var totalPris = db.BeräknaOrderPrisInkMoms(order);

                rad.SubItems.Add(order.Skapad.ToShortDateString());
                rad.SubItems.Add(order.Status.ToString());
                rad.SubItems.Add(order.Express ? "Ja" : "Nej");
                rad.SubItems.Add($"{totalPris:F2} kr");

                rad.Tag = order;
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
                    var redigeraForm = new RedigeraOrder(valdOrder, this, Program.homepage);
                    redigeraForm.Show();
                    this.Hide();
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
                    var fraktForm = new SkapaFraktsedelForm(valdOrder, this);
                    fraktForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Välj en order först!", "Ingen vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tiibakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.homepage.Show();
        }

        private void buttonFoljesedel_Click(object sender, EventArgs e)
        {

            if (lvAlla.SelectedItems.Count > 0)
            {
                var valdRad = lvAlla.SelectedItems[0];
                var valdOrder = valdRad.Tag as Order;

                if (valdOrder != null)
                {
                    var foljesedelForm = new FoljesedelForm(valdOrder, this);
                    foljesedelForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Välj en order först!", "Ingen vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}



