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
            cmbHattar = new ComboBox();
            btnVisaMaterial = new Button();
            dataGridView1 = new DataGridView();
            grpBoxSeHatt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpBoxSeHatt
            // 
            grpBoxSeHatt.Controls.Add(btnVisaMaterial);
            grpBoxSeHatt.Controls.Add(cmbHattar);
            grpBoxSeHatt.Location = new Point(76, 28);
            grpBoxSeHatt.Name = "grpBoxSeHatt";
            grpBoxSeHatt.Size = new Size(200, 100);
            grpBoxSeHatt.TabIndex = 0;
            grpBoxSeHatt.TabStop = false;
            grpBoxSeHatt.Text = "Lista över hattar ";
            grpBoxSeHatt.Enter += groupBox1_Enter;
            // 
            // cmbHattar
            // 
            cmbHattar.FormattingEnabled = true;
            cmbHattar.Location = new Point(6, 22);
            cmbHattar.Name = "cmbHattar";
            cmbHattar.Size = new Size(121, 23);
            cmbHattar.TabIndex = 0;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(304, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(484, 317);
            dataGridView1.TabIndex = 1;
            // 
            // SeMaterialbehov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(grpBoxSeHatt);
            Name = "SeMaterialbehov";
            Text = "SeMaterialbehov";
            grpBoxSeHatt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxSeHatt;
        private ComboBox cmbHattar;
        private Button btnVisaMaterial;
        private DataGridView dataGridView1;
    }
}