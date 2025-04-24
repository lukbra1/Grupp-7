using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hattmakarens_system.Presentationslager
{
    public partial class SkapaFraktsedelForm : Form
    {
        Order order;
        private OrderController controller = new OrderController(new AppDbContext());
        static FraktSedelController db = new FraktSedelController(new AppDbContext());
        private PrintDocument printDocument = new PrintDocument();
        private FraktSedel aktuellFraktsedel;
        private FraktSedel existerandeFraktsedel;
        public SkapaFraktsedelForm(Order order)
        {
            InitializeComponent();
            this.order = order;
            printDocument.PrintPage += PrintDocument_PrintPage;

        }

        private void SkapaFraktsedelForm_Load(object sender, EventArgs e)
        {

            lblOrderId.Text = $"Order-ID: {order.OrderId}";

            existerandeFraktsedel = db.HämtaFraktsedelFörOrder(order.OrderId);

            if (existerandeFraktsedel != null)
            {
                aktuellFraktsedel = existerandeFraktsedel;

                // Fyll fält med befintlig data
                txtVikt.Text = existerandeFraktsedel.Vikt.ToString();
                txtExKod.Text = existerandeFraktsedel.ExportKod.ToString();
                txtTotalPris.Text = existerandeFraktsedel.Värde.ToString();
                txtAdress.Text = existerandeFraktsedel.Adress;
                txtAvsandare.Text = existerandeFraktsedel.Avsändare;
                txtMottagare.Text = existerandeFraktsedel.Mottagare;
                rchtxtBeskrivning.Text = existerandeFraktsedel.Beskrivning;

                // Visa status
                lblStatusFraktsedel.Text = "✅ Fraktsedel är skapad";
                lblStatusFraktsedel.ForeColor = Color.Green;

                // Inaktivera skapa-knappen
                btnSkapa.Enabled = false;
            }
            else
            {
                lblStatusFraktsedel.Text = "❌ Ingen fraktsedel skapad";
                lblStatusFraktsedel.ForeColor = Color.Red;
                btnSkapa.Enabled = true;
            }
        }
        private void btnSkapa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtVikt.Text, out int vikt))
            {
                MessageBox.Show("Vikten måste vara ett heltal!");
                return;
            }
            if (!decimal.TryParse(txtTotalPris.Text, out decimal värde))
            {
                MessageBox.Show("Totalpriset måste vara ett gilitgt tal!");
                return;
            }
            if (!int.TryParse(txtExKod.Text, out int exportKod))
            {
                MessageBox.Show("Exportkoden måste vara ett heltal!");
                return;
            }
            
            decimal prisInkMoms = värde * 1.25m;
            string adress = txtAdress.Text.Trim();
            string avsändare = txtAvsandare.Text.Trim();
            string mottagare = txtMottagare.Text.Trim();
            string beskrivning = rchtxtBeskrivning.Text.Trim();


            if (string.IsNullOrWhiteSpace(adress) |
                string.IsNullOrWhiteSpace(avsändare) |
                string.IsNullOrWhiteSpace(mottagare))
            {
                MessageBox.Show("Fälten; Adress, Avsändare och Mottagare får inte vara tomma");
                return;
            }

                existerandeFraktsedel = db.SkapaFraktsedel(order, vikt, värde, exportKod, adress, avsändare, mottagare, beskrivning);
            aktuellFraktsedel = existerandeFraktsedel;


            MessageBox.Show("Fraktsedel skapad!\nPris inkl. moms: " + existerandeFraktsedel.PrisInkMoms);

            btnSkapa.Enabled = false;
            lblStatusFraktsedel.Text = "✅ Fraktsedel är skapad";
            lblStatusFraktsedel.ForeColor = Color.Green;


        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (aktuellFraktsedel == null)
            {
                e.Cancel = true;
                return;
            }

            float x = 50, y = 50;
            Font rubrik = new Font("Arial", 16, FontStyle.Bold);
            Font text = new Font("Arial", 12);

            //e.Graphics.DrawString("Fraktsedel", rubrik, Brushes.Black, x, y); y += 40;
            ////e.Graphics.DrawString($"OrderID: {aktuellFraktsedel.OrderID}", text, Brushes.Black, x, y); y += 25;
            //e.Graphics.DrawString($"Adress: {aktuellFraktsedel.Adress}", text, Brushes.Black, x, y); y += 25;
            //e.Graphics.DrawString($"Avsändare: {aktuellFraktsedel.Avsändare}", text, Brushes.Black, x, y); y += 25;
            //e.Graphics.DrawString($"Mottagare: {aktuellFraktsedel.Mottagare}", text, Brushes.Black, x, y); y += 25;
            //e.Graphics.DrawString($"Vikt: {aktuellFraktsedel.Vikt} kg", text, Brushes.Black, x, y); y += 25;
            //e.Graphics.DrawString($"Exportkod: {aktuellFraktsedel.ExportKod}", text, Brushes.Black, x, y); y += 25;
            ////e.Graphics.DrawString($"Värde: {aktuellFraktsedel.Värde} kr", text, Brushes.Black, x, y); y += 25;
            ////e.Graphics.DrawString($"Moms: {aktuellFraktsedel.Moms}%", text, Brushes.Black, x, y); y += 25;
            //e.Graphics.DrawString($"Pris inkl. moms: {aktuellFraktsedel.PrisInkMoms} kr", text, Brushes.Black, x, y); y += 25;
            //e.Graphics.DrawString($"Datum: {aktuellFraktsedel.SkapatDatum:yyyy-MM-dd}", text, Brushes.Black, x, y); y = 25;
            //e.Graphics.DrawString($"Beskrivning: {aktuellFraktsedel.Beskrivning}", text, Brushes.Black, x, y); y += 25;

            e.Graphics.DrawString("Fraktsedel", rubrik, Brushes.Black, x, y); y += 40;
            e.Graphics.DrawString($"Adress: {aktuellFraktsedel.Adress}", text, Brushes.Black, x, y); y += 25;
            e.Graphics.DrawString($"Avsändare: {aktuellFraktsedel.Avsändare}", text, Brushes.Black, x, y); y += 25;
            e.Graphics.DrawString($"Mottagare: {aktuellFraktsedel.Mottagare}", text, Brushes.Black, x, y); y += 25;
            e.Graphics.DrawString($"Vikt: {aktuellFraktsedel.Vikt} kg", text, Brushes.Black, x, y); y += 25;
            e.Graphics.DrawString($"Exportkod: {aktuellFraktsedel.ExportKod}", text, Brushes.Black, x, y); y += 25;
            e.Graphics.DrawString($"Pris inkl. moms: {aktuellFraktsedel.PrisInkMoms} kr", text, Brushes.Black, x, y); y += 25;
            e.Graphics.DrawString($"Datum: {aktuellFraktsedel.SkapatDatum:yyyy-MM-dd}", text, Brushes.Black, x, y); y += 25;

            // beskrivningen kommer sist
            e.Graphics.DrawString($"Beskrivning: {aktuellFraktsedel.Beskrivning}", text, Brushes.Black, x, y); y += 25;

        }

        private void btnSkrivUt_Click(object sender, EventArgs e)
        {

            if (aktuellFraktsedel == null)
            {
                MessageBox.Show("Skapa först en fraktsedel!");
                return;
            }

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.Width = 800;
            preview.Height = 600;
            preview.ShowDialog();
        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var tillbaka = new AllaBeställningar();
            tillbaka.Show();
        }
    }

}
