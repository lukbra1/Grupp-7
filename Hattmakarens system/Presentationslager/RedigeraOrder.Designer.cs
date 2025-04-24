namespace Hattmakarens_system
{
    partial class RedigeraOrder
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
            dgvOrderRader = new DataGridView();
            btnSpara = new Button();
            menuStrip1 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderRader).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrderRader
            // 
            dgvOrderRader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderRader.Location = new Point(34, 81);
            dgvOrderRader.Margin = new Padding(4, 4, 4, 4);
            dgvOrderRader.Name = "dgvOrderRader";
            dgvOrderRader.RowHeadersWidth = 82;
            dgvOrderRader.Size = new Size(847, 362);
            dgvOrderRader.TabIndex = 4;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(795, 455);
            btnSpara.Margin = new Padding(4, 4, 4, 4);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(86, 31);
            btnSpara.TabIndex = 5;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(927, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(75, 24);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(34, 459);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Expressleverans";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // RedigeraOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 511);
            Controls.Add(checkBox1);
            Controls.Add(btnSpara);
            Controls.Add(dgvOrderRader);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "RedigeraOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RedigeraOrder";
            ((System.ComponentModel.ISupportInitialize)dgvOrderRader).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvOrderRader;
        private Button btnSpara;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
        private CheckBox checkBox1;
    }
}