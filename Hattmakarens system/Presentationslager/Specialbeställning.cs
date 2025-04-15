using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
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
        static MaterialController db = new MaterialController(new AppDbContext());
        public Specialbeställning()
        {
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

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
                }

                MessageBox.Show($"La till {mangd} av {valtMaterial.Namn}!");
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

