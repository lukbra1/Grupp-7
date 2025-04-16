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
            grpBoxSeHatt = new GroupBox();
            btnVisaMaterial = new Button();
            cmbHattar = new ComboBox();
            dataGridViewMaterial = new DataGridView();
            btnSparaBestallning = new Button();
            grpBoxSeHatt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).BeginInit();
            SuspendLayout();
            // 
            // grpBoxSeHatt
            // 
            grpBoxSeHatt.Controls.Add(btnVisaMaterial);
            grpBoxSeHatt.Controls.Add(cmbHattar);
            grpBoxSeHatt.Location = new Point(14, 37);
            grpBoxSeHatt.Margin = new Padding(3, 4, 3, 4);
            grpBoxSeHatt.Name = "grpBoxSeHatt";
            grpBoxSeHatt.Padding = new Padding(3, 4, 3, 4);
            grpBoxSeHatt.Size = new Size(229, 133);
            grpBoxSeHatt.TabIndex = 0;
            grpBoxSeHatt.TabStop = false;
            grpBoxSeHatt.Text = "Lista över hattar ";
            // 
            // btnVisaMaterial
            // 
            btnVisaMaterial.Location = new Point(8, 68);
            btnVisaMaterial.Margin = new Padding(3, 4, 3, 4);
            btnVisaMaterial.Name = "btnVisaMaterial";
            btnVisaMaterial.Size = new Size(137, 31);
            btnVisaMaterial.TabIndex = 1;
            btnVisaMaterial.Text = "Visa Materialbehov";
            btnVisaMaterial.UseVisualStyleBackColor = true;
            // 
            // cmbHattar
            // 
            cmbHattar.FormattingEnabled = true;
            cmbHattar.Location = new Point(7, 29);
            cmbHattar.Margin = new Padding(3, 4, 3, 4);
            cmbHattar.Name = "cmbHattar";
            cmbHattar.Size = new Size(138, 28);
            cmbHattar.TabIndex = 0;
            // 
            // dataGridViewMaterial
            // 
            dataGridViewMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterial.Location = new Point(347, 37);
            dataGridViewMaterial.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.RowHeadersWidth = 51;
            dataGridViewMaterial.Size = new Size(882, 492);
            dataGridViewMaterial.TabIndex = 1;
            // 
            // btnSparaBestallning
            // 
            btnSparaBestallning.Location = new Point(1101, 487);
            btnSparaBestallning.Margin = new Padding(3, 4, 3, 4);
            btnSparaBestallning.Name = "btnSparaBestallning";
            btnSparaBestallning.Size = new Size(129, 43);
            btnSparaBestallning.TabIndex = 2;
            btnSparaBestallning.Text = "Spara beställning";
            btnSparaBestallning.UseVisualStyleBackColor = true;
            btnSparaBestallning.Click += btnSparaBestallning_Click;
            // 
            // SeMaterialbehov
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 600);
            Controls.Add(btnSparaBestallning);
            Controls.Add(dataGridViewMaterial);
            Controls.Add(grpBoxSeHatt);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SeMaterialbehov";
            Text = "SeMaterialbehov&Beställningsstatus";
            WindowState = FormWindowState.Maximized;
            grpBoxSeHatt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxSeHatt;
        private ComboBox cmbHattar;
        private Button btnVisaMaterial;
        private DataGridView dataGridViewMaterial;
        private Button btnSparaBestallning;
    }
}