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
                    displayText = $"Lagerhatt - Modell: {lager.Modell?.Namn}, Storlek: {lager.Storlek}";
                }
                else if (orderRad is SpecialOrderrad special)
                {
                    displayText = $"Specialhatt - Kommentar: {special.Kommentar}, Storlek: {special.Storlek}";
                }

                listBox1.Items.Add(displayText);
            }

            label2.Text = $"Totalt pris: {ordern.TotalPris} kr";
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

            // Sätt Express till true eller false beroende på checkbox
            ordern.Express = checkBox1.Checked;

            // Spara ändringen till databasen
            orderController.UppdateraOrder(ordern);

            // Uppdatera totalpriset i GUI:t
            var beräknatTotalpris = ordern.TotalPris;

            if (ordern.Express)
                beräknatTotalpris *= 1.2m;

            label2.Text = $"Totalpris: {beräknatTotalpris.ToString()} kr";

            // Visa bekräftelse
            string status = ordern.Express ? "aktiverad" : "avaktiverad";
            MessageBox.Show($"Expressleverans är nu {status}.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beställningen är registrerad! 😊");
            Program.homepage.Show();
            this.Close();
        }
    }
}
