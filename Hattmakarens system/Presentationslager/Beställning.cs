using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hattmakarens_system.Presentationslager
{
    public partial class Beställning : Form
    {
        public Beställning()
        {
            InitializeComponent();
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
