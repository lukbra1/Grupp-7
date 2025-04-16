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
            dgvOrderRader.Location = new Point(34, 29);
            dgvOrderRader.Margin = new Padding(4, 4, 4, 4);
            dgvOrderRader.Name = "dgvOrderRader";
            dgvOrderRader.RowHeadersWidth = 82;
            dgvOrderRader.Size = new Size(654, 362);
            dgvOrderRader.TabIndex = 4;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(602, 408);
            btnSpara.Margin = new Padding(4, 4, 4, 4);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(86, 31);
            btnSpara.TabIndex = 5;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            // 
            // RedigeraOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 481);
            Controls.Add(btnSpara);
            Controls.Add(dgvOrderRader);
            Margin = new Padding(4, 4, 4, 4);
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