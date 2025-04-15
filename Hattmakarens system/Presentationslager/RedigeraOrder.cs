using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hattmakarens_system
{
    public partial class RedigeraOrder : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        private Order valdOrder;
        private readonly int _orderId;

        public RedigeraOrder(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;

            Load += RedigeraOrder_Load;
            btnSpara.Click += btnSpara_Click;
        }

        private void RedigeraOrder_Load(object sender, EventArgs e)
        {
            valdOrder = _context.Ordrar
                .Include(o => o.OrderRader)
                .FirstOrDefault(o => o.OrderId == _orderId);

            if (valdOrder == null)
            {
                MessageBox.Show("Kunde inte hitta order.");
                Close();
                return;
            }

            // Skapa datatabell
            DataTable dt = new DataTable();
            dt.Columns.Add("OrderRadId", typeof(int));
            dt.Columns.Add("Typ", typeof(string));
            dt.Columns.Add("Storlek", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Express", typeof(bool)); // visa express på varje rad

            foreach (var rad in valdOrder.OrderRader)
            {
                dt.Rows.Add(
                    rad.OrderRadId,
                    rad.TypEnum.ToString(),
                    rad.Storlek.ToString(),
                    rad.StatusOrderrad.ToString(),
                    valdOrder.Express
                );
            }

            dgvOrderRader.DataSource = dt;

            LäggTillComboKolumn("Typ", typeof(TypEnum));
            LäggTillComboKolumn("Storlek", typeof(StorlekEnum));
            LäggTillComboKolumn("Status", typeof(StatusOrderradEnum));

            // Express-kolumn som checkbox
            if (!(dgvOrderRader.Columns["Express"] is DataGridViewCheckBoxColumn))
            {
                int index = dgvOrderRader.Columns["Express"].Index;

                var expressCol = new DataGridViewCheckBoxColumn
                {
                    DataPropertyName = "Express",
                    Name = "Express",
                    HeaderText = "Express"
                };

                dgvOrderRader.Columns.RemoveAt(index);
                dgvOrderRader.Columns.Insert(index, expressCol);
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

            // Spara Express från första raden
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
