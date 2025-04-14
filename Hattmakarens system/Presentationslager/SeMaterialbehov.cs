using System;
using System.Linq;
using System.Windows.Forms;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using Microsoft.EntityFrameworkCore;

namespace Hattmakarens_system
{
    public partial class SeMaterialbehov : Form
    {
        public SeMaterialbehov()
        {
            InitializeComponent();
            Load += SeMaterialbehov_Load;
            btnVisaMaterial.Click += BtnVisaMaterial_Click;
        }

        private void SeMaterialbehov_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var modeller = context.Modeller
                    .Where(m => m.Tillganglig)
                    .ToList();

                cmbHattar.DisplayMember = "Namn";
                cmbHattar.ValueMember = "ModellId";
                cmbHattar.DataSource = modeller;
            }
        }

        private void BtnVisaMaterial_Click(object sender, EventArgs e)
        {
            if (cmbHattar.SelectedItem is Modell valdModell)
            {
                using (var context = new AppDbContext())
                {
                    var materialInfo = context.MaterialModeller
                        .Include(mm => mm.Material)
                        .Where(mm => mm.ModellId == valdModell.ModellId)
                        .Select(mm => new
                        {
                            MaterialNamn = mm.Material.Namn,
                            Färg = mm.Material.Farg,
                            Enhet = mm.Material.Enhet,
                            PrisPerEnhet = mm.Material.PrisPerEnhet,
                            Beskrivning = mm.Material.Beskrivning
                        })
                        .ToList();

                    dataGridViewMaterial.DataSource = materialInfo;
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj en hattmodell.");
            }
        }
    }
}
