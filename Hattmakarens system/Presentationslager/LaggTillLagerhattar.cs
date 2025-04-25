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
        private Order Ordern;
        private readonly AppDbContext _context;
        private readonly OrderController _orderController;
        private readonly SpecialController _specialController;
        private readonly MaterialController _materialController;
        private bool klickatVidareKnapp = false;
        public LaggTillLagerhattar(Order Order)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _orderController = new OrderController(_context);
            _specialController = new SpecialController(_context);
            _materialController = new MaterialController(_context);
            this.Ordern = Order;

            List<OrderRad> OrderRader = _orderController.HämtaAllaOrderRader(Order);


            // Hämta orderrader för ordern
            List<OrderRad> orderRaderna = _orderController.HämtaAllaOrderRader(Ordern);

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
        private void LaggTillLagerhattar_Load(object sender, EventArgs e)
        {
            LaddaMaterial();
            var hattar = _orderController.HämtaAllaModeller();

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
        private void LaddaOrderrader()
        {
            lvBeställningar.Items.Clear();

            var orderrader = _orderController.HämtaAllaOrderRader(Ordern);

            foreach (var orderrad in orderrader)
            {
                ListViewItem item = new ListViewItem(orderrad.TypEnum.ToString());
                item.SubItems.Add(orderrad is LagerOrderrad lager ? lager.Modell?.Namn : "Special");
                item.SubItems.Add(orderrad.Storlek.ToString());

                lvBeställningar.Items.Add(item);
            }

        }

        private void LaddaMaterial()
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();

            List<Material> materialen = _materialController.getMaterial();

            foreach (Material material in materialen)
            {
                listBox1.Items.Add(material);
                listBox3.Items.Add(material);
            }
            listBox1.DisplayMember = "Namn";
            listBox3.DisplayMember = "Namn";
        }
        private void cbVäljHatt_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbVäljHatt.SelectedItem is Modell valdModell)
            {
                lblNamn.Text = valdModell.Namn;

                string hattNamn = valdModell.Namn; // korrekt namn
                string filnamn = hattNamn + ".jpg";
                string bildPath = Path.Combine(Application.StartupPath, "Resources", filnamn);
                LaddaOrderrader();

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
            Modell hattModell = (Modell) cbVäljHatt.SelectedItem;
            int modellId = hattModell.ModellId;

            // Skapa orderad
            var orderRad = _orderController.LäggTillLagerOrderrad(Ordern, modellId, storlek);

            int orderRadId = orderRad.OrderRadId;

            // Koppla material till orderraden
            foreach (ListViewItem item in listView2.Items)
            {
                string materialnamn = item.SubItems[0].Text;
                int antal = int.Parse(item.SubItems[1].Text);

                Material material = _context.Material.FirstOrDefault(m => m.Namn == materialnamn);
                int matrialId = material.MaterialId;

                if (material != null)
                {
                    _materialController.LäggTillMaterialTillOrderRad(orderRadId, matrialId, antal);
                }
            }
            listView2.Items.Clear();
            LaddaOrderrader();
            
        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klickatVidareKnapp = true;
            this.Close();
            var previousForm = new VäljKund();
            previousForm.Show();
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
            SpecialOrderrad specialOrderrad = _specialController.NySpecialOrderrad(kommentar, referensbild, storlek, totalPris, Ordern);
            _specialController.SparaSpecialOrderrad(specialOrderrad);

            // Koppla material till orderraden
            foreach (ListViewItem item in listView1.Items)
            {
                string materialnamn = item.SubItems[0].Text;
                int antal = int.Parse(item.SubItems[1].Text);

                Material material = _context.Material.FirstOrDefault(m => m.Namn == materialnamn);
                if (material != null)
                {
                    MaterialOrderrad materialOrderrad = _materialController.NyMaterialOrderrad(material, specialOrderrad, antal);
                    _context.MaterialOrderrader.Add(materialOrderrad);
                }
            }

            // Spara ändringar till databasen
            _context.SaveChanges();

            // Uppdatera listan och visa bekräftelse (valfritt)
            LaddaOrderrader();
            listView1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Välj ett material och skriv in antal!");
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

        private void button6_Click(object sender, EventArgs e)
        {
            string Namn = txtNamn.Text;
            string Enhet = txtEnhet.Text;
            string Farg = txtFarg.Text;
            string Beskrivning = rtxtBesk.Text;

            if(_materialController.SkapaNyttMaterial(Namn, Enhet, Farg, Beskrivning) != null)
            {
                txtNamn.Text = "";
                txtEnhet.Text = "";
                txtFarg.Text = "";
                rtxtBesk.Text = "";
                LaddaMaterial();
                MessageBox.Show("Materialet är tillagd i lager");
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lvBeställningar.Items.Count > 0)
            {
                var resultat = MessageBox.Show(
                    "Är du klar med beställningen?",
                    "Bekräfta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (resultat == DialogResult.Yes)
                {
                    Ordern.Express = checkBox2.Checked;
                    _context.Ordrar.Update(Ordern);
                    _context.SaveChanges();
                    klickatVidareKnapp = true;
                    this.Close();
                    Program.homepage = new Homepage(Program.aktuellAnvändare);
                    Program.homepage.Show();
                }
            }
            else
            {
                var fråga = MessageBox.Show(
                    "Beställningen saknar hattar, vill du avbryta och ta bort beställningen?",
                    "Bekräfta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (fråga == DialogResult.Yes)
                {
                    _orderController.TaBortTomOrder(Ordern);
                    klickatVidareKnapp = true;
                    this.Close();
                    //Program.homepage = new Homepage(Program.aktuellAnvändare);
                    Program.homepage.Show();
                }
            }

        }

        private void LaggTillLagerhattar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!klickatVidareKnapp)
            {
                Program.homepage.Close();
            }
        }
    }
}


