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

namespace Hattmakarens_system.Presentationslager
{
    public partial class Beställning : Form
    {
        static OrderController orderController = new OrderController(new AppDbContext());

        public Beställning(Order Order)
        {
            InitializeComponent();

            List<OrderRad> OrderRader = orderController.HämtaAllaOrderRader(Order);

            listBox1.Items.Clear();

            // Om lagerhatt
            //Modellnamn
            //Pris

            // Om specialhatt


            foreach (var orderRad in OrderRader)
            {
                //listBox1.Items.Add(orderRad.);
                if(orderRad is LagerOrderrad)
                {

                }
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                foreach (var item in listBox1.SelectedItems)
                {

                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////var nyHatt = new LaggTillLagerhattar(Order Order);
           //// nyHatt.Show();
           /// this.Close();
        }
    }
}
