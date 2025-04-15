using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using Hattmakarens_system.Presentationslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hattmakarens_system
{
    public partial class Specialbeställning : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        private readonly SpecialController _specialController;
        private readonly Material_OrderradController _materialOrderradController;
        private readonly MaterialController db = new MaterialController(new AppDbContext());
        public Order Ordern { get; set; }
        public Specialbeställning(Order order)
        {
            Ordern = order;
            _specialController = new SpecialController(_context);
            _materialOrderradController = new Material_OrderradController(_context);
            InitializeComponent();

        }

        private void Specialbeställning_Load(object sender, EventArgs e)
        {
            FyllListBoxMedMaterial();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.View = View.Details; // Viktigt!
            listView1.Columns.Add("Material", 150); // Kolumnnamn + bredd
            listView1.Columns.Add("Mängd", 100);

        }

        private void btnSparaSpecialBeställning_Click(object sender, EventArgs e)
        {
            //    using (var context = new Database.AppDbContext())
            //    {

            //        var nyOrderRad = new OrderRad
            //        {
            //            Typ = HattEnum.Special,
            //            Pris = 1500,
            //            UserId = 1, // exempel
            //            HattModellId = 2,
            //            OrderId = 1 // Exempel
            //        };


            //        var nySpecial = new Models.SpecialHattDetaljer
            //        {
            //            Farg = txtFärg.Text,
            //            Tyg = txtTyg.Text,
            //            Dekoration = txtDek.Text,
            //            Storlek = txtStorlek.Text,
            //            Modell = txtModell.Text,
            //            Fjader = txtFjäder.Text,
            //            ExtraMaterial = txtExtraMat.Text,
            //            Text = txtText.Text,
            //            Kommentar = rtxtKommentar.Text,

            //        };

            //        var controller = new SpecialController();
            //        controller.SparaSpecialBeställning(nySpecial);

            //        MessageBox.Show("Specialbeställning sparad!");
            //    }
        }

        private void txtExtraMat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hämta info från formuläret
            string kommentar = richTextBox1.Text;
            string referensbild = textBox3.Text;
            StorlekEnum storlek = 0;
            if (comboBox3.SelectedIndex>-1)
            {
                storlek = (StorlekEnum)comboBox3.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Vänligen välj en storlek");
                return;
            }

            decimal totalPris = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                string materialNamn = item.SubItems[0].Text;
                int mängd = int.Parse(item.SubItems[1].Text);
                Material material = db.getMaterial().FirstOrDefault(m => m.Namn == materialNamn);

                if (material != null && mängd > 0)
                {
                    totalPris += material.PrisPerEnhet * mängd;

                }
            }
            

            // Skapa specialorderrad
            var specialOrderrad = _specialController.NySpecialOrderrad(kommentar, referensbild, storlek, totalPris, Ordern);
            _specialController.SparaSpecialOrderrad(specialOrderrad);

            // Spara tillhörande materialrader
            foreach (ListViewItem item in listView1.Items)
            {
                string materialnamn = item.SubItems[0].Text;
                int antal = int.Parse(item.SubItems[1].Text);

                var material = _context.Material.FirstOrDefault(m => m.Namn == materialnamn);
                if (material != null)
                {
                    var matOrdRad = _materialOrderradController.NyMaterialOrderrad(material, specialOrderrad, antal);
                    _context.MaterialOrderrader.Add(matOrdRad);
                }
            }
            Ordern.TotalPris += totalPris;
            _context.SaveChanges();

            var tjo = new Beställning(Ordern);
            tjo.Show();
            this.Close();





        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        List<Material> MaterialList = new List<Material>();
        private void button3_Click(object sender, EventArgs e)
        {
            decimal totalPris = 0;




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

                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text == valtMaterial.Namn)
                    {
                        // Materialet finns redan – uppdatera mängden
                        int nuvarandeMangd = int.Parse(item.SubItems[1].Text);
                        item.SubItems[1].Text = (nuvarandeMangd + mangd).ToString();
                        hittad = true;
                        break;
                    }
                }

                if (!hittad)
                {
                    // Materialet finns inte – skapa ny rad
                    ListViewItem nyItem = new ListViewItem(valtMaterial.Namn);
                    nyItem.SubItems.Add(mangd.ToString());
                    listView1.Items.Add(nyItem);
                    

                    foreach (ListViewItem item in listView1.Items)
                    {
                        string materialNamn = item.SubItems[0].Text;
                        int mängd = int.Parse(item.SubItems[1].Text);
                        Material material = db.getMaterial().FirstOrDefault(m => m.Namn == materialNamn);

                        if (material != null && mängd > 0)
                        {
                            totalPris += material.PrisPerEnhet * mängd;

                        }
                    }
                }

                MessageBox.Show("La till " + mangd +  " av " + valtMaterial.Namn +  ", Total priset är nu " + totalPris);
            }

            else
            {
                MessageBox.Show("Felaktig mängd, skriv en siffra!");
            }


        }


        private void FyllListBoxMedMaterial()
        {

            listBox1.Items.Clear();
            listBox1.DataSource = db.getMaterial();
            listBox1.DisplayMember = "Namn";
        }
       

    }
}

