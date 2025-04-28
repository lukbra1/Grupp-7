namespace Hattmakarens_system
{
    partial class SeMaterialbehov
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewMaterial = new DataGridView();
            dtpSlutDatum = new DateTimePicker();
            dtpStartDatum = new DateTimePicker();
            lblFrån = new Label();
            lblTill = new Label();
            btnFiltreraDatum = new Button();
            label3 = new Label();
            lvOrdrar = new ListView();
            OrderId = new ColumnHeader();
            Kund = new ColumnHeader();
            Datum = new ColumnHeader();
            Express = new ColumnHeader();
            btnExporteraMaterial = new Button();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMaterial
            // 
            dataGridViewMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterial.Location = new Point(494, 38);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.RowHeadersWidth = 51;
            dataGridViewMaterial.Size = new Size(370, 413);
            dataGridViewMaterial.TabIndex = 1;
            // 
            // dtpSlutDatum
            // 
            dtpSlutDatum.Location = new Point(144, 487);
            dtpSlutDatum.Name = "dtpSlutDatum";
            dtpSlutDatum.Size = new Size(103, 23);
            dtpSlutDatum.TabIndex = 3;
            // 
            // dtpStartDatum
            // 
            dtpStartDatum.Location = new Point(12, 487);
            dtpStartDatum.Name = "dtpStartDatum";
            dtpStartDatum.Size = new Size(114, 23);
            dtpStartDatum.TabIndex = 4;
            // 
            // lblFrån
            // 
            lblFrån.AutoSize = true;
            lblFrån.Location = new Point(57, 469);
            lblFrån.Name = "lblFrån";
            lblFrån.Size = new Size(30, 15);
            lblFrån.TabIndex = 5;
            lblFrån.Text = "Från";
            // 
            // lblTill
            // 
            lblTill.AutoSize = true;
            lblTill.Location = new Point(184, 469);
            lblTill.Name = "lblTill";
            lblTill.Size = new Size(22, 15);
            lblTill.TabIndex = 6;
            lblTill.Text = "Till";
            // 
            // btnFiltreraDatum
            // 
            btnFiltreraDatum.Location = new Point(270, 487);
            btnFiltreraDatum.Name = "btnFiltreraDatum";
            btnFiltreraDatum.Size = new Size(75, 23);
            btnFiltreraDatum.TabIndex = 7;
            btnFiltreraDatum.Text = "Filtrera";
            btnFiltreraDatum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 226);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // lvOrdrar
            // 
            lvOrdrar.Columns.AddRange(new ColumnHeader[] { OrderId, Kund, Datum, Express });
            lvOrdrar.FullRowSelect = true;
            lvOrdrar.Location = new Point(26, 38);
            lvOrdrar.Name = "lvOrdrar";
            lvOrdrar.Size = new Size(447, 413);
            lvOrdrar.TabIndex = 9;
            lvOrdrar.UseCompatibleStateImageBehavior = false;
            lvOrdrar.View = View.Details;
            // 
            // OrderId
            // 
            OrderId.Text = "OrderId";
            OrderId.Width = 100;
            // 
            // Kund
            // 
            Kund.Text = "Kund";
            Kund.Width = 100;
            // 
            // Datum
            // 
            Datum.Text = "Datum";
            Datum.Width = 100;
            // 
            // Express
            // 
            Express.Text = "Express";
            Express.Width = 100;
            // 
            // btnExporteraMaterial
            // 
            btnExporteraMaterial.Location = new Point(746, 487);
            btnExporteraMaterial.Name = "btnExporteraMaterial";
            btnExporteraMaterial.Size = new Size(162, 23);
            btnExporteraMaterial.TabIndex = 10;
            btnExporteraMaterial.Text = "Skriv ut materialbehov";
            btnExporteraMaterial.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(947, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(3, 1, 0, 1);
            menuStrip2.Size = new Size(947, 24);
            menuStrip2.TabIndex = 12;
            menuStrip2.Text = "menuStrip2";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(59, 22);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // SeMaterialbehov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(947, 407);
            Controls.Add(btnExporteraMaterial);
            Controls.Add(lvOrdrar);
            Controls.Add(label3);
            Controls.Add(btnFiltreraDatum);
            Controls.Add(lblTill);
            Controls.Add(lblFrån);
            Controls.Add(dtpStartDatum);
            Controls.Add(dtpSlutDatum);
            Controls.Add(dataGridViewMaterial);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "SeMaterialbehov";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SeMaterialbehov&Beställningsstatus";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewMaterial;
        private DateTimePicker dtpSlutDatum;
        private DateTimePicker dtpStartDatum;
        private Label lblFrån;
        private Label lblTill;
        private Button btnFiltreraDatum;
        private Label label3;
        private ListView lvOrdrar;
        private Button btnExporteraMaterial;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
        private ColumnHeader OrderId;
        private ColumnHeader Kund;
        private ColumnHeader Datum;
        private ColumnHeader Express;
    }
}