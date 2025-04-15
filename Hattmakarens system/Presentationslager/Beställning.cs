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

namespace Hattmakarens_system.Presentationslager
{
    public partial class Beställning : Form
    {
        static OrderController orderController = new OrderController(new AppDbContext());
        public Order ordern;

        public Beställning(Order Order)
        {
            InitializeComponent();
            ordern = Order;
            List<OrderRad> OrderRader = orderController.HämtaAllaOrderRader(Order);


            // Hämta orderrader för ordern
            var orderRaderna = orderController.HämtaAllaOrderRader(ordern);

            // Töm listan och fyll med orderrader
            listBox1.Items.Clear();

            foreach (var orderRad in orderRaderna)
            {
                string displayText = "";

                if (orderRad is LagerOrderrad lager)
                {
                    displayText = $"Lagerhatt - Modell: {lager.Modell?.Namn}, Storlek: {lager.Storlek}, Pris: {lager.Modell?.Pris} kr";
                }
                else if (orderRad is SpecialOrderrad special)
                {
                    displayText = $"Specialhatt - Kommentar: {special.Kommentar}, Storlek: {special.Storlek}, Pris: beräknas separat";
                }
                else
                {
                    displayText = $"Okänd typ - Orderrad ID: {orderRad.OrderRadId}";
                }

                listBox1.Items.Add(displayText);
            }

            label2.Text = $"Totalt pris: {ordern.TotalPris} kr";



            // Om lagerhatt
            // Bild
            // Modellnamn
            // Storlek
            // Pris

            // Om specialhatt
            // Referensbild
            // Kommentar
            // Storlek
            // Pris
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nyHatt = new LaggTillLagerhattar(ordern);
            nyHatt.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ordern == null)
                return;

            // Sätt express till true eller false beroende på checkbox
            ordern.Express = checkBox1.Checked;

            // Uppdatera ordern i databasen
            orderController.UppdateraOrder(ordern); 

            MessageBox.Show($"Expressleverans är nu {(ordern.Express ? "aktiverad" : "avaktiverad")}.");
        
        }
    }
}
