using Hattmakarens_system.Controllers;
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
    public partial class HanteraMedarbetare : Form
    {
        static MedarbetarController MedarbetarController = new MedarbetarController(new AppDbContext());
        public HanteraMedarbetare()
        {
            InitializeComponent();

        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            var Namn = txtNamn.Text;
            var Epost = lblUpprepaLösen.Text;
            var Lösenord = txtLösenord.Text;
            var UpprepaLösenord = txtUpprepaLösenod.Text;
            bool Behörighet = checkBox1.Checked;

            if (Lösenord == UpprepaLösenord)
            {
                var Registera = MedarbetarController.SkapaNyUser(Namn, Epost, Lösenord, Behörighet);
                MessageBox.Show("Medarebetare är nu tillagd! Välkommen till teamet!!!!!!");

            }
            else
            {
                MessageBox.Show("Lösenordet matchar inte");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HanteraMedarbetare_Load(object sender, EventArgs e)
        {
            MedarbetarController.AllaAktivaMedarbetare();
        }

        private void HanteraMedarbetare_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.homepage.Close();
        }
    }
}
