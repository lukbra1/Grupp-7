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
using Microsoft.EntityFrameworkCore;
using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;

namespace Hattmakarens_system.Presentationslager
{
    public partial class LaggTillLagerhattar : Form
    {
        Kund kunden;

        static OrderController db = new OrderController(new AppDbContext());
        public LaggTillLagerhattar(Kund kund)
        {

            this.kunden = kund;
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Visa varukorg utan att lägga till hatt
            var Beställning = new Beställning();
            Beställning.Show();
            this.Close();
        }


        private void btnLäggTillStudentMössa_Click(object sender, EventArgs e)
        {


            MessageBox
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
        {
            // Skapa specialbeställningshatt
            var SpecialBeställning = new Specialbeställning();
            SpecialBeställning.Show();
            this.Close();

        }

        private void cbVäljHatt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hattNamn = cbVäljHatt.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(hattNamn))
            {
                // Bygg filnamn (ersätt mellanslag med bindestreck om det behövs annars ta bort denna rad)
                string filnamn = hattNamn + ".jpg";

                // Sökväg till mappen där bilderna ligger
                string bildPath = Path.Combine(Application.StartupPath, "Bilder", filnamn);

                if (File.Exists(bildPath))
                {
                    pictureBoxReferens.Image = Image.FromFile(bildPath);
                }
                else
                {
                    pictureBoxReferens.Image = null;
                    MessageBox.Show("Ingen bild hittades för: " + hattNamn, "Saknad bild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LaggTillLagerhattar_Load(object sender, EventArgs e)
        {
            var hattar = LaggTillLagerhattar.modell

        }
    }
}
