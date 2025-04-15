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

        private void btnLäggtill_Click(object sender, EventArgs e)
        {
            if (cbVäljHatt.SelectedItem is Modell valdModell)
            {
                try
                {
                    if (chbAnpassa.Checked)
                    {
                        // Skapa en tom LagerOrderrad som skickas till anpassningsformuläret
                        var nyOrderrad = new LagerOrderrad
                        {
                            ModellId = valdModell.ModellId,
                            OrderId = Ordern.OrderId,
                            UserId = null,
                            Tillverkad = false,
                            StatusOrderrad = StatusOrderradEnum.EjPaborjad
                        };

                        var anpassningsForm = new AnpassaLagerhattar(nyOrderrad);
                        anpassningsForm.Show();
                        this.Dispose();
                    }
                    else
                    {
                        // Endast spara direkt om det inte är en anpassning
                        LagerOrderrad nyOrderrad = db.LäggTillLagerOrderrad(Ordern.OrderId, valdModell.ModellId);

                        MessageBox.Show($"Hatten '{valdModell.Namn}' har lagts till i ordern.", "Tillagd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fel: " + ex.Message, "Fel vid sparning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Välj en hatt först.", "Ingen hatt vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





    }
}
