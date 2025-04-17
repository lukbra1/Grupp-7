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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            List<OrderRad> OrderRader = db.HämtaAllaOrderRader(Order);


            // Hämta orderrader för ordern
            var orderRaderna = db.HämtaAllaOrderRader(Ordern);

            // Töm listan och fyll med orderrader
            lvBeställningar.Items.Clear();

            foreach (var orderRad in orderRaderna)
            {
                string displayText = "";

                if (orderRad is LagerOrderrad lager)
                {
                    displayText = $"Lagerhatt - Modell: {lager.Modell?.Namn}, Storlek: {lager.Storlek}";
                }
                else if (orderRad is SpecialOrderrad special)
                {
                    displayText = $"Specialhatt - Kommentar: {special.Kommentar}, Storlek: {special.Storlek}";
                }

                lvBeställningar.Items.Add(displayText);
            }

            lblTotal.Text = $"Totalt pris: {Ordern.TotalPris} kr";
        }

        private void LaddaListView()
        {
            lvBeställningar.Items.Clear(); // Töm listan

            // Hämta alla orderrader (exempel från DB eller controller)
            var orderrader = db.HämtaAllaOrderRader(Ordern);

            foreach (var orderrad in orderrader)
            {
                var item = new ListViewItem(orderrad.TypEnum.ToString());
                item.SubItems.Add(orderrad is LagerOrderrad lager ? lager.Modell?.Namn : "Special");
                item.SubItems.Add(orderrad.Storlek.ToString());

                lvBeställningar.Items.Add(item);
            }
            lblTotal.Text = $"Totalt pris: {Ordern.TotalPris} kr";

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
                LaddaListView();

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

                        db.LäggTillLagerOrderrad(Ordern, nyOrderrad);
                        var anpassningsForm = new AnpassaLagerhattar(Ordern, nyOrderrad);
                        anpassningsForm.Show();
                        this.Dispose();
                    }
                    else
                    {
                        // Endast spara direkt om det inte är en anpassning
                        LagerOrderrad nyOrderrad = db.LäggTillLagerOrderrad(Ordern, valdModell.ModellId);

                        MessageBox.Show($"Hatten '{valdModell.Namn}' har lagts till i ordern.", "Tillagd", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LaddaListView();
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

        private void btnVisaBeställning_Click(object sender, EventArgs e)
        {
            var beställningsForm = new Beställning(Ordern);
            beställningsForm.Show();
            this.Hide();
        }

        private void btnSpec_Click(object sender, EventArgs e)
        {
            var SpecialBeställning = new Specialbeställning(Ordern);
            SpecialBeställning.Show();
            this.Hide();
        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var previousForm = new VäljKund();
            previousForm.Show();
        }
    }
}

