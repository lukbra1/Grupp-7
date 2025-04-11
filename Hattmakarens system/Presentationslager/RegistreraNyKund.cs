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

namespace Hattmakarens_system.Presentationslager
{
    public partial class RegistreraNyKund : Form
    {
        private readonly KundController _controller;

        public RegistreraNyKund(/* KundController controller*/)
        {
            //_controller = controller;
            InitializeComponent();
        }

        private void KnappOk_Click(object sender, EventArgs e)
        {
            // Lägg till validation
            _controller.SkapaNyKund(TextBoxFornamn.Text, TextBoxEfternamn.Text, TextBoxTelefonNr.Text, TextBoxAdress.Text);
            Close();
        }

        private void KnappAvbryt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
