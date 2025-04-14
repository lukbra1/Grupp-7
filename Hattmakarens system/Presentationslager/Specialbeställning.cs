using Hattmakarens_system.Controllers;
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

namespace Hattmakarens_system
{
    public partial class Specialbeställning : Form
    {
        public Specialbeställning()
        {
            InitializeComponent();
        }

        private void Specialbeställning_Load(object sender, EventArgs e)
        {

        }

        private void btnSparaSpecialBeställning_Click(object sender, EventArgs e)
        {
            //    using (var context = new Database.AppDbContext())
            //    {

            //        var nyOrderRad = new OrderRad
            //        {
            //            Typ = HattEnum.Special,
            //            Pris = 1500,
            //            UserId = 1, // exempel
            //            HattModellId = 2,
            //            OrderId = 1 // Exempel
            //        };


            //        var nySpecial = new Models.SpecialHattDetaljer
            //        {
            //            Farg = txtFärg.Text,
            //            Tyg = txtTyg.Text,
            //            Dekoration = txtDek.Text,
            //            Storlek = txtStorlek.Text,
            //            Modell = txtModell.Text,
            //            Fjader = txtFjäder.Text,
            //            ExtraMaterial = txtExtraMat.Text,
            //            Text = txtText.Text,
            //            Kommentar = rtxtKommentar.Text,

            //        };

            //        var controller = new SpecialController();
            //        controller.SparaSpecialBeställning(nySpecial);

            //        MessageBox.Show("Specialbeställning sparad!");
            //    }
        }


    }
}

