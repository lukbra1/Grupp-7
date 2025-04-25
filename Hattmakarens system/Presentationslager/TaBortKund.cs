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
    public partial class TaBortKund : Form
    {
        static KundController Kundcontroller = new KundController(new AppDbContext());
        private bool klickatVidareKnapp = false;
        private Homepage _homepage;


        public TaBortKund(Homepage homepage)
        {
            InitializeComponent();
            this.Load += TaBortKund_Load;
            this._homepage = homepage;


        }

        private void TaBortKund_Load(object sender, EventArgs e)
        {
            var kundLista = Kundcontroller.HämtaAllaKunder()
                .Select(k => new
                {
                    Namn = k.Fornamn + " " + k.Efternamn,
                    Kund = k
                })
                .ToList();

            lstKunder.DataSource = kundLista;
            lstKunder.DisplayMember = "Namn";
        }

        private void btnTaBortKund_Click(object sender, EventArgs e)
        {
            if (lstKunder.SelectedItem is not null)
            {
                dynamic vald = lstKunder.SelectedItem;
                Kund valdKund = vald.Kund;

                var confirm = MessageBox.Show(
                    $"Vill du verkligen ta bort {valdKund.Fornamn} {valdKund.Efternamn}?",
                    "Bekräfta borttagning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    Kundcontroller.TaBortKund(valdKund.KundId);
                    MessageBox.Show("Kund borttagen.");
                    TaBortKund_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Välj en kund först.");
            }
        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klickatVidareKnapp = true;
            _homepage.UppdateraData();
            Program.homepage.Show();
            this.Close();
        }

        private void TaBortKund_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!klickatVidareKnapp)
            {
                Program.homepage.Close();
            }
        }
    }
}
