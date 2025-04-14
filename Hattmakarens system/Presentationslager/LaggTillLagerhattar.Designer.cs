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
            label1 = new Label();
            btnLäggtill = new Button();
            label6 = new Label();
            btnSpec = new Button();
            label11 = new Label();
            label12 = new Label();
            button7 = new Button();
            chbAnpassa = new CheckBox();
            cbVäljHatt = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbReferens).BeginInit();
            SuspendLayout();
            // 
            // pbReferens
            // 
            pbReferens.Image = Properties.Resources.Oktoberhatt;
            pbReferens.Location = new Point(44, 139);
            pbReferens.Margin = new Padding(2);
            pbReferens.Name = "pbReferens";
            pbReferens.Size = new Size(186, 183);
            pbReferens.SizeMode = PictureBoxSizeMode.Zoom;
            pbReferens.TabIndex = 0;
            pbReferens.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 330);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 5;
            label1.Text = "Studentmössa";
            // 
            // btnLäggtill
            // 
            btnLäggtill.Location = new Point(81, 451);
            btnLäggtill.Margin = new Padding(2);
            btnLäggtill.Name = "btnLäggtill";
            btnLäggtill.Size = new Size(92, 29);
            btnLäggtill.TabIndex = 10;
            btnLäggtill.Text = "Lägg till";
            btnLäggtill.UseVisualStyleBackColor = true;
            btnLäggtill.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 358);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 14;
            label6.Text = "800 kr";
            // 
            // btnSpec
            // 
            btnSpec.Location = new Point(186, 57);
            btnSpec.Margin = new Padding(2);
            btnSpec.Name = "btnSpec";
            btnSpec.Size = new Size(166, 29);
            btnSpec.TabIndex = 20;
            btnSpec.Text = "Special order";
            btnSpec.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 57);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 21;
            label11.Text = "Skapa specialhatt";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(44, 101);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(101, 20);
            label12.TabIndex = 22;
            label12.Text = "Välj lager hatt";
            // 
            // button7
            // 
            button7.Location = new Point(820, 39);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(181, 29);
            button7.TabIndex = 23;
            button7.Text = "Visa beställning";
            button7.UseVisualStyleBackColor = true;
            // 
            // chbAnpassa
            // 
            chbAnpassa.AutoSize = true;
            chbAnpassa.Location = new Point(91, 399);
            chbAnpassa.Margin = new Padding(2);
            chbAnpassa.Name = "chbAnpassa";
            chbAnpassa.Size = new Size(86, 24);
            chbAnpassa.TabIndex = 25;
            chbAnpassa.Text = "Anpassa";
            chbAnpassa.UseVisualStyleBackColor = true;
            // 
            // cbVäljHatt
            // 
            cbVäljHatt.FormattingEnabled = true;
            cbVäljHatt.Location = new Point(166, 98);
            cbVäljHatt.Name = "cbVäljHatt";
            cbVäljHatt.Size = new Size(151, 28);
            cbVäljHatt.TabIndex = 26;
            cbVäljHatt.SelectedIndexChanged += cbVäljHatt_SelectedIndexChanged;
            // 
            // LaggTillLagerhattar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 524);
            Controls.Add(cbVäljHatt);
            Controls.Add(chbAnpassa);
            Controls.Add(button7);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnSpec);
            Controls.Add(label6);
            Controls.Add(btnLäggtill);
            Controls.Add(label1);
            Controls.Add(pbReferens);
            Margin = new Padding(2);
            Name = "LaggTillLagerhattar";
            Text = "LaggTillLagerhattar";
            Load += LaggTillLagerhattar_Load;
            ((System.ComponentModel.ISupportInitialize)pbReferens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbReferens;
        private Label label1;
        private Button btnLäggtill;
        private Label label6;
        private Button btnSpec;
        private Label label11;
        private Label label12;
        private Button button7;
        private CheckBox chbAnpassa;
        private ComboBox cbVäljHatt;
    }
}