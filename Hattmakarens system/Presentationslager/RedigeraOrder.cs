using Hattmakarens_system.Controllers;
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
        private Homepage _homepage;
        private AllaBeställningar _previousForm;

        private readonly OrderController _orderController;


        public RedigeraOrder(Order valdOrder, AllaBeställningar previousForm, Homepage homepage)
        {
            _orderController = new OrderController(_context);
            InitializeComponent();
            this.valdOrder = valdOrder;
            this._previousForm = previousForm;
            this._homepage = homepage;

            Load += RedigeraOrder_Load;
            btnSpara.Click += btnSpara_Click;
            this.FormClosed += RedigeraOrder_FormClosed;
        }

        private void RedigeraOrder_Load(object sender, EventArgs e)
        {
            try
            {
                valdOrder = _context.Ordrar
                    .Include(o => o.OrderRader)
                    .ThenInclude(o => (o as LagerOrderrad).Modell)
                    .FirstOrDefault(o => o.OrderId == valdOrder.OrderId);

                if (valdOrder == null)
                {
                    MessageBox.Show("Kunde inte hitta order.");
                    Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LaddaOrderRad();
            LaddaMatrial();

            foreach (var rad in valdOrder.OrderRader)
            {
                if (rad is SpecialOrderrad specialRad)
                {
                    if (!string.IsNullOrEmpty(specialRad.Referensbild) && File.Exists(specialRad.Referensbild))
                    {
                        pictureBoxReferensbild.Image = Image.FromFile(specialRad.Referensbild);
                        pictureBoxReferensbild.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    }
                }
            }

        }

        public void LaddaMatrial()
        {
            dgvMatrial.DataSource = null;
            dgvMatrial.Rows.Clear();
            dgvMatrial.Columns.Clear();

            //kolumner
            DataTable dt = new DataTable();
            dt.Columns.Add("Hattnummer", typeof(int)).ReadOnly = true;
            dt.Columns.Add("Namn", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Antal", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Färg", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Beskrivning", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Beställt", typeof(bool)).ReadOnly = true;

            var orderId = valdOrder.OrderId;

            var matrialFörOrderRad = _orderController.HämtaMatrialFörOrderRader(orderId);

            foreach (var material in matrialFörOrderRad)
            {
                dt.Rows.Add(
                    material.OrderRadId,
                    material.Material.Namn,
                    material.TotalAntal,
                    material.Material.Farg,
                    material.Material.Beskrivning,
                    material.Bestallt
                );
            }

            dgvMatrial.DataSource = dt;

        }

        public void LaddaOrderRad()
        {
            dgvOrderRader.DataSource = null;
            dgvOrderRader.Rows.Clear();
            dgvOrderRader.Columns.Clear();

            DataTable dt = new DataTable();
            dt.Columns.Add("OrderRadId", typeof(int));
            dt.Columns.Add("Modell", typeof(string));
            dt.Columns.Add("Typ", typeof(string));
            dt.Columns.Add("Storlek", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Pris exkl. moms", typeof(decimal));

            dt.Columns["Modell"].ReadOnly = true;
            dt.Columns["Typ"].ReadOnly = true;


            foreach (var rad in valdOrder.OrderRader)
            {
                string modell = "Special";
                if (rad is LagerOrderrad lagerRad && lagerRad.Modell != null)
                {
                    modell = lagerRad.Modell.Namn;
                }

                dt.Rows.Add(
                        rad.OrderRadId,
                        modell,
                        rad.TypEnum.ToString(),
                        rad.Storlek.ToString(),
                        rad.StatusOrderrad.ToString(),
                        rad.pris
                );
            }

            checkBox1.Checked = valdOrder.Express;

            dgvOrderRader.DataSource = dt;

            LäggTillComboKolumn("Storlek", typeof(StorlekEnum));
            LäggTillComboKolumn("Status", typeof(StatusOrderradEnum));

            dgvOrderRader.Columns["Pris exkl. moms"].ReadOnly = false;
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

                    if (decimal.TryParse(row.Cells["Pris exkl. moms"].Value?.ToString(), out decimal nyttRadPris))
                        rad.pris = nyttRadPris;
                }
            }

            valdOrder.Express = checkBox1.Checked;


            if (dgvOrderRader.Rows.Count > 0 &&
                decimal.TryParse(dgvOrderRader.Rows[0].Cells["Pris exkl. moms"].Value?.ToString(), out decimal nyttPris))
            {
                valdOrder.TotalPris = nyttPris;
            }

            _context.Ordrar.Update(valdOrder);
            int ändringar = _context.SaveChanges();
            MessageBox.Show($"Dina ändringar är sparade.");

        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var öppna = new AllaBeställningar(_homepage);
            öppna.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RedigeraOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            _homepage?.UppdateraData();
        }

        private void dgvOrderRader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderRader.SelectedRows.Count == 0)
            {
                if (pictureBoxReferensbild.Image != null)
                {
                    pictureBoxReferensbild.Image.Dispose();
                    pictureBoxReferensbild.Image = null;
                }
                return;
            }

            var valdRad = dgvOrderRader.SelectedRows[0];
            int orderRadId = Convert.ToInt32(valdRad.Cells["OrderRadId"].Value);

            var rad = valdOrder.OrderRader.FirstOrDefault(r => r.OrderRadId == orderRadId);

            if (rad is SpecialOrderrad specialRad)
            {
                if (!string.IsNullOrEmpty(specialRad.Referensbild) && System.IO.File.Exists(specialRad.Referensbild))
                {
                    try
                    {
                        // Släpp nuvarande bild
                        if (pictureBoxReferensbild.Image != null)
                        {
                            pictureBoxReferensbild.Image.Dispose();
                            pictureBoxReferensbild.Image = null;
                        }

                        // Skapa en kopia av bilden från filen (för att inte låsa filen)
                        using (var tempImage = new Bitmap(specialRad.Referensbild))
                        {
                            pictureBoxReferensbild.Image = new Bitmap(tempImage);
                        }

                        pictureBoxReferensbild.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kunde inte ladda referensbild: {ex.Message}");
                        pictureBoxReferensbild.Image = null;
                    }
                }
                else
                {
                    if (pictureBoxReferensbild.Image != null)
                    {
                        pictureBoxReferensbild.Image.Dispose();
                        pictureBoxReferensbild.Image = null;
                    }
                }
            }
            else
            {
                if (pictureBoxReferensbild.Image != null)
                {
                    pictureBoxReferensbild.Image.Dispose();
                    pictureBoxReferensbild.Image = null;
                }
            }
        }
    }
}
