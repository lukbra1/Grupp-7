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
            dgvMatrial = new DataGridView();
            pictureBoxReferensbild = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderRader).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReferensbild).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderRader
            // 
            dgvOrderRader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderRader.Location = new Point(55, 130);
            dgvOrderRader.Margin = new Padding(6);
            dgvOrderRader.Name = "dgvOrderRader";
            dgvOrderRader.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrderRader.RowHeadersWidth = 82;
            dgvOrderRader.Size = new Size(1359, 306);
            dgvOrderRader.TabIndex = 4;
            dgvOrderRader.CellClick += dgvOrderRader_CellClick;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(1274, 834);
            btnSpara.Margin = new Padding(6);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(140, 50);
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
            menuStrip1.Padding = new Padding(11, 3, 0, 3);
            menuStrip1.Size = new Size(2025, 42);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(115, 36);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(55, 834);
            checkBox1.Margin = new Padding(5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(212, 36);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Expressleverans";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dgvMatrial
            // 
            dgvMatrial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrial.Location = new Point(55, 495);
            dgvMatrial.Name = "dgvMatrial";
            dgvMatrial.RowHeadersWidth = 82;
            dgvMatrial.Size = new Size(1359, 300);
            dgvMatrial.TabIndex = 8;
            dgvMatrial.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBoxReferensbild
            // 
            pictureBoxReferensbild.Location = new Point(1482, 167);
            pictureBoxReferensbild.Name = "pictureBoxReferensbild";
            pictureBoxReferensbild.Size = new Size(265, 230);
            pictureBoxReferensbild.TabIndex = 9;
            pictureBoxReferensbild.TabStop = false;
            // 
            // RedigeraOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2025, 930);
            Controls.Add(pictureBoxReferensbild);
            Controls.Add(dgvMatrial);
            Controls.Add(checkBox1);
            Controls.Add(btnSpara);
            Controls.Add(dgvOrderRader);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "RedigeraOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visa beställning";
            FormClosed += RedigeraOrder_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvOrderRader).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReferensbild).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvOrderRader;
        private Button btnSpara;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
        private CheckBox checkBox1;
        private DataGridView dgvMatrial;
        private PictureBox pictureBoxReferensbild;
    }
}