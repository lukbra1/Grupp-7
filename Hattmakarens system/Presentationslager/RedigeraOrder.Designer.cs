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
            cmbOrderId = new ComboBox();
            dgvOrderRader = new DataGridView();
            btnSpara = new Button();
            btnVisaOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderRader).BeginInit();
            SuspendLayout();
            // 
            // cmbOrderId
            // 
            cmbOrderId.FormattingEnabled = true;
            cmbOrderId.Location = new Point(12, 208);
            cmbOrderId.Name = "cmbOrderId";
            cmbOrderId.Size = new Size(143, 23);
            cmbOrderId.TabIndex = 0;
            cmbOrderId.Text = "Välj en order";
            // 
            // dgvOrderRader
            // 
            dgvOrderRader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderRader.Location = new Point(471, 47);
            dgvOrderRader.Name = "dgvOrderRader";
            dgvOrderRader.Size = new Size(583, 416);
            dgvOrderRader.TabIndex = 4;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(961, 428);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(75, 23);
            btnSpara.TabIndex = 5;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            // 
            // btnVisaOrder
            // 
            btnVisaOrder.Location = new Point(161, 207);
            btnVisaOrder.Name = "btnVisaOrder";
            btnVisaOrder.Size = new Size(75, 23);
            btnVisaOrder.TabIndex = 6;
            btnVisaOrder.Text = "Visa order";
            btnVisaOrder.UseVisualStyleBackColor = true;
            // 
            // RedigeraOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 503);
            Controls.Add(btnVisaOrder);
            Controls.Add(btnSpara);
            Controls.Add(dgvOrderRader);
            Controls.Add(cmbOrderId);
            Name = "RedigeraOrder";
            Text = "RedigeraOrder";
            ((System.ComponentModel.ISupportInitialize)dgvOrderRader).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbOrderId;
        private DataGridView dgvOrderRader;
        private Button btnSpara;
        private Button btnVisaOrder;
    }
}