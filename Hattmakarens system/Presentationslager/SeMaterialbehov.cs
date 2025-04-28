using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;

namespace Hattmakarens_system
{
    public partial class SeMaterialbehov : Form
    {
        private readonly MaterialController _materialController;
        private readonly OrderController _orderController;

        public SeMaterialbehov()
        {
            InitializeComponent();

            var context = new AppDbContext();
            _materialController = new MaterialController(context);
            _orderController = new OrderController(context);

            Load += SeMaterialbehov_Load;
            btnFiltreraDatum.Click += BtnFiltreraDatum_Click;
            btnExporteraMaterial.Click += BtnExporteraMaterial_Click;
        }

        private void SeMaterialbehov_Load(object sender, EventArgs e)
        {
           LaddaAllaOrdrar();
        }

        private void LaddaAllaOrdrar()
        {
            var ordrar = _orderController.HämtaOrdrarMedObeställtMaterial();
            lvOrdrar.Items.Clear();

            foreach (var order in ordrar)
            {
                var item = new ListViewItem(order.OrderId.ToString());
                item.SubItems.Add($"{order.Kund?.Fornamn} {order.Kund?.Efternamn}");
                item.SubItems.Add(order.Skapad.ToShortDateString());
                item.SubItems.Add(order.Express ? "Ja" : "Nej");
                item.Tag = order.OrderId;
                lvOrdrar.Items.Add(item);
            }

            var allaOrderIds = ordrar.Select(o => o.OrderId).ToList();
            var materialrader = _materialController.HämtaObeställdaMaterialFörOrderIds(allaOrderIds);

            VisaMaterialIGrid(materialrader);
        }

        private void BtnFiltreraDatum_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartDatum.Value.Date;
            DateTime slut = dtpSlutDatum.Value.Date;

            var ordrar = _orderController.HämtaOrdrarMedObeställtMaterialInomDatum(start, slut);
            lvOrdrar.Items.Clear();

            foreach (var order in ordrar)
            {
                var item = new ListViewItem(order.OrderId.ToString());
                item.SubItems.Add(order.Kund != null
                    ? $"{order.Kund.Fornamn} {order.Kund.Efternamn}"
                    : "Okänd kund");
                item.SubItems.Add(order.Skapad.ToShortDateString());
                item.SubItems.Add(order.Express ? "Ja" : "Nej");
                item.Tag = order.OrderId;
                lvOrdrar.Items.Add(item);
            }

            var allaOrderIds = ordrar.Select(o => o.OrderId).ToList();
            var materialrader = _materialController.HämtaObeställdaMaterialFörOrderIds(allaOrderIds);

            VisaMaterialIGrid(materialrader);

            if (!ordrar.Any())
            {
                MessageBox.Show("Inga ordrar med obeställda material hittades i valt intervall.");
            }
        }

        private void BtnExporteraMaterial_Click(object sender, EventArgs e)
        {
            var allaOrderIds = lvOrdrar.Items
                .Cast<ListViewItem>()
                .Select(item => (int)item.Tag)
                .ToList();

            var materialrader = _materialController.HämtaObeställdaMaterialFörOrderIds(allaOrderIds);

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
                _materialController.ExporterarMaterialTillFilOchMarkeraSomBeställt(materialrader, saveFileDialog.FileName);
                System.Diagnostics.Process.Start("notepad.exe", saveFileDialog.FileName);
                MessageBox.Show("Materialbehov har exporterats");

                LaddaAllaOrdrar();
                dataGridViewMaterial.DataSource = null;
            }
        }

        private void VisaMaterialIGrid(List<MaterialOrderrad> materialrader)
        {
            dataGridViewMaterial.DataSource = null;
            dataGridViewMaterial.Columns.Clear();
            dataGridViewMaterial.AutoGenerateColumns = true;

            var dataSource = materialrader.Select(m => new
            {
                Material = m.Material.Namn,
                Färg = m.Material.Farg,
                Beskrivning = m.Material.Beskrivning
            }).ToList();

            dataGridViewMaterial.DataSource = dataSource;
        }

       
        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.homepage.Show();
        }
    }
}
