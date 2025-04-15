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
            grpBoxSeHatt.Location = new Point(12, 28);
            grpBoxSeHatt.Name = "grpBoxSeHatt";
            grpBoxSeHatt.Size = new Size(200, 100);
            grpBoxSeHatt.TabIndex = 0;
            grpBoxSeHatt.TabStop = false;
            grpBoxSeHatt.Text = "Lista över hattar ";
            // 
            // btnVisaMaterial
            // 
            btnVisaMaterial.Location = new Point(7, 51);
            btnVisaMaterial.Name = "btnVisaMaterial";
            btnVisaMaterial.Size = new Size(120, 23);
            btnVisaMaterial.TabIndex = 1;
            btnVisaMaterial.Text = "Visa Materialbehov";
            btnVisaMaterial.UseVisualStyleBackColor = true;
            // 
            // cmbHattar
            // 
            cmbHattar.FormattingEnabled = true;
            cmbHattar.Location = new Point(6, 22);
            cmbHattar.Name = "cmbHattar";
            cmbHattar.Size = new Size(121, 23);
            cmbHattar.TabIndex = 0;
            // 
            // dataGridViewMaterial
            // 
            dataGridViewMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterial.Location = new Point(304, 28);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.Size = new Size(772, 369);
            dataGridViewMaterial.TabIndex = 1;
            // 
            // btnSparaBestallning
            // 
            btnSparaBestallning.Location = new Point(963, 365);
            btnSparaBestallning.Name = "btnSparaBestallning";
            btnSparaBestallning.Size = new Size(113, 32);
            btnSparaBestallning.TabIndex = 2;
            btnSparaBestallning.Text = "Spara beställning";
            btnSparaBestallning.UseVisualStyleBackColor = true;
            btnSparaBestallning.Click += btnSparaBestallning_Click;
            // 
            // SeMaterialbehov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 450);
            Controls.Add(btnSparaBestallning);
            Controls.Add(dataGridViewMaterial);
            Controls.Add(grpBoxSeHatt);
            Name = "SeMaterialbehov";
            Text = "SeMaterialbehov&Beställningsstatus";
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