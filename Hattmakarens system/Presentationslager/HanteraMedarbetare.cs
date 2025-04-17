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
///using Microsoft.VisualBasic.ApplicationServices;

namespace Hattmakarens_system.Presentationslager
{
    public partial class HanteraMedarbetare : Form
    {
        Dictionary<string, User> namnTillUser = new Dictionary<string, User>();

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
                var Registera = MedarbetarController.SkapaNyUser(Namn, Epost, Lösenord, Behörighet);
                MessageBox.Show("Medarebetare är nu tillagd! Välkommen till teamet!!!!!!");
                HanteraMedarbetare_Load(sender, e);

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
            List<User> medarbetareLista = MedarbetarController.AllaAktivaMedarbetare();

            listBox1.Items.Clear();

            foreach (var medarbetaren in medarbetareLista)
            {
                string listBoxText = medarbetaren.Namn + " " + medarbetaren.Epost;
                listBox1.Items.Add(listBoxText);
                namnTillUser[listBoxText] = medarbetaren;
            }
        }

        private void HanteraMedarbetare_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.homepage.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sök = txtSök.Text;

            List<User> medarbetare = MedarbetarController.HamtaMedarbetareMedNamn(sök);

            listBox1.Items.Clear();
            namnTillUser.Clear();

            foreach (var medarbetaren in medarbetare)
            {
                string listBoxText = medarbetaren.Namn + " " + medarbetaren.Epost;
                listBox1.Items.Add(listBoxText);
                namnTillUser[listBoxText] = medarbetaren;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var vald = (string)listBox1.SelectedItem;

            if (vald != null)
            {
                User user = namnTillUser[vald];
                MedarbetarController.RaderaMedarbetare(user);
                MessageBox.Show("Medarbetaren är borttagen");
                HanteraMedarbetare_Load(sender, e);


            }
            else
            {
                MessageBox.Show("Vanligen välj medarbetare att ta bort");
            }
        }
    }
}
