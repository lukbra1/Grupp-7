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
    public partial class VäljKund : Form
    {
        public VäljKund()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var RegisteraKund = new RegistreraKund();
            RegisteraKund.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Laggtill = new LaggTillLagerhattar();
            Laggtill.Show();
            this.Close();
        }
    }
}
