namespace Hattmakarens_system.Presentationslager
{
    partial class AllaBeställningar
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
            lblAllaBeställningar = new ListBox();
            btnSkapaFraktSedel = new Button();
            btnRedigera = new Button();
            SuspendLayout();
            // 
            // lblAllaBeställningar
            // 
            lblAllaBeställningar.FormattingEnabled = true;
            lblAllaBeställningar.Location = new Point(34, 39);
            lblAllaBeställningar.Name = "lblAllaBeställningar";
            lblAllaBeställningar.Size = new Size(517, 364);
            lblAllaBeställningar.TabIndex = 0;
            // 
            // btnSkapaFraktSedel
            // 
            btnSkapaFraktSedel.Location = new Point(595, 374);
            btnSkapaFraktSedel.Name = "btnSkapaFraktSedel";
            btnSkapaFraktSedel.Size = new Size(174, 29);
            btnSkapaFraktSedel.TabIndex = 1;
            btnSkapaFraktSedel.Text = "Skapa Fraktsedel";
            btnSkapaFraktSedel.UseVisualStyleBackColor = true;
            // 
            // btnRedigera
            // 
            btnRedigera.Location = new Point(595, 326);
            btnRedigera.Name = "btnRedigera";
            btnRedigera.Size = new Size(174, 29);
            btnRedigera.TabIndex = 2;
            btnRedigera.Text = "Redigera Beställning";
            btnRedigera.UseVisualStyleBackColor = true;
            // 
            // AllaBeställningar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRedigera);
            Controls.Add(btnSkapaFraktSedel);
            Controls.Add(lblAllaBeställningar);
            Name = "AllaBeställningar";
            Text = "AllaBeställningar";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lblAllaBeställningar;
        private Button btnSkapaFraktSedel;
        private Button btnRedigera;
    }
}