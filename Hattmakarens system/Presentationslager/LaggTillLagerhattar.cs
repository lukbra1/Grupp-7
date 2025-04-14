using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hattmakarens_system.ModelsNy;

namespace Hattmakarens_system.Presentationslager
{
    public partial class LaggTillLagerhattar : Form
    {
        Order Ordern;
        public LaggTillLagerhattar(Order Order)
        {
            this.Ordern = Order;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Studentmössa



            //using var db = new Database.AppDbContext();
            //var studentHatt = db.Hattmodeller.FirstOrDefault(h => h.HattModellId == 3);
            //if (studentHatt != null)
            //{
            //    AnpassaLagerhattar anpassaLagerhattar = new AnpassaLagerhattar(studentHatt);
            //    anpassaLagerhattar.Show();
            //    this.Close();
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Skapa specialbeställningshatt
            var SpecialBeställning = new Specialbeställning();
            SpecialBeställning.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Visa varukorg utan att lägga till hatt
            var Beställning = new Beställning(this.Ordern);
            Beställning.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Oktoberhatt
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Doktorsmössa
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Fez-hatt
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Sherlockhatt
        }

        private void LaggTillLagerhattar_Load(object sender, EventArgs e)
        {

        }
    }
}
