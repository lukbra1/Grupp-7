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
    public partial class LaggTillLagerhattar : Form
    {
        public LaggTillLagerhattar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            var SpecialBeställning = new Specialbeställning();
            SpecialBeställning.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Beställning = new Beställning();
            Beställning.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
