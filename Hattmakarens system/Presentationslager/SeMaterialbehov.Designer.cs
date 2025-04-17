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
            btnSparaBestallning = new Button();
            cmbHattar = new ComboBox();
            btnVisaMaterial = new Button();
            grpBoxSeHatt = new GroupBox();
            menuStrip1 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).BeginInit();
            grpBoxSeHatt.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMaterial
            // 
            dataGridViewMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterial.Location = new Point(304, 28);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.RowHeadersWidth = 51;
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
            // cmbHattar
            // 
            cmbHattar.FormattingEnabled = true;
            cmbHattar.Location = new Point(7, 23);
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
            // grpBoxSeHatt
            // 
            grpBoxSeHatt.Controls.Add(btnVisaMaterial);
            grpBoxSeHatt.Controls.Add(cmbHattar);
            grpBoxSeHatt.Location = new Point(12, 28);
            grpBoxSeHatt.Name = "grpBoxSeHatt";
            grpBoxSeHatt.Size = new Size(209, 131);
            grpBoxSeHatt.TabIndex = 0;
            grpBoxSeHatt.TabStop = false;
            grpBoxSeHatt.Text = "Lista över hattar ";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1020, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(59, 20);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1020, 24);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // SeMaterialbehov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 473);
            Controls.Add(btnSparaBestallning);
            Controls.Add(dataGridViewMaterial);
            Controls.Add(grpBoxSeHatt);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "SeMaterialbehov";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SeMaterialbehov&Beställningsstatus";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).EndInit();
            grpBoxSeHatt.ResumeLayout(false);
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewMaterial;
        private Button btnSparaBestallning;
        private ComboBox cmbHattar;
        private Button btnVisaMaterial;
        private GroupBox grpBoxSeHatt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
        private MenuStrip menuStrip2;
    }
}