using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hattmakarens_system.ModelsNy;

namespace Hattmakarens_system.Presentationslager
{
    public partial class LaggTillLagerhattar : Form
    {
        Order Ordern;
        public LaggTillLagerhattar(Order Order)
        {
            this.Ordern = Order;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Studentmössa



            //using var db = new Database.AppDbContext();
            //var studentHatt = db.Hattmodeller.FirstOrDefault(h => h.HattModellId == 3);
            //if (studentHatt != null)
            //{
            //    AnpassaLagerhattar anpassaLagerhattar = new AnpassaLagerhattar(studentHatt);
            //    anpassaLagerhattar.Show();
            //    this.Close();
            //}
        }

<<<<<<< Updated upstream
        private void button6_Click(object sender, EventArgs e)
=======

        private void btnLäggTillStudentMössa_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Hej");
        }

        private void btnLäggTillDoktorMössa_Click(object sender, EventArgs e)
        {

        }

        private void btnLäggTillOktoberhatt_Click(object sender, EventArgs e)
        {

        }

        private void btnLäggTillFez_Click(object sender, EventArgs e)
        {

        }

        private void btnLäggTillSherlockHatt_Click(object sender, EventArgs e)
        {

        }
        private void btnSpec_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            // Skapa specialbeställningshatt
            var SpecialBeställning = new Specialbeställning();
            SpecialBeställning.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            // Visa varukorg utan att lägga till hatt
            var Beställning = new Beställning(this.Ordern);
            Beställning.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Oktoberhatt
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Doktorsmössa
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Fez-hatt
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Sherlockhatt
=======
            if (cbVäljHatt.SelectedItem is Modell valdModell)
            {
                string hattNamn = valdModell.Namn;
                string filnamn = hattNamn + ".jpg";

                // Sökväg till bin\Debug\netX\Resources\bild.jpg
                string bildPath = Path.Combine(Application.StartupPath, "Resources", filnamn);

                MessageBox.Show(bildPath);
                if (File.Exists(bildPath))
                {
                    // Undvik fil-låsning
                    using (var stream = new FileStream(bildPath, FileMode.Open, FileAccess.Read))
                    {
                        pbReferens.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    pbReferens.Image = null;
                    MessageBox.Show($"Ingen bild hittades för: {hattNamn}", "Saknad bild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
>>>>>>> Stashed changes
        }


        private void LaggTillLagerhattar_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
=======
            var hattar = db.HämtaAllaModeller();
>>>>>>> Stashed changes

            if (hattar != null && hattar.Any())
            {
                cbVäljHatt.DataSource = hattar;
                cbVäljHatt.DisplayMember = "Namn";
                cbVäljHatt.ValueMember = "ModellId";
            }
            else
            {
                MessageBox.Show("Inga hattmodeller hittades.");
            }
        }
    }
}
