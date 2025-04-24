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

            // Språköversättning baserat på ComboBox
            string språk = cbSprak.SelectedItem?.ToString() ?? "Svenska";

            string titel = "Följesedel";
            string avsandareRubrik = "Avsändare";
            string mottagareRubrik = "Mottagare";
            string artikelRubrik = "Artikel";
            string datumRubrik = "Datum";
            string antalRubrik = "Antal";
            string meddelande = "Tack för din beställning! Vi hoppas du är nöjd med våra produkter.\n\nOm du har några frågor, vänligen kontakta oss.";

            switch (språk)
            {
                case "Engelska":
                    titel = "Packing Slip";
                    avsandareRubrik = "Sender";
                    mottagareRubrik = "Receiver";
                    artikelRubrik = "Item";
                    datumRubrik = "Date";
                    antalRubrik = "Quantity";
                    meddelande = "Thank you for your order! We hope you're satisfied with our products.\n\nIf you have any questions, please contact us.";
                    break;
                case "Spanska":
                    titel = "Albarán";
                    avsandareRubrik = "Remitente";
                    mottagareRubrik = "Destinatario";
                    artikelRubrik = "Artículo";
                    datumRubrik = "Fecha";
                    antalRubrik = "Cantidad";
                    meddelande = "¡Gracias por tu pedido! Esperamos que estés satisfecho con nuestros productos.\n\nSi tienes alguna pregunta, contáctanos.";
                    break;
                case "Franska":
                    titel = "Bon de livraison";
                    avsandareRubrik = "Expéditeur";
                    mottagareRubrik = "Destinataire";
                    artikelRubrik = "Article";
                    datumRubrik = "Date";
                    antalRubrik = "Quantité";
                    meddelande = "Merci pour votre commande ! Nous espérons que vous êtes satisfait de nos produits.\n\nSi vous avez des questions, veuillez nous contacter.";
                    break;
                case "Kinesiska":
                    titel = "发货单";
                    avsandareRubrik = "发件人";
                    mottagareRubrik = "收件人";
                    artikelRubrik = "项目";
                    datumRubrik = "日期";
                    antalRubrik = "数量";
                    meddelande = "感谢您的订购！我们希望您对我们的产品感到满意。\n\n如有任何问题，请联系我们。";
                    break;
                case "Hindi":
                    titel = "डिलीवरी पर्ची";
                    avsandareRubrik = "प्रेषक";
                    mottagareRubrik = "प्राप्तकर्ता";
                    artikelRubrik = "आइटम";
                    datumRubrik = "तारीख";
                    antalRubrik = "मात्रा";
                    meddelande = "आपके ऑर्डर के लिए धन्यवाद! हमें उम्मीद है कि आप हमारे उत्पादों से संतुष्ट हैं।\n\nयदि आपके कोई प्रश्न हैं, तो कृपया हमसे संपर्क करें।";
                    break;
            }

            // Titel
            e.Graphics.DrawString(titel, rubrikFont, Brushes.Teal, x, y);
            y += 40;

            // Linje
            e.Graphics.DrawLine(Pens.Teal, x, y, e.MarginBounds.Right, y);
            y += 20;

            // Avsändare
            e.Graphics.DrawString(avsandareRubrik, fetFont, pensel, x, y); y += 20;
            e.Graphics.DrawString("Hattmakarens AB", fetFont, pensel, x, y); y += 20;
            e.Graphics.DrawString("Fakultetsgatan 1\n701 82 Örebro\nTelefon: +46-123456789", normalFont, pensel, x, y); y += 60;

            // Mottagare (kund)
            var kund = db.HämtaKundTillOrder(_order.OrderId);
            if (kund != null)
            {
                e.Graphics.DrawString(mottagareRubrik, fetFont, pensel, x, y);
                y += 20;
                e.Graphics.DrawString($"{kund.Fornamn} {kund.Efternamn}", normalFont, pensel, x, y); y += 20;
                e.Graphics.DrawString(kund.Adress, normalFont, pensel, x, y); y += 40;
            }

            // Meddelande
            float meddelandeWidth = e.Graphics.MeasureString(meddelande, normalFont).Width;
            float meddelandeHeight = e.Graphics.MeasureString(meddelande, normalFont).Height * 2;
            e.Graphics.FillRectangle(Brushes.LightGray, x, y, meddelandeWidth + 20, meddelandeHeight + 10);
            e.Graphics.DrawRectangle(Pens.Black, x, y, meddelandeWidth + 20, meddelandeHeight + 10);
            e.Graphics.DrawString(meddelande, normalFont, pensel, x + 10, y + 5);
            y += (int)meddelandeHeight + 20;

            // Tabellrubriker
            e.Graphics.DrawString(artikelRubrik, fetFont, pensel, x, y);
            e.Graphics.DrawString(datumRubrik, fetFont, pensel, x + 250, y);
            e.Graphics.DrawString(antalRubrik, fetFont, pensel, x + 400, y);
            y += 25;

            // Orderrader
            var orderrader = db.HämtaOrderraderFörFöljesedel(_order.OrderId);
            foreach (var rad in orderrader)
            {
                string artikel = rad is LagerOrderrad lager ? lager.Modell?.Namn : "Specialbeställning";
                e.Graphics.DrawString(artikel, normalFont, pensel, x, y);
                e.Graphics.DrawString(DateTime.Today.ToShortDateString(), normalFont, pensel, x + 250, y);
                e.Graphics.DrawString("1", normalFont, pensel, x + 400, y);
                y += 25;
            }

            // Fotnot
            y += 50;
            e.Graphics.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y);
        }






        private void FoljesedelForm_Load(object sender, EventArgs e)
        {

            cbSprak.Items.AddRange(new string[] { "Svenska", "Engelska", "Spanska", "Franska", "Kinesiska", "Hindi" });
            cbSprak.SelectedIndex = 0;

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

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var tillbaka = new AllaBeställningar();
            tillbaka.Show();
        }
    }
}
