using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using Hattmakarens_system.Presentationslager;
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

        public RedigeraOrder(Order valdOrder)
        {
            InitializeComponent();
            this.valdOrder = valdOrder;

            Load += RedigeraOrder_Load;
            btnSpara.Click += btnSpara_Click;
        }

        private void RedigeraOrder_Load(object sender, EventArgs e)
        {
            dgvOrderRader.DataSource = null;
            dgvOrderRader.Rows.Clear();
            dgvOrderRader.Columns.Clear();


            valdOrder = _context.Ordrar
                .Include(o => o.OrderRader)
                .FirstOrDefault(o => o.OrderId == valdOrder.OrderId);

            if (valdOrder == null)
            {
                MessageBox.Show("Kunde inte hitta order.");
                Close();
                return;
            }


            DataTable dt = new DataTable();
            dt.Columns.Add("OrderRadId", typeof(int));
            dt.Columns.Add("Typ", typeof(string));
            dt.Columns.Add("Storlek", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Express", typeof(bool));
            dt.Columns.Add("Pris", typeof(decimal));


            foreach (var rad in valdOrder.OrderRader)
            {
                dt.Rows.Add(
                    rad.OrderRadId,
                    rad.TypEnum.ToString(),
                    rad.Storlek.ToString(),
                    rad.StatusOrderrad.ToString(),
                    valdOrder.Express,
                    valdOrder.TotalPris
                );
            }

            dgvOrderRader.DataSource = dt;

            LäggTillComboKolumn("Typ", typeof(TypEnum));
            LäggTillComboKolumn("Storlek", typeof(StorlekEnum));
            LäggTillComboKolumn("Status", typeof(StatusOrderradEnum));


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


            dgvOrderRader.Columns["Pris"].ReadOnly = false;
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

            //foreach (DataGridViewRow row in dgvOrderRader.Rows)
            //{
            //    if (row.IsNewRow) continue;

            //    int radId = Convert.ToInt32(row.Cells["OrderRadId"].Value);
            //    var rad = valdOrder.OrderRader.FirstOrDefault(r => r.OrderRadId == radId);

            //    if (rad != null)
            //    {
            //        if (Enum.TryParse(row.Cells["Typ"].Value.ToString(), out TypEnum typ))
            //            rad.TypEnum = typ;

            //        if (Enum.TryParse(row.Cells["Storlek"].Value.ToString(), out StorlekEnum storlek))
            //            rad.Storlek = storlek;

            //        if (Enum.TryParse(row.Cells["Status"].Value.ToString(), out StatusOrderradEnum status))
            //            rad.StatusOrderrad = status;
            //    }
            //}

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

                    if (decimal.TryParse(row.Cells["Pris"].Value?.ToString(), out decimal nyttRadPris))
                        rad.pris = nyttRadPris;
                }
            }



            if (dgvOrderRader.Rows.Count > 0 &&
                dgvOrderRader.Rows[0].Cells["Express"].Value is bool express)
            {
                valdOrder.Express = express;
            }


            if (dgvOrderRader.Rows.Count > 0 &&
                decimal.TryParse(dgvOrderRader.Rows[0].Cells["Pris"].Value?.ToString(), out decimal nyttPris))
            {
                valdOrder.TotalPris = nyttPris;
            }

            int ändringar = _context.SaveChanges();
            MessageBox.Show($"Sparade {ändringar} ändringar till databasen.");
        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var previousForm = new AllaBeställningar();
            previousForm.Show();
        }
    }
}
