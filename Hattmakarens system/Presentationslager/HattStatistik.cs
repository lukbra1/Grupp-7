using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;

namespace Hattmakarens_system.Presentationslager
{
    public partial class HattStatistik : Form
    {
        static StatistikController StatistikController = new StatistikController(new AppDbContext());
        private bool klickatVidareKnapp = false;

        public HattStatistik()
        {
            InitializeComponent();
        }
        private void HattStatestik_Load(object sender, EventArgs e)
        {
            List<Modell> Modeller = StatistikController.HämtaAllaModeller();

            Modeller.Insert(0, new Modell { ModellId = -1, Namn = "Specialhatt" });

            comboBox1.DataSource = Modeller;
            comboBox1.DisplayMember = "Namn";
            comboBox1.ValueMember = "ModellId";
        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klickatVidareKnapp = true;
            Program.homepage.Show();
            this.Close();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            var modellVal = (int)comboBox1.SelectedValue;
            var startDatumVal = dateTimePicker1.Value;
            var slutDatumVal = dateTimePicker2.Value;

            if (modellVal == -1)
            {
                decimal summan = StatistikController.HämtaSummaSpecialhatt(startDatumVal, slutDatumVal);
                int antalet = StatistikController.HämtaAntalSpecialhatt(startDatumVal, slutDatumVal);

                listBox1.Items.Clear();
                listBox1.Items.Add($"Totalt antal sålda hattar: {antalet}");
                listBox1.Items.Add($"Total försäljningssumma: {summan}kr");
            }
            else
            {
                decimal summan = StatistikController.HämtaSumma(modellVal, startDatumVal, slutDatumVal);
                int antalet = StatistikController.HämtaAntal(modellVal, startDatumVal, slutDatumVal);

                listBox1.Items.Clear();
                listBox1.Items.Add($"Totalt antal sålda hattar: {antalet}");
                listBox1.Items.Add($"Total försäljningssumma: {summan}kr");
            }

        }

        private void HattStatistik_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!klickatVidareKnapp)
            {
                Program.homepage.Close();
            }
        }
    }
}
