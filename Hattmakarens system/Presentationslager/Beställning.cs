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


            listBox1.Items.Clear();
           /// var orderRaderna = orderController.HämtaAllaOrderRader(ordern);

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

            foreach (var orderRad in OrderRader)
            {
                //listBox1.Items.Add(orderRad.);
                if (orderRad is LagerOrderrad)
                {

                }
                else if (orderRad is SpecialOrderrad)
                {

                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //var orderRaderna = orderController.HämtaAllaOrderRader(ordern);

            //if (ordern != null)
            //{
            //    // Anta att du har valt en Order i listboxen
            //    var valdOrder = (Order)listBox1.SelectedItem;

            //    if (valdOrder != null)
            //    {
            //        // Hämta alla orderrader via controller med OrderId
            //        var orderrader = _context.HämtaAllaOrderRader(valdOrder.OrderId);

            //        // Visa dem t.ex. i en ListBox eller DataGridView
            //        listBoxOrderRader.DataSource = orderrader;
            //        listBoxOrderRader.DisplayMember = "HattId"; // eller annan egenskap du vill visa
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Ingen aktiv order hittades.");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var nyHatt = new LaggTillLagerhattar(ordern);
           nyHatt.Show();
           this.Close();
        }
    }
}
