namespace Hattmakarens_system.Presentationslager
{
    partial class Beställning
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            Varukorg = new Label();
            cbVäljHatt = new ComboBox();
            chbAnpassa = new CheckBox();
            label12 = new Label();
            label11 = new Label();
            btnSpec = new Button();
            lblPris = new Label();
            btnLäggtill = new Button();
            lblNamn = new Label();
            pbReferens = new PictureBox();
            comboBox3 = new ComboBox();
            textBox3 = new TextBox();
            button6 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            listView1 = new ListView();
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            listBox2 = new ListBox();
            txtExtraMat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbReferens).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 14);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(191, 29);
            button1.TabIndex = 0;
            button1.Text = "Lägg till ny hatt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1026, 583);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 1;
            button2.Text = "Slutför Beställning";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(860, 97);
            listBox1.Margin = new Padding(2, 2, 2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(284, 444);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(886, 587);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Expressleverans";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(974, 548);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // Varukorg
            // 
            Varukorg.AutoSize = true;
            Varukorg.Location = new Point(966, 62);
            Varukorg.Margin = new Padding(2, 0, 2, 0);
            Varukorg.Name = "Varukorg";
            Varukorg.Size = new Size(68, 20);
            Varukorg.TabIndex = 7;
            Varukorg.Text = "Varukorg";
            // 
            // cbVäljHatt
            // 
            cbVäljHatt.FormattingEnabled = true;
            cbVäljHatt.Location = new Point(142, 359);
            cbVäljHatt.Name = "cbVäljHatt";
            cbVäljHatt.Size = new Size(151, 28);
            cbVäljHatt.TabIndex = 35;
            // 
            // chbAnpassa
            // 
            chbAnpassa.AutoSize = true;
            chbAnpassa.Location = new Point(447, 411);
            chbAnpassa.Margin = new Padding(2, 2, 2, 2);
            chbAnpassa.Name = "chbAnpassa";
            chbAnpassa.Size = new Size(86, 24);
            chbAnpassa.TabIndex = 34;
            chbAnpassa.Text = "Anpassa";
            chbAnpassa.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 359);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(101, 20);
            label12.TabIndex = 33;
            label12.Text = "Välj lager hatt";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 69);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 32;
            label11.Text = "Skapa specialhatt";
            // 
            // btnSpec
            // 
            btnSpec.Location = new Point(228, 14);
            btnSpec.Margin = new Padding(2, 2, 2, 2);
            btnSpec.Name = "btnSpec";
            btnSpec.Size = new Size(166, 29);
            btnSpec.TabIndex = 31;
            btnSpec.Text = "Special order";
            btnSpec.UseVisualStyleBackColor = true;
            btnSpec.Click += btnSpec_Click;
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(257, 446);
            lblPris.Margin = new Padding(2, 0, 2, 0);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(49, 20);
            lblPris.TabIndex = 30;
            lblPris.Text = "800 kr";
            // 
            // btnLäggtill
            // 
            btnLäggtill.Location = new Point(730, 559);
            btnLäggtill.Margin = new Padding(2, 2, 2, 2);
            btnLäggtill.Name = "btnLäggtill";
            btnLäggtill.Size = new Size(92, 29);
            btnLäggtill.TabIndex = 29;
            btnLäggtill.Text = "Lägg till";
            btnLäggtill.UseVisualStyleBackColor = true;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(251, 414);
            lblNamn.Margin = new Padding(2, 0, 2, 0);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(102, 20);
            lblNamn.TabIndex = 28;
            lblNamn.Text = "Studentmössa";
            // 
            // pbReferens
            // 
            pbReferens.Image = Properties.Resources.Oktoberhatt;
            pbReferens.Location = new Point(45, 405);
            pbReferens.Margin = new Padding(2, 2, 2, 2);
            pbReferens.Name = "pbReferens";
            pbReferens.Size = new Size(186, 183);
            pbReferens.SizeMode = PictureBoxSizeMode.Zoom;
            pbReferens.TabIndex = 27;
            pbReferens.TabStop = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            comboBox3.Location = new Point(420, 214);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(209, 28);
            comboBox3.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(692, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 27);
            textBox3.TabIndex = 45;
            textBox3.Text = "Referensbild";
            // 
            // button6
            // 
            button6.Location = new Point(5, 486);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(175, 31);
            button6.TabIndex = 44;
            button6.Text = "Registrera nytt material";
            button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(738, 278);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(85, 31);
            button3.TabIndex = 43;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(398, 122);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(270, 77);
            richTextBox1.TabIndex = 42;
            richTextBox1.Text = "Skriv en kommentar";
            // 
            // listView1
            // 
            listView1.Location = new Point(10, 214);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(273, 96);
            listView1.TabIndex = 41;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 27);
            textBox1.TabIndex = 40;
            textBox1.Text = "Antal";
            // 
            // button4
            // 
            button4.Location = new Point(294, 246);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(83, 31);
            button4.TabIndex = 39;
            button4.Text = "Lägg till";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(198, 114);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(83, 25);
            button5.TabIndex = 38;
            button5.Text = "Sök";
            button5.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(9, 144);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(274, 64);
            listBox2.TabIndex = 37;
            // 
            // txtExtraMat
            // 
            txtExtraMat.Location = new Point(10, 113);
            txtExtraMat.Name = "txtExtraMat";
            txtExtraMat.Size = new Size(177, 27);
            txtExtraMat.TabIndex = 36;
            txtExtraMat.Text = "Sök material";
            // 
            // Beställning
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 631);
            Controls.Add(comboBox3);
            Controls.Add(textBox3);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(txtExtraMat);
            Controls.Add(cbVäljHatt);
            Controls.Add(chbAnpassa);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnSpec);
            Controls.Add(lblPris);
            Controls.Add(btnLäggtill);
            Controls.Add(lblNamn);
            Controls.Add(pbReferens);
            Controls.Add(Varukorg);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Beställning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beställning";
            ((System.ComponentModel.ISupportInitialize)pbReferens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private CheckBox checkBox1;
        private Label Varukorg;
        private Label label2;
        private ComboBox cbVäljHatt;
        private CheckBox chbAnpassa;
        private Label label12;
        private Label label11;
        private Button btnSpec;
        private Label lblPris;
        private Button btnLäggtill;
        private Label lblNamn;
        private PictureBox pbReferens;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private Button button6;
        private Button button3;
        private RichTextBox richTextBox1;
        private ListView listView1;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private ListBox listBox2;
        private TextBox txtExtraMat;
    }
}