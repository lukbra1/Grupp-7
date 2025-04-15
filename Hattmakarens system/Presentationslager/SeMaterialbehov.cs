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
            btnSparaBestallning.Click += btnSparaBestallning_Click;
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
                    var materialOrderrader = context.MaterialOrderrader
                        .Include(mo => mo.Material)
                        .Include(mo => mo.OrderRad)
                        .ToList()
                        .Where(mo => mo.OrderRad is LagerOrderrad lager && lager.ModellId == valdModell.ModellId)
                        .Select(mo => new MaterialRadView
                        {
                            MaterialId = mo.MaterialId,
                            OrderRadId = mo.OrderRadId,
                            MaterialNamn = mo.Material.Namn,
                            Färg = mo.Material.Farg,
                            Enhet = mo.Material.Enhet,
                            PrisPerEnhet = mo.Material.PrisPerEnhet,
                            Beskrivning = mo.Material.Beskrivning,
                            Bestallt = mo.Bestallt
                        })
                        .ToList();

                    dataGridViewMaterial.DataSource = null;
                    dataGridViewMaterial.Columns.Clear();
                    dataGridViewMaterial.AutoGenerateColumns = false;
                    dataGridViewMaterial.ReadOnly = false;

                    dataGridViewMaterial.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "MaterialId",
                        HeaderText = "MaterialId",
                        ReadOnly = true
                    });
                    dataGridViewMaterial.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "OrderRadId",
                        HeaderText = "OrderRadId",
                        ReadOnly = true
                    });
                    dataGridViewMaterial.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "MaterialNamn",
                        HeaderText = "Material",
                        ReadOnly = true
                    });
                    dataGridViewMaterial.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Färg",
                        HeaderText = "Färg",
                        ReadOnly = true
                    });
                    dataGridViewMaterial.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Enhet",
                        HeaderText = "Enhet",
                        ReadOnly = true
                    });
                    dataGridViewMaterial.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "PrisPerEnhet",
                        HeaderText = "Pris per enhet",
                        ReadOnly = true
                    });
                    dataGridViewMaterial.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Beskrivning",
                        HeaderText = "Beskrivning",
                        ReadOnly = true
                    });
                    dataGridViewMaterial.Columns.Add(new DataGridViewCheckBoxColumn
                    {
                        DataPropertyName = "Bestallt",
                        HeaderText = "Beställt",
                        Name = "Bestallt" // Viktigt för redigering
                    });

                    dataGridViewMaterial.DataSource = materialOrderrader;

                    // Se till att checkbox-kolumnen är redigerbar
                    if (dataGridViewMaterial.Columns["Bestallt"] != null)
                    {
                        dataGridViewMaterial.Columns["Bestallt"].ReadOnly = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj en hattmodell.");
            }
        }

        private void btnSparaBestallning_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                foreach (DataGridViewRow row in dataGridViewMaterial.Rows)
                {
                    if (row.DataBoundItem is MaterialRadView viewRow)
                    {
                        var mor = context.MaterialOrderrader
                            .FirstOrDefault(m => m.MaterialId == viewRow.MaterialId && m.OrderRadId == viewRow.OrderRadId);

                        if (mor != null)
                        {
                            mor.Bestallt = viewRow.Bestallt;
                        }
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Beställningsstatus sparad!");
            }
        }

        // 👇 Denna klass behövs för att kunna redigera Bestallt i datagrid
        private class MaterialRadView
        {
            public int MaterialId { get; set; }
            public int OrderRadId { get; set; }
            public string MaterialNamn { get; set; }
            public string Färg { get; set; }
            public string Enhet { get; set; }
            public decimal PrisPerEnhet { get; set; }
            public string Beskrivning { get; set; }
            public bool Bestallt { get; set; }
        }
    }
}
