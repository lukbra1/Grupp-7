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
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaterial
            // 
            dataGridViewMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterial.Location = new Point(575, 12);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.RowHeadersWidth = 51;
            dataGridViewMaterial.Size = new Size(580, 413);
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
            lvOrdrar.Location = new Point(12, 12);
            lvOrdrar.Name = "lvOrdrar";
            lvOrdrar.Size = new Size(447, 413);
            lvOrdrar.TabIndex = 9;
            lvOrdrar.UseCompatibleStateImageBehavior = false;
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
            // SeMaterialbehov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 522);
            Controls.Add(btnExporteraMaterial);
            Controls.Add(lvOrdrar);
            Controls.Add(label3);
            Controls.Add(btnFiltreraDatum);
            Controls.Add(lblTill);
            Controls.Add(lblFrån);
            Controls.Add(dtpStartDatum);
            Controls.Add(dtpSlutDatum);
            Controls.Add(dataGridViewMaterial);
            Name = "SeMaterialbehov";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SeMaterialbehov&Beställningsstatus";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).EndInit();
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
    }
}