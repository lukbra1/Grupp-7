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
            dataGridViewMaterial.Location = new Point(821, 20);
            dataGridViewMaterial.Margin = new Padding(4, 5, 4, 5);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.RowHeadersWidth = 51;
            dataGridViewMaterial.Size = new Size(829, 688);
            dataGridViewMaterial.TabIndex = 1;
            // 
            // dtpSlutDatum
            // 
            dtpSlutDatum.Location = new Point(206, 812);
            dtpSlutDatum.Margin = new Padding(4, 5, 4, 5);
            dtpSlutDatum.Name = "dtpSlutDatum";
            dtpSlutDatum.Size = new Size(145, 31);
            dtpSlutDatum.TabIndex = 3;
            // 
            // dtpStartDatum
            // 
            dtpStartDatum.Location = new Point(17, 812);
            dtpStartDatum.Margin = new Padding(4, 5, 4, 5);
            dtpStartDatum.Name = "dtpStartDatum";
            dtpStartDatum.Size = new Size(161, 31);
            dtpStartDatum.TabIndex = 4;
            // 
            // lblFrån
            // 
            lblFrån.AutoSize = true;
            lblFrån.Location = new Point(81, 782);
            lblFrån.Margin = new Padding(4, 0, 4, 0);
            lblFrån.Name = "lblFrån";
            lblFrån.Size = new Size(46, 25);
            lblFrån.TabIndex = 5;
            lblFrån.Text = "Från";
            // 
            // lblTill
            // 
            lblTill.AutoSize = true;
            lblTill.Location = new Point(263, 782);
            lblTill.Margin = new Padding(4, 0, 4, 0);
            lblTill.Name = "lblTill";
            lblTill.Size = new Size(33, 25);
            lblTill.TabIndex = 6;
            lblTill.Text = "Till";
            // 
            // btnFiltreraDatum
            // 
            btnFiltreraDatum.Location = new Point(386, 812);
            btnFiltreraDatum.Margin = new Padding(4, 5, 4, 5);
            btnFiltreraDatum.Name = "btnFiltreraDatum";
            btnFiltreraDatum.Size = new Size(107, 38);
            btnFiltreraDatum.TabIndex = 7;
            btnFiltreraDatum.Text = "Filtrera";
            btnFiltreraDatum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 377);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 8;
            // 
            // lvOrdrar
            // 
            lvOrdrar.Location = new Point(17, 20);
            lvOrdrar.Margin = new Padding(4, 5, 4, 5);
            lvOrdrar.Name = "lvOrdrar";
            lvOrdrar.Size = new Size(637, 686);
            lvOrdrar.TabIndex = 9;
            lvOrdrar.UseCompatibleStateImageBehavior = false;
            lvOrdrar.SelectedIndexChanged += lvOrdrar_SelectedIndexChanged;
            // 
            // btnExporteraMaterial
            // 
            btnExporteraMaterial.Location = new Point(1066, 812);
            btnExporteraMaterial.Margin = new Padding(4, 5, 4, 5);
            btnExporteraMaterial.Name = "btnExporteraMaterial";
            btnExporteraMaterial.Size = new Size(231, 38);
            btnExporteraMaterial.TabIndex = 10;
            btnExporteraMaterial.Text = "Skriv ut materialbehov";
            btnExporteraMaterial.UseVisualStyleBackColor = true;
            // 
            // SeMaterialbehov
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1764, 870);
            Controls.Add(btnExporteraMaterial);
            Controls.Add(lvOrdrar);
            Controls.Add(label3);
            Controls.Add(btnFiltreraDatum);
            Controls.Add(lblTill);
            Controls.Add(lblFrån);
            Controls.Add(dtpStartDatum);
            Controls.Add(dtpSlutDatum);
            Controls.Add(dataGridViewMaterial);
            Margin = new Padding(4, 5, 4, 5);
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