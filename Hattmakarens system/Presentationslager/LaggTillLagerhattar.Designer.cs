namespace Hattmakarens_system.Presentationslager
{
    partial class LaggTillLagerhattar
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
            pbReferens = new PictureBox();
            lblNamn = new Label();
            btnLäggtill = new Button();
            lblPris = new Label();
            btnSpec = new Button();
            label11 = new Label();
            label12 = new Label();
            btnVisaBeställning = new Button();
            chbAnpassa = new CheckBox();
            cbVäljHatt = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbReferens).BeginInit();
            SuspendLayout();
            // 
            // pbReferens
            // 
            pbReferens.Image = Properties.Resources.Oktoberhatt;
            pbReferens.Location = new Point(72, 222);
            pbReferens.Name = "pbReferens";
            pbReferens.Size = new Size(302, 293);
            pbReferens.SizeMode = PictureBoxSizeMode.Zoom;
            pbReferens.TabIndex = 0;
            pbReferens.TabStop = false;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(132, 528);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(164, 32);
            lblNamn.TabIndex = 5;
            lblNamn.Text = "Studentmössa";
            // 
            // btnLäggtill
            // 
            btnLäggtill.Location = new Point(132, 722);
            btnLäggtill.Name = "btnLäggtill";
            btnLäggtill.Size = new Size(150, 46);
            btnLäggtill.TabIndex = 10;
            btnLäggtill.Text = "Lägg till";
            btnLäggtill.UseVisualStyleBackColor = true;
            btnLäggtill.Click += btnLäggtill_Click;
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(164, 573);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(80, 32);
            lblPris.TabIndex = 14;
            lblPris.Text = "800 kr";
            // 
            // btnSpec
            // 
            btnSpec.Location = new Point(302, 91);
            btnSpec.Name = "btnSpec";
            btnSpec.Size = new Size(270, 46);
            btnSpec.TabIndex = 20;
            btnSpec.Text = "Special order";
            btnSpec.UseVisualStyleBackColor = true;
            btnSpec.Click += btnSpec_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(84, 91);
            label11.Name = "label11";
            label11.Size = new Size(198, 32);
            label11.TabIndex = 21;
            label11.Text = "Skapa specialhatt";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(72, 162);
            label12.Name = "label12";
            label12.Size = new Size(160, 32);
            label12.TabIndex = 22;
            label12.Text = "Välj lager hatt";
            // 
            // btnVisaBeställning
            // 
            btnVisaBeställning.Location = new Point(1332, 62);
            btnVisaBeställning.Name = "btnVisaBeställning";
            btnVisaBeställning.Size = new Size(294, 46);
            btnVisaBeställning.TabIndex = 23;
            btnVisaBeställning.Text = "Visa beställning";
            btnVisaBeställning.UseVisualStyleBackColor = true;
            btnVisaBeställning.Click += btnVisaBeställning_Click;
            // 
            // chbAnpassa
            // 
            chbAnpassa.AutoSize = true;
            chbAnpassa.Location = new Point(148, 638);
            chbAnpassa.Name = "chbAnpassa";
            chbAnpassa.Size = new Size(133, 36);
            chbAnpassa.TabIndex = 25;
            chbAnpassa.Text = "Anpassa";
            chbAnpassa.UseVisualStyleBackColor = true;
            // 
            // cbVäljHatt
            // 
            cbVäljHatt.FormattingEnabled = true;
            cbVäljHatt.Location = new Point(270, 157);
            cbVäljHatt.Margin = new Padding(5, 5, 5, 5);
            cbVäljHatt.Name = "cbVäljHatt";
            cbVäljHatt.Size = new Size(243, 40);
            cbVäljHatt.TabIndex = 26;
            cbVäljHatt.SelectedIndexChanged += cbVäljHatt_SelectedIndexChanged;
            // 
            // LaggTillLagerhattar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(cbVäljHatt);
            Controls.Add(chbAnpassa);
            Controls.Add(btnVisaBeställning);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnSpec);
            Controls.Add(lblPris);
            Controls.Add(btnLäggtill);
            Controls.Add(lblNamn);
            Controls.Add(pbReferens);
            Name = "LaggTillLagerhattar";
            Text = "LaggTillLagerhattar";
            WindowState = FormWindowState.Maximized;
            Load += LaggTillLagerhattar_Load;
            ((System.ComponentModel.ISupportInitialize)pbReferens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbReferens;
        private Label lblNamn;
        private Button btnLäggtill;
        private Label lblPris;
        private Button btnSpec;
        private Label label11;
        private Label label12;
        private Button btnVisaBeställning;
        private CheckBox chbAnpassa;
        private ComboBox cbVäljHatt;
    }
}