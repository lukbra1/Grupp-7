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
            button1.Location = new Point(28, 22);
            button1.Name = "button1";
            button1.Size = new Size(310, 46);
            button1.TabIndex = 0;
            button1.Text = "Lägg till ny hatt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1667, 933);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Slutför Beställning";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(1397, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(459, 708);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1439, 939);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(212, 36);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Expressleverans";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1582, 876);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 6;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // Varukorg
            // 
            Varukorg.AutoSize = true;
            Varukorg.Location = new Point(1570, 99);
            Varukorg.Name = "Varukorg";
            Varukorg.Size = new Size(109, 32);
            Varukorg.TabIndex = 7;
            Varukorg.Text = "Varukorg";
            // 
            // cbVäljHatt
            // 
            cbVäljHatt.FormattingEnabled = true;
            cbVäljHatt.Location = new Point(230, 574);
            cbVäljHatt.Margin = new Padding(5);
            cbVäljHatt.Name = "cbVäljHatt";
            cbVäljHatt.Size = new Size(243, 40);
            cbVäljHatt.TabIndex = 35;
            // 
            // chbAnpassa
            // 
            chbAnpassa.AutoSize = true;
            chbAnpassa.Location = new Point(726, 658);
            chbAnpassa.Name = "chbAnpassa";
            chbAnpassa.Size = new Size(133, 36);
            chbAnpassa.TabIndex = 34;
            chbAnpassa.Text = "Anpassa";
            chbAnpassa.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 574);
            label12.Name = "label12";
            label12.Size = new Size(160, 32);
            label12.TabIndex = 33;
            label12.Text = "Välj lager hatt";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 110);
            label11.Name = "label11";
            label11.Size = new Size(198, 32);
            label11.TabIndex = 32;
            label11.Text = "Skapa specialhatt";
            // 
            // btnSpec
            // 
            btnSpec.Location = new Point(371, 22);
            btnSpec.Name = "btnSpec";
            btnSpec.Size = new Size(270, 46);
            btnSpec.TabIndex = 31;
            btnSpec.Text = "Special order";
            btnSpec.UseVisualStyleBackColor = true;
            btnSpec.Click += btnSpec_Click;
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(417, 713);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(80, 32);
            lblPris.TabIndex = 30;
            lblPris.Text = "800 kr";
            // 
            // btnLäggtill
            // 
            btnLäggtill.Location = new Point(1187, 895);
            btnLäggtill.Name = "btnLäggtill";
            btnLäggtill.Size = new Size(150, 46);
            btnLäggtill.TabIndex = 29;
            btnLäggtill.Text = "Lägg till";
            btnLäggtill.UseVisualStyleBackColor = true;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(408, 662);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(164, 32);
            lblNamn.TabIndex = 28;
            lblNamn.Text = "Studentmössa";
            // 
            // pbReferens
            // 
            pbReferens.Image = Properties.Resources.Oktoberhatt;
            pbReferens.Location = new Point(73, 648);
            pbReferens.Name = "pbReferens";
            pbReferens.Size = new Size(302, 293);
            pbReferens.SizeMode = PictureBoxSizeMode.Zoom;
            pbReferens.TabIndex = 27;
            pbReferens.TabStop = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            comboBox3.Location = new Point(683, 343);
            comboBox3.Margin = new Padding(5, 6, 5, 6);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(337, 40);
            comboBox3.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1125, 231);
            textBox3.Margin = new Padding(5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 39);
            textBox3.TabIndex = 45;
            textBox3.Text = "Referensbild";
            // 
            // button6
            // 
            button6.Location = new Point(8, 777);
            button6.Margin = new Padding(5, 6, 5, 6);
            button6.Name = "button6";
            button6.Size = new Size(284, 50);
            button6.TabIndex = 44;
            button6.Text = "Registrera nytt material";
            button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1199, 445);
            button3.Margin = new Padding(5, 6, 5, 6);
            button3.Name = "button3";
            button3.Size = new Size(138, 50);
            button3.TabIndex = 43;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(646, 195);
            richTextBox1.Margin = new Padding(5, 6, 5, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(437, 121);
            richTextBox1.TabIndex = 42;
            richTextBox1.Text = "Skriv en kommentar";
            // 
            // listView1
            // 
            listView1.Location = new Point(16, 343);
            listView1.Margin = new Padding(5, 6, 5, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(441, 152);
            listView1.TabIndex = 41;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(480, 343);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 39);
            textBox1.TabIndex = 40;
            textBox1.Text = "Antal";
            // 
            // button4
            // 
            button4.Location = new Point(477, 393);
            button4.Margin = new Padding(5, 6, 5, 6);
            button4.Name = "button4";
            button4.Size = new Size(135, 50);
            button4.TabIndex = 39;
            button4.Text = "Lägg till";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(322, 182);
            button5.Margin = new Padding(5, 6, 5, 6);
            button5.Name = "button5";
            button5.Size = new Size(135, 40);
            button5.TabIndex = 38;
            button5.Text = "Sök";
            button5.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(14, 231);
            listBox2.Margin = new Padding(5, 6, 5, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(443, 100);
            listBox2.TabIndex = 37;
            // 
            // txtExtraMat
            // 
            txtExtraMat.Location = new Point(16, 181);
            txtExtraMat.Margin = new Padding(5);
            txtExtraMat.Name = "txtExtraMat";
            txtExtraMat.Size = new Size(285, 39);
            txtExtraMat.TabIndex = 36;
            txtExtraMat.Text = "Sök material";
            // 
            // Beställning
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
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
            Name = "Beställning";
            Text = "Beställning";
            WindowState = FormWindowState.Maximized;
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