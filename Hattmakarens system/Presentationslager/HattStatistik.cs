using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
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
    public partial class HattStatistik : Form
    {
        static StatistikController StatistikController = new StatistikController(new AppDbContext());

        public HattStatistik()
        {
            InitializeComponent();


        }

        private void HattStatestik_Load(object sender, EventArgs e)
        {
            List<Modell> Modeller = StatistikController.HämtaAllaModeller();

            comboBox1.DataSource = Modeller;
            comboBox1.DisplayMember = "Namn";
            comboBox1.ValueMember = "ModellId";

        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.homepage.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            var modellVal = (int)comboBox1.SelectedValue;
            var startDatumVal = dateTimePicker1.Value;
            var slutDatumVal = dateTimePicker2.Value;

            StatistikController.HämtaStatistikFörHattmodell(modellVal, startDatumVal, slutDatumVal);
        }
    }
}
