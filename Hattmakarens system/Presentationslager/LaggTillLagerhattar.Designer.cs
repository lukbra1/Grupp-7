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
            panelLagerHattar = new Panel();
            panelSpecHattar = new Panel();
            lvBeställningar = new ListView();
            Typ = new ColumnHeader();
            Modell = new ColumnHeader();
            Storlek = new ColumnHeader();
            lblTotal = new Label();
            menuStrip1 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbReferens).BeginInit();
            panelLagerHattar.SuspendLayout();
            panelSpecHattar.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pbReferens
            // 
            pbReferens.Image = Properties.Resources.Oktoberhatt;
            pbReferens.Location = new Point(5, 106);
            pbReferens.Name = "pbReferens";
            pbReferens.Size = new Size(224, 222);
            pbReferens.SizeMode = PictureBoxSizeMode.Zoom;
            pbReferens.TabIndex = 0;
            pbReferens.TabStop = false;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(90, 369);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(164, 32);
            lblNamn.TabIndex = 5;
            lblNamn.Text = "Studentmössa";
            // 
            // btnLäggtill
            // 
            btnLäggtill.Location = new Point(32, 441);
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
            lblPris.Location = new Point(57, 342);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(80, 32);
            lblPris.TabIndex = 14;
            lblPris.Text = "800 kr";
            // 
            // btnSpec
            // 
            btnSpec.Location = new Point(32, 117);
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
            label11.Location = new Point(31, 51);
            label11.Name = "label11";
            label11.Size = new Size(198, 32);
            label11.TabIndex = 21;
            label11.Text = "Skapa specialhatt";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 12);
            label12.Name = "label12";
            label12.Size = new Size(160, 32);
            label12.TabIndex = 22;
            label12.Text = "Välj lager hatt";
            // 
            // btnVisaBeställning
            // 
            btnVisaBeställning.Location = new Point(1800, 1343);
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
            chbAnpassa.Location = new Point(32, 387);
            chbAnpassa.Name = "chbAnpassa";
            chbAnpassa.Size = new Size(133, 36);
            chbAnpassa.TabIndex = 25;
            chbAnpassa.Text = "Anpassa";
            chbAnpassa.UseVisualStyleBackColor = true;
            // 
            // cbVäljHatt
            // 
            cbVäljHatt.FormattingEnabled = true;
            cbVäljHatt.Location = new Point(5, 49);
            cbVäljHatt.Margin = new Padding(5);
            cbVäljHatt.Name = "cbVäljHatt";
            cbVäljHatt.Size = new Size(243, 40);
            cbVäljHatt.TabIndex = 26;
            cbVäljHatt.SelectedIndexChanged += cbVäljHatt_SelectedIndexChanged;
            // 
            // panelLagerHattar
            // 
            panelLagerHattar.BackColor = SystemColors.ActiveCaption;
            panelLagerHattar.BorderStyle = BorderStyle.Fixed3D;
            panelLagerHattar.Controls.Add(label12);
            panelLagerHattar.Controls.Add(chbAnpassa);
            panelLagerHattar.Controls.Add(cbVäljHatt);
            panelLagerHattar.Controls.Add(pbReferens);
            panelLagerHattar.Controls.Add(btnLäggtill);
            panelLagerHattar.Controls.Add(lblPris);
            panelLagerHattar.Location = new Point(61, 165);
            panelLagerHattar.Name = "panelLagerHattar";
            panelLagerHattar.Size = new Size(1378, 538);
            panelLagerHattar.TabIndex = 27;
            // 
            // panelSpecHattar
            // 
            panelSpecHattar.BackColor = SystemColors.ActiveCaption;
            panelSpecHattar.BorderStyle = BorderStyle.Fixed3D;
            panelSpecHattar.Controls.Add(btnSpec);
            panelSpecHattar.Controls.Add(label11);
            panelSpecHattar.Location = new Point(61, 751);
            panelSpecHattar.Name = "panelSpecHattar";
            panelSpecHattar.Size = new Size(1378, 518);
            panelSpecHattar.TabIndex = 28;
            // 
            // lvBeställningar
            // 
            lvBeställningar.Columns.AddRange(new ColumnHeader[] { Typ, Modell, Storlek });
            lvBeställningar.Location = new Point(1571, 286);
            lvBeställningar.Name = "lvBeställningar";
            lvBeställningar.Size = new Size(477, 693);
            lvBeställningar.TabIndex = 29;
            lvBeställningar.UseCompatibleStateImageBehavior = false;
            lvBeställningar.View = View.Details;
            // 
            // Typ
            // 
            Typ.Text = "Typ";
            Typ.Width = 100;
            // 
            // Modell
            // 
            Modell.Text = "Modell";
            Modell.Width = 100;
            // 
            // Storlek
            // 
            Storlek.Text = "Storlek";
            Storlek.Width = 100;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1571, 1012);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 32);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2602, 40);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(115, 36);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // LaggTillLagerhattar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2602, 1759);
            Controls.Add(lblTotal);
            Controls.Add(lvBeställningar);
            Controls.Add(panelSpecHattar);
            Controls.Add(panelLagerHattar);
            Controls.Add(btnVisaBeställning);
            Controls.Add(lblNamn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "LaggTillLagerhattar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaggTillLagerhattar";
            Load += LaggTillLagerhattar_Load;
            ((System.ComponentModel.ISupportInitialize)pbReferens).EndInit();
            panelLagerHattar.ResumeLayout(false);
            panelLagerHattar.PerformLayout();
            panelSpecHattar.ResumeLayout(false);
            panelSpecHattar.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Panel panelLagerHattar;
        private Panel panelSpecHattar;
        private ListView lvBeställningar;
        private ColumnHeader Typ;
        private ColumnHeader Modell;
        private ColumnHeader Storlek;
        private Label lblTotal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
    }
}