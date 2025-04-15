using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hattmakarens_system
{
    public partial class RedigeraOrder : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        private Order valdOrder;
        private int _orderId;


        public RedigeraOrder(int orderId)
        {
            InitializeComponent();
            Load += RedigeraOrder_Load;
            btnVisaOrder.Click += btnVisaOrder_Click;
            btnSpara.Click += btnSpara_Click;
            _orderId = orderId;

        }

        private void RedigeraOrder_Load(object sender, EventArgs e)
        {
            var ordrar = _context.Ordrar.ToList();

            cmbOrderId.DisplayMember = "OrderId";
            cmbOrderId.ValueMember = "OrderId";
            cmbOrderId.DataSource = ordrar;
        }

        private void btnVisaOrder_Click(object sender, EventArgs e)
        {
            if (cmbOrderId.SelectedValue is int orderId)
            {
                valdOrder = _context.Ordrar
                    .Include(o => o.OrderRader)
                    .FirstOrDefault(o => o.OrderId == orderId);

                if (valdOrder == null)
                {
                    MessageBox.Show("Kunde inte hitta order.");
                    return;
                }

                // Skapa DataTable för redigering
                DataTable dt = new DataTable();
                dt.Columns.Add("OrderRadId", typeof(int));
                dt.Columns.Add("Typ", typeof(string));
                dt.Columns.Add("Storlek", typeof(string));
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Express", typeof(bool)); // 🆕 ny kolumn

                foreach (var rad in valdOrder.OrderRader)
                {
                    dt.Rows.Add(
                        rad.OrderRadId,
                        rad.TypEnum.ToString(),
                        rad.Storlek.ToString(),
                        rad.StatusOrderrad.ToString(),
                        valdOrder.Express // 🆕 samma expressvärde på varje rad
                    );
                }

                dgvOrderRader.DataSource = dt;

                LäggTillComboKolumn("Typ", typeof(TypEnum));
                LäggTillComboKolumn("Storlek", typeof(StorlekEnum));
                LäggTillComboKolumn("Status", typeof(StatusOrderradEnum));

                // Se till att Express-kolumn är redigerbar checkbox
                if (dgvOrderRader.Columns["Express"] is DataGridViewCheckBoxColumn expressCol == false)
                {
                    int index = dgvOrderRader.Columns["Express"].Index;

                    var expressCheckbox = new DataGridViewCheckBoxColumn
                    {
                        DataPropertyName = "Express",
                        Name = "Express",
                        HeaderText = "Express"
                    };

                    dgvOrderRader.Columns.RemoveAt(index);
                    dgvOrderRader.Columns.Insert(index, expressCheckbox);
                }
            }
        }

        private void LäggTillComboKolumn(string kolumnNamn, Type enumTyp)
        {
            if (dgvOrderRader.Columns[kolumnNamn] is DataGridViewComboBoxColumn) return;

            int index = dgvOrderRader.Columns[kolumnNamn].Index;

            var comboCol = new DataGridViewComboBoxColumn
            {
                DataPropertyName = kolumnNamn,
                Name = kolumnNamn,
                DataSource = Enum.GetNames(enumTyp)
            };

            dgvOrderRader.Columns.RemoveAt(index);
            dgvOrderRader.Columns.Insert(index, comboCol);
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            if (valdOrder == null) return;

            foreach (DataGridViewRow row in dgvOrderRader.Rows)
            {
                if (row.IsNewRow) continue;

                int radId = Convert.ToInt32(row.Cells["OrderRadId"].Value);
                var rad = valdOrder.OrderRader.FirstOrDefault(r => r.OrderRadId == radId);

                if (rad != null)
                {
                    if (Enum.TryParse(row.Cells["Typ"].Value.ToString(), out TypEnum typ))
                        rad.TypEnum = typ;

                    if (Enum.TryParse(row.Cells["Storlek"].Value.ToString(), out StorlekEnum storlek))
                        rad.Storlek = storlek;

                    if (Enum.TryParse(row.Cells["Status"].Value.ToString(), out StatusOrderradEnum status))
                        rad.StatusOrderrad = status;
                }
            }

            // 🆕 Hämta Express från första raden
            if (dgvOrderRader.Rows.Count > 0 &&
                dgvOrderRader.Rows[0].Cells["Express"].Value is bool express)
            {
                valdOrder.Express = express;
            }

            int ändringar = _context.SaveChanges();
            MessageBox.Show($"Sparade {ändringar} ändringar till databasen.");
        }
    }
}
