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
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hattmakarens_system.Presentationslager
{
    public partial class LaggTillLagerhattar : Form
    {
        Order Ordern;
        private readonly AppDbContext _context = new AppDbContext();
        static OrderController db = new OrderController(new AppDbContext());
        private readonly SpecialController _specialController;
        private readonly Material_OrderradController _materialOrderradController;
        private readonly MaterialController _db = new MaterialController(new AppDbContext());
        public LaggTillLagerhattar(Order Order)
        {
            this.Ordern = Order;
            _specialController = new SpecialController(_context);
            _materialOrderradController = new Material_OrderradController(_context);
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

        }

        private void LaddaMaterial()
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();

            var materialen = _db.getMaterial();

            foreach (var material in materialen)
            {
                listBox1.Items.Add(material);
                listBox3.Items.Add(material);
            }
            listBox1.DisplayMember = "Namn";
            listBox3.DisplayMember = "Namn";
        }



        private void LaggTillLagerhattar_Load(object sender, EventArgs e)
        {
            LaddaMaterial();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.View = View.Details;
            listView2.View = View.Details; 
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

            if (cbVäljHatt.SelectedItem is Modell valdModell)
            {
                lblNamn.Text = valdModell.Namn;

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

            if (cbStorlek.SelectedIndex < 0)
            {
                MessageBox.Show("Vänligen välj en storlek.");
                return;
            }

            StorlekEnum storlek = (StorlekEnum)cbStorlek.SelectedIndex;
            var hattModell = (Modell)cbVäljHatt.SelectedItem;
            int modellId = hattModell.ModellId;

            // Skapa orderad
            var orderRad = db.LäggTillLagerOrderrad(Ordern, modellId);

            int orderRadId = orderRad.OrderRadId;

            // Koppla material till orderraden
            foreach (ListViewItem item in listView2.Items)
            {
                string materialnamn = item.SubItems[0].Text;
                int antal = int.Parse(item.SubItems[1].Text);

                var material = _context.Material.FirstOrDefault(m => m.Namn == materialnamn);
                int matrialId = material.MaterialId;

                if (material != null)
                {
                    _db.LäggTillMaterialTillOrderRad(orderRadId, matrialId, antal);
                }
            }
            LaddaListView();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelSpecHattar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hämta data från formuläret
            string kommentar = richTextBox1.Text;
            string referensbild = buttonRefBild.Text;

            if (comboBox4.SelectedIndex < 0)
            {
                MessageBox.Show("Vänligen välj en storlek.");
                return;
            }

            StorlekEnum storlek = (StorlekEnum)comboBox4.SelectedIndex;

            // Totalpris sätts till 0 (ej beräkning)
            decimal totalPris = 0;

            // Skapa specialorderrad
            var specialOrderrad = _specialController.NySpecialOrderrad(kommentar, referensbild, storlek, totalPris, Ordern);
            _specialController.SparaSpecialOrderrad(specialOrderrad);

            // Koppla material till orderraden
            foreach (ListViewItem item in listView1.Items)
            {
                string materialnamn = item.SubItems[0].Text;
                int antal = int.Parse(item.SubItems[1].Text);

                var material = _context.Material.FirstOrDefault(m => m.Namn == materialnamn);
                if (material != null)
                {
                    var materialOrderrad = _materialOrderradController.NyMaterialOrderrad(material, specialOrderrad, antal);
                    _context.MaterialOrderrader.Add(materialOrderrad);
                }
            }

            // Spara ändringar till databasen
            _context.SaveChanges();

            // Uppdatera listan och visa bekräftelse (valfritt)
            LaddaListView();
            MessageBox.Show("Specialbeställningen har sparats.", "Sparad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        List<Material> MaterialList = new List<Material>();
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Välj ett material och skriv in mängd!");
                return;
            }

            // Hämta valt material
            Material valtMaterial = (Material)listBox1.SelectedItem;

            // Försök tolka mängd som siffra
            if (int.TryParse(textBox1.Text, out int mangd))
            {
                bool hittad = false;

                // Kolla om material redan finns i listan
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text == valtMaterial.Namn)
                    {
                        // Uppdatera mängden
                        int nuvarandeMangd = int.Parse(item.SubItems[1].Text);
                        item.SubItems[1].Text = (nuvarandeMangd + mangd).ToString();
                        hittad = true;
                        break;
                    }
                }

                if (!hittad)
                {
                    // Material finns inte – lägg till ny rad
                    ListViewItem nyItem = new ListViewItem(valtMaterial.Namn);
                    nyItem.SubItems.Add(mangd.ToString());
                    listView1.Items.Add(nyItem);
                }
            }
            else
            {
                MessageBox.Show("Felaktig mängd, skriv en siffra!");
            }
        }

        private void panelLagerHattar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            var Namn = txtNamn.Text;
            var Enhet = txtEnhet.Text;
            var Farg = txtFarg.Text;
            var Beskrivning = rtxtBesk.Text;

            _db.SkapaNyttMaterial(Namn, Enhet, Farg, Beskrivning);
            LaddaMaterial();
            MessageBox.Show("Materialet är tillagd i lager");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefBild_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bildfiler|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                buttonRefBild.Text = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            buttonRefBild.Text = "Hämta referensbild";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem == null || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Välj ett material och skriv in mängd!");
                return;
            }

            // Hämta valt material
            Material valtMaterial = (Material)listBox3.SelectedItem;

            // Försök tolka mängd som siffra
            if (int.TryParse(textBox2.Text, out int mangd))
            {
                bool hittad = false;

                // Kolla om material redan finns i listan
                foreach (ListViewItem item in listView2.Items)
                {
                    if (item.Text == valtMaterial.Namn)
                    {
                        // Uppdatera mängden
                        int nuvarandeMangd = int.Parse(item.SubItems[1].Text);
                        item.SubItems[1].Text = (nuvarandeMangd + mangd).ToString();
                        hittad = true;
                        break;
                    }
                }

                if (!hittad)
                {
                    // Material finns inte – lägg till ny rad
                    ListViewItem nyItem = new ListViewItem(valtMaterial.Namn);
                    nyItem.SubItems.Add(mangd.ToString());
                    listView2.Items.Add(nyItem);
                }
            }
            else
            {
                MessageBox.Show("Felaktig mängd, skriv en siffra!");
            }
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var resultat = MessageBox.Show(
                "Är du klar med beställningen?",
                "Bekräfta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultat == DialogResult.Yes)
            {
                this.Close();
                Program.homepage.Show();
            }
          
        }
    }
}


