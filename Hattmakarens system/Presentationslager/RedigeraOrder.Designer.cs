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
            ((System.ComponentModel.ISupportInitialize)dgvOrderRader).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderRader
            // 
            dgvOrderRader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderRader.Location = new Point(55, 46);
            dgvOrderRader.Margin = new Padding(6, 6, 6, 6);
            dgvOrderRader.Name = "dgvOrderRader";
            dgvOrderRader.RowHeadersWidth = 82;
            dgvOrderRader.Size = new Size(1063, 579);
            dgvOrderRader.TabIndex = 4;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(978, 653);
            btnSpara.Margin = new Padding(6, 6, 6, 6);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(140, 50);
            btnSpara.TabIndex = 5;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            // 
            // RedigeraOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(btnSpara);
            Controls.Add(dgvOrderRader);
            Margin = new Padding(6, 6, 6, 6);
            Name = "RedigeraOrder";
            Text = "RedigeraOrder";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvOrderRader).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvOrderRader;
        private Button btnSpara;
    }
}