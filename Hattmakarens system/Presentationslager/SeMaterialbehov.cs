using System;
using System.Collections.Generic;
using System.IO;
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
            btnFiltreraDatum.Click += BtnFiltreraDatum_Click;
            btnExporteraMaterial.Click += BtnExporteraMaterial_Click;
        }

        private void SeMaterialbehov_Load(object sender, EventArgs e)
        {
            lvOrdrar.View = View.Details;
            lvOrdrar.FullRowSelect = true;
            lvOrdrar.MultiSelect = true;
            lvOrdrar.Columns.Add("OrderId", 70);
            lvOrdrar.Columns.Add("Kund", 150);
            lvOrdrar.Columns.Add("Datum", 120);
            lvOrdrar.Columns.Add("Express", 70);

            LaddaAllaOrdrar();
        }

        private void LaddaAllaOrdrar()
        {
            using (var context = new AppDbContext())
            {
                var materialOrderrader = context.MaterialOrderrader
                    .Include(m => m.Material)
                    .Include(m => m.OrderRad)
                        .ThenInclude(or => or.Order)
                    .ThenInclude(o => o.Kund)
                    .Where(m => !m.Bestallt)
                    .ToList();

                var unikaOrdrar = materialOrderrader
                    .Select(m => m.OrderRad.Order)
                    .Distinct()
                    .ToList();

                lvOrdrar.Items.Clear();

                foreach (var order in unikaOrdrar)
                {
                    var item = new ListViewItem(order.OrderId.ToString());
                    item.SubItems.Add($"{order.Kund.Fornamn} {order.Kund.Efternamn}");
                    item.SubItems.Add(order.Skapad.ToShortDateString());
                    item.SubItems.Add(order.Express ? "Ja" : "Nej");
                    item.Tag = order.OrderId;
                    lvOrdrar.Items.Add(item);
                }

                // Visa alla materialrader i datagrid
                var materialrader = materialOrderrader
                    .Select(m => new MaterialRadView
                    {
                        MaterialId = m.MaterialId,
                        OrderRadId = m.OrderRadId,
                        MaterialNamn = m.Material.Namn,
                        Färg = m.Material.Farg,
                        Enhet = m.Material.Enhet,
                        PrisPerEnhet = m.Material.PrisPerEnhet,
                        Beskrivning = m.Material.Beskrivning
                    })
                    .ToList();

                VisaMaterialIGrid(materialrader);
            }
        }

        private void BtnFiltreraDatum_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartDatum.Value.Date;
            DateTime slut = dtpSlutDatum.Value.Date;

            using (var context = new AppDbContext())
            {
                var materialOrderrader = context.MaterialOrderrader
                    .Include(m => m.Material)
                    .Include(m => m.OrderRad)
                        .ThenInclude(or => or.Order)
                    .ThenInclude(o => o.Kund)
                    .Where(m => !m.Bestallt && m.OrderRad.Order.Skapad >= start && m.OrderRad.Order.Skapad <= slut)
                    .ToList();

                var unikaOrdrar = materialOrderrader
                    .Select(m => m.OrderRad.Order)
                    .Distinct()
                    .ToList();

                lvOrdrar.Items.Clear();

                foreach (var order in unikaOrdrar)
                {
                    var item = new ListViewItem(order.OrderId.ToString());
                    item.SubItems.Add($"{order.Kund.Fornamn} {order.Kund.Efternamn}");
                    item.SubItems.Add(order.Skapad.ToShortDateString());
                    item.SubItems.Add(order.Express ? "Ja" : "Nej");
                    item.Tag = order.OrderId;
                    lvOrdrar.Items.Add(item);
                }

                var materialrader = materialOrderrader
                    .Select(m => new MaterialRadView
                    {
                        MaterialId = m.MaterialId,
                        OrderRadId = m.OrderRadId,
                        MaterialNamn = m.Material.Namn,
                        Färg = m.Material.Farg,
                        Enhet = m.Material.Enhet,
                        PrisPerEnhet = m.Material.PrisPerEnhet,
                        Beskrivning = m.Material.Beskrivning
                    })
                    .ToList();

                VisaMaterialIGrid(materialrader);

                if (!unikaOrdrar.Any())
                {
                    MessageBox.Show("Inga ordrar med obeställda material hittades i valt intervall.");
                }
            }
        }

        private void BtnExporteraMaterial_Click(object sender, EventArgs e)
        {
            var allaOrderIds = lvOrdrar.Items
                .Cast<ListViewItem>()
                .Select(item => (int)item.Tag)
                .ToList();

            using (var context = new AppDbContext())
            {
                var materialrader = context.MaterialOrderrader
                    .Include(m => m.Material)
                    .Include(m => m.OrderRad)
                    .Where(m => allaOrderIds.Contains(m.OrderRad.OrderId) && m.Bestallt == false)
                    .ToList();

                if (!materialrader.Any())
                {
                    MessageBox.Show("Inget obeställt material att exportera.");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Textfiler (*.txt)|*.txt",
                    FileName = $"Materialbehov_{DateTime.Now:yyyyMMdd_HHmm}.txt"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("Material att beställa:");
                        writer.WriteLine();
                        foreach (var material in materialrader)
                        {
                            writer.WriteLine($"OrderId: {material.OrderRad.OrderId}");
                            writer.WriteLine($"Material: {material.Material.Namn}");
                            writer.WriteLine($"Färg: {material.Material.Farg}");
                            writer.WriteLine($"Enhet: {material.Material.Enhet}");
                            writer.WriteLine($"Pris per enhet: {material.Material.PrisPerEnhet} kr");
                            writer.WriteLine($"Beskrivning: {material.Material.Beskrivning}");
                            writer.WriteLine(new string('-', 40));

                            material.Bestallt = true;
                        }
                    }

                    context.MaterialOrderrader.UpdateRange(materialrader);
                    context.SaveChanges();
                    System.Diagnostics.Process.Start("notepad.exe", saveFileDialog.FileName);
                    MessageBox.Show("Materialbehov har exporterats");
                    LaddaAllaOrdrar();
                    dataGridViewMaterial.DataSource = null;
                }
            }
        }

        private void VisaMaterialIGrid(List<MaterialRadView> materialrader)
        {
            dataGridViewMaterial.DataSource = null;
            dataGridViewMaterial.Columns.Clear();
            dataGridViewMaterial.AutoGenerateColumns = false;

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

            dataGridViewMaterial.DataSource = materialrader;
        }

        public class MaterialRadView
        {
            public int MaterialId { get; set; }
            public int OrderRadId { get; set; }
            public string MaterialNamn { get; set; }
            public string Färg { get; set; }
            public string Enhet { get; set; }
            public decimal PrisPerEnhet { get; set; }
            public string Beskrivning { get; set; }
        }

        private void lvOrdrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
