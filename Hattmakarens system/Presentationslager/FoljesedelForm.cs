using Hattmakarens_system.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System.Drawing.Printing;

namespace Hattmakarens_system.Presentationslager
{
    public partial class FoljesedelForm : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        Order _order;
        private FoljesedelController db = new FoljesedelController(new AppDbContext());
        public FoljesedelForm(Order order)
        {
            _order = order;
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Fonts och penslar
            Font rubrikFont = new Font("Arial", 18, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12);
            Font fetFont = new Font("Arial", 12, FontStyle.Bold);
            Brush pensel = Brushes.Black;
            float x = 50;
            float y = 50;

            // Följesedel Rubrik
            e.Graphics.DrawString("Följesedel", rubrikFont, Brushes.Teal, x, y);
            y += 40;

            // Linje
            e.Graphics.DrawLine(Pens.Teal, x, y, e.MarginBounds.Right, y);
            y += 20;

            // Avsändare (kan vara statiskt)
            e.Graphics.DrawString("Hattmakarens AB", fetFont, pensel, x, y);
            y += 20;
            e.Graphics.DrawString("Hattgatan 7\n123 45 Hattstad\nTelefon: +46-123456789", normalFont, pensel, x, y);
            y += 60;

            // Mottagare (kund)
            var kund = db.HämtaKundTillOrder(_order.OrderId);
            if (kund != null)
            {
                e.Graphics.DrawString("Mottagare", fetFont, pensel, x, y);
                y += 20;
                e.Graphics.DrawString($"{kund.Fornamn} {kund.Efternamn}", normalFont, pensel, x, y); y += 20;
                e.Graphics.DrawString(kund.Adress, normalFont, pensel, x, y); y += 40;
            }

            // Här är meddelandetexten som du kan hårdkoda
            string meddelande = "Tack för din beställning! Vi hoppas du är nöjd med våra produkter. \n\nOm du har några frågor, vänligen kontakta oss.";
            float meddelandeWidth = e.Graphics.MeasureString(meddelande, normalFont).Width;
            float meddelandeHeight = e.Graphics.MeasureString(meddelande, normalFont).Height * 2;  // Justera för fler rader

            // Ritar en rektangel runt meddelandetexten
            e.Graphics.FillRectangle(Brushes.LightGray, x, y, meddelandeWidth + 20, meddelandeHeight + 10); // Fyller bakgrund
            e.Graphics.DrawRectangle(Pens.Black, x, y, meddelandeWidth + 20, meddelandeHeight + 10); // Ramar in texten
            e.Graphics.DrawString(meddelande, normalFont, pensel, x + 10, y + 5); // Ritar texten inuti rektangeln

            y += (int)meddelandeHeight + 20; // Justera y-positionen så texten inte överlappar efterföljande element

            // Tabellrubriker
            e.Graphics.DrawString("Beskrivning", fetFont, pensel, x, y);
            e.Graphics.DrawString("Datum", fetFont, pensel, x + 250, y);
            e.Graphics.DrawString("Antal", fetFont, pensel, x + 400, y);
            e.Graphics.DrawString("Enhet", fetFont, pensel, x + 470, y);
            y += 25;

            // Hämta orderrader
            var orderrader = db.HämtaOrderraderFörFöljesedel(_order.OrderId);
            foreach (var rad in orderrader)
            {
                string beskrivning = rad is LagerOrderrad lager ? lager.Modell?.Namn : "Specialbeställning";
                e.Graphics.DrawString(beskrivning, normalFont, pensel, x, y);
                e.Graphics.DrawString(DateTime.Today.ToShortDateString(), normalFont, pensel, x + 250, y);
                e.Graphics.DrawString("1", normalFont, pensel, x + 400, y);
                e.Graphics.DrawString("st", normalFont, pensel, x + 470, y);
                y += 25;
            }

            // Fotnot
            y += 50;
            e.Graphics.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y);
            y += 10;
        }



        private void FoljesedelForm_Load(object sender, EventArgs e)
        {
            var kund = db.HämtaKundTillOrder(_order.OrderId);

            if (kund != null)
            {
                txtKundNamn.Text = $"{kund.Fornamn} {kund.Efternamn}";
                txtKundAdress.Text = kund.Adress;
            }
            else
            {
                txtKundNamn.Text = "Okänd Kund";
                txtKundAdress.Text = "Okänd Adress";
            }

        }

        private void btnSkrivFöljesedel_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;

            // Startar utskriftsförhandsgranskning
            previewDialog.ShowDialog();
        }
    }
}
