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
    public partial class LaggTillLagerhattar : Form
    {
        Order Ordern;
        static OrderController db = new OrderController(new AppDbContext());
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

        private void button6_Click(object sender, EventArgs e)
        {
            // Skapa specialbeställningshatt
            var SpecialBeställning = new Specialbeställning();
            SpecialBeställning.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Visa varukorg utan att lägga till hatt
            var Beställning = new Beställning(this.Ordern);
            Beställning.Show();
            this.Close();
        }





        private void LaggTillLagerhattar_Load(object sender, EventArgs e)
        {
            var hattar = db.HämtaAllaModeller();

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


        private void cbVäljHatt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string hattNamn = cbVäljHatt.SelectedItem?.ToString();

            if (cbVäljHatt.SelectedItem is Modell valdModell)
            {
                lblNamn.Text = valdModell.Namn;
                lblPris.Text = $"{valdModell.Pris} kr"; // Anpassa efter valutaformat

                string hattNamn = valdModell.Namn; // korrekt namn
                string filnamn = hattNamn + ".jpg";
                string bildPath = Path.Combine(Application.StartupPath, "Resources", filnamn);

                if (File.Exists(bildPath))
                {
                    pbReferens.Image = Image.FromFile(bildPath);
                }
                else
                {
                    pbReferens.Image = null;
                    MessageBox.Show("Ingen bild hittades för: " + hattNamn, "Saknad bild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }




        }
    }
}
