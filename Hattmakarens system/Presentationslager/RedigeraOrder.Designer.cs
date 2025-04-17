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
            ((System.ComponentModel.ISupportInitialize)dgvOrderRader).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrderRader
            // 
            dgvOrderRader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderRader.Location = new Point(30, 61);
            dgvOrderRader.Margin = new Padding(4, 3, 4, 3);
            dgvOrderRader.Name = "dgvOrderRader";
            dgvOrderRader.RowHeadersWidth = 82;
            dgvOrderRader.Size = new Size(572, 272);
            dgvOrderRader.TabIndex = 4;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(527, 339);
            btnSpara.Margin = new Padding(4, 3, 4, 3);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(75, 23);
            btnSpara.TabIndex = 5;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1020, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(59, 20);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // RedigeraOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 473);
            Controls.Add(btnSpara);
            Controls.Add(dgvOrderRader);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
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
    }
}