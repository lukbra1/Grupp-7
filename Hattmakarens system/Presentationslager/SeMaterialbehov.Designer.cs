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
            dataGridViewMaterial.Location = new Point(912, 82);
            dataGridViewMaterial.Margin = new Padding(5, 6, 5, 6);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.RowHeadersWidth = 51;
            dataGridViewMaterial.Size = new Size(1078, 881);
            dataGridViewMaterial.TabIndex = 1;
            // 
            // dtpSlutDatum
            // 
            dtpSlutDatum.Location = new Point(268, 1039);
            dtpSlutDatum.Margin = new Padding(5, 6, 5, 6);
            dtpSlutDatum.Name = "dtpSlutDatum";
            dtpSlutDatum.Size = new Size(187, 39);
            dtpSlutDatum.TabIndex = 3;
            // 
            // dtpStartDatum
            // 
            dtpStartDatum.Location = new Point(22, 1039);
            dtpStartDatum.Margin = new Padding(5, 6, 5, 6);
            dtpStartDatum.Name = "dtpStartDatum";
            dtpStartDatum.Size = new Size(208, 39);
            dtpStartDatum.TabIndex = 4;
            // 
            // lblFrån
            // 
            lblFrån.AutoSize = true;
            lblFrån.Location = new Point(105, 1001);
            lblFrån.Margin = new Padding(5, 0, 5, 0);
            lblFrån.Name = "lblFrån";
            lblFrån.Size = new Size(60, 32);
            lblFrån.TabIndex = 5;
            lblFrån.Text = "Från";
            // 
            // lblTill
            // 
            lblTill.AutoSize = true;
            lblTill.Location = new Point(342, 1001);
            lblTill.Margin = new Padding(5, 0, 5, 0);
            lblTill.Name = "lblTill";
            lblTill.Size = new Size(45, 32);
            lblTill.TabIndex = 6;
            lblTill.Text = "Till";
            // 
            // btnFiltreraDatum
            // 
            btnFiltreraDatum.Location = new Point(502, 1039);
            btnFiltreraDatum.Margin = new Padding(5, 6, 5, 6);
            btnFiltreraDatum.Name = "btnFiltreraDatum";
            btnFiltreraDatum.Size = new Size(139, 49);
            btnFiltreraDatum.TabIndex = 7;
            btnFiltreraDatum.Text = "Filtrera";
            btnFiltreraDatum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 483);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 8;
            // 
            // lvOrdrar
            // 
            lvOrdrar.Location = new Point(49, 82);
            lvOrdrar.Margin = new Padding(5, 6, 5, 6);
            lvOrdrar.Name = "lvOrdrar";
            lvOrdrar.Size = new Size(827, 877);
            lvOrdrar.TabIndex = 9;
            lvOrdrar.UseCompatibleStateImageBehavior = false;
            lvOrdrar.SelectedIndexChanged += lvOrdrar_SelectedIndexChanged;
            // 
            // btnExporteraMaterial
            // 
            btnExporteraMaterial.Location = new Point(1386, 1039);
            btnExporteraMaterial.Margin = new Padding(5, 6, 5, 6);
            btnExporteraMaterial.Name = "btnExporteraMaterial";
            btnExporteraMaterial.Size = new Size(300, 49);
            btnExporteraMaterial.TabIndex = 10;
            btnExporteraMaterial.Text = "Skriv ut materialbehov";
            btnExporteraMaterial.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 40);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2293, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(2293, 40);
            menuStrip2.TabIndex = 12;
            menuStrip2.Text = "menuStrip2";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(115, 36);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // SeMaterialbehov
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2293, 1114);
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
            Margin = new Padding(5, 6, 5, 6);
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
    }
}