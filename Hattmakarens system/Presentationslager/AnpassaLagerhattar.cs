using Hattmakarens_system.ModelsNy;
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
    public partial class AnpassaLagerhattar : Form
    {
        private LagerOrderrad _orderrad;
        public AnpassaLagerhattar(LagerOrderrad orderrad)
        {
            InitializeComponent();
            _orderrad = orderrad;
        }

        private void txtFörnamn_Click(object sender, EventArgs e)
        {

        }
    }
}
