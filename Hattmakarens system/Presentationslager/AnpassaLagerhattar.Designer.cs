namespace Hattmakarens_system.Presentationslager
{
    partial class AnpassaLagerhattar
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
            lblNamn = new Label();
            lblPris = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKostnad = new TextBox();
            txtVarde = new TextBox();
            txtTyp = new TextBox();
            btnGaVidare = new Button();
            SuspendLayout();
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(36, 63);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(78, 32);
            lblNamn.TabIndex = 0;
            lblNamn.Text = "label1";
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(204, 63);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(78, 32);
            lblPris.TabIndex = 1;
            lblPris.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 139);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 2;
            label1.Text = "Typ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 204);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 3;
            label2.Text = "Värde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 264);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 4;
            label3.Text = "Extrakostnad";
            // 
            // txtKostnad
            // 
            txtKostnad.Location = new Point(195, 257);
            txtKostnad.Name = "txtKostnad";
            txtKostnad.Size = new Size(200, 39);
            txtKostnad.TabIndex = 5;
            // 
            // txtVarde
            // 
            txtVarde.Location = new Point(195, 197);
            txtVarde.Name = "txtVarde";
            txtVarde.Size = new Size(200, 39);
            txtVarde.TabIndex = 6;
            // 
            // txtTyp
            // 
            txtTyp.Location = new Point(195, 132);
            txtTyp.Name = "txtTyp";
            txtTyp.Size = new Size(200, 39);
            txtTyp.TabIndex = 7;
            // 
            // btnGaVidare
            // 
            btnGaVidare.Location = new Point(621, 371);
            btnGaVidare.Name = "btnGaVidare";
            btnGaVidare.Size = new Size(150, 46);
            btnGaVidare.TabIndex = 8;
            btnGaVidare.Text = "Gå vidare";
            btnGaVidare.UseVisualStyleBackColor = true;
            // 
            // AnpassaLagerhattar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 710);
            Controls.Add(btnGaVidare);
            Controls.Add(txtTyp);
            Controls.Add(txtVarde);
            Controls.Add(txtKostnad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPris);
            Controls.Add(lblNamn);
            Name = "AnpassaLagerhattar";
            Text = "AnpassaLagerhattar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamn;
        private Label lblPris;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKostnad;
        private TextBox txtVarde;
        private TextBox txtTyp;
        private Button btnGaVidare;
    }
}