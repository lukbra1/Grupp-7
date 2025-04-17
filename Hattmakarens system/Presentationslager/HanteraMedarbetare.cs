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
            var Epost = txtEpost.Text;
            var Lösenord = txtLösenord.Text;
            var UpprepaLösenord = txtUpprepaLösenod.Text;
            bool Behörighet = checkBox1.Checked;

            if (Lösenord == UpprepaLösenord)
            {
                var Registera = MedarbetarController.SkapaNyUser(Name, Epost, Lösenord, Behörighet);
            }
            else
            {
                MessageBox.Show("Lösenordet matchar inte");
            }
        }
    }
}
