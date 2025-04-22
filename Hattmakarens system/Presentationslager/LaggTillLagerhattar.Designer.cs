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
            label11 = new Label();
            label12 = new Label();
            btnVisaBeställning = new Button();
            chbAnpassa = new CheckBox();
            cbVäljHatt = new ComboBox();
            panelLagerHattar = new Panel();
            panelSpecHattar = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            buttonRefBild = new Button();
            label2 = new Label();
            button2 = new Button();
            comboBox3 = new ComboBox();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            listBox1 = new ListBox();
            button6 = new Button();
            lvBeställningar = new ListView();
            Typ = new ColumnHeader();
            Modell = new ColumnHeader();
            Storlek = new ColumnHeader();
            lblTotal = new Label();
            menuStrip1 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            rtxtBesk = new RichTextBox();
            txtEnhet = new TextBox();
            txtFarg = new TextBox();
            txtNamn = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbReferens).BeginInit();
            panelLagerHattar.SuspendLayout();
            panelSpecHattar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbReferens
            // 
            pbReferens.Image = Properties.Resources.Oktoberhatt;
            pbReferens.Location = new Point(3, 66);
            pbReferens.Margin = new Padding(2);
            pbReferens.Name = "pbReferens";
            pbReferens.Size = new Size(138, 138);
            pbReferens.SizeMode = PictureBoxSizeMode.Zoom;
            pbReferens.TabIndex = 0;
            pbReferens.TabStop = false;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(55, 230);
            lblNamn.Margin = new Padding(2, 0, 2, 0);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(102, 20);
            lblNamn.TabIndex = 5;
            lblNamn.Text = "Studentmössa";
            // 
            // btnLäggtill
            // 
            btnLäggtill.Location = new Point(20, 276);
            btnLäggtill.Margin = new Padding(2);
            btnLäggtill.Name = "btnLäggtill";
            btnLäggtill.Size = new Size(92, 29);
            btnLäggtill.TabIndex = 10;
            btnLäggtill.Text = "Lägg till";
            btnLäggtill.UseVisualStyleBackColor = true;
            btnLäggtill.Click += btnLäggtill_Click;
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(35, 214);
            lblPris.Margin = new Padding(2, 0, 2, 0);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(49, 20);
            lblPris.TabIndex = 14;
            lblPris.Text = "800 kr";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 14);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 21;
            label11.Text = "Skapa specialhatt";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(2, 7);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(101, 20);
            label12.TabIndex = 22;
            label12.Text = "Välj lager hatt";
            // 
            // btnVisaBeställning
            // 
            btnVisaBeställning.Location = new Point(1108, 839);
            btnVisaBeställning.Margin = new Padding(2);
            btnVisaBeställning.Name = "btnVisaBeställning";
            btnVisaBeställning.Size = new Size(181, 29);
            btnVisaBeställning.TabIndex = 23;
            btnVisaBeställning.Text = "Visa beställning";
            btnVisaBeställning.UseVisualStyleBackColor = true;
            btnVisaBeställning.Click += btnVisaBeställning_Click;
            // 
            // chbAnpassa
            // 
            chbAnpassa.AutoSize = true;
            chbAnpassa.Location = new Point(20, 242);
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
            cbVäljHatt.Location = new Point(3, 30);
            cbVäljHatt.Name = "cbVäljHatt";
            cbVäljHatt.Size = new Size(151, 28);
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
            panelLagerHattar.Location = new Point(38, 103);
            panelLagerHattar.Margin = new Padding(2);
            panelLagerHattar.Name = "panelLagerHattar";
            panelLagerHattar.Size = new Size(850, 338);
            panelLagerHattar.TabIndex = 27;
            panelLagerHattar.Paint += panelLagerHattar_Paint;
            // 
            // panelSpecHattar
            // 
            panelSpecHattar.BackColor = SystemColors.ActiveCaption;
            panelSpecHattar.BorderStyle = BorderStyle.Fixed3D;
            panelSpecHattar.Controls.Add(button1);
            panelSpecHattar.Controls.Add(pictureBox1);
            panelSpecHattar.Controls.Add(buttonRefBild);
            panelSpecHattar.Controls.Add(label2);
            panelSpecHattar.Controls.Add(button2);
            panelSpecHattar.Controls.Add(comboBox3);
            panelSpecHattar.Controls.Add(richTextBox1);
            panelSpecHattar.Controls.Add(button3);
            panelSpecHattar.Controls.Add(textBox1);
            panelSpecHattar.Controls.Add(listView1);
            panelSpecHattar.Controls.Add(listBox1);
            panelSpecHattar.Controls.Add(label11);
            panelSpecHattar.Location = new Point(38, 470);
            panelSpecHattar.Margin = new Padding(2);
            panelSpecHattar.Name = "panelSpecHattar";
            panelSpecHattar.Size = new Size(850, 326);
            panelSpecHattar.TabIndex = 28;
            panelSpecHattar.Paint += panelSpecHattar_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(766, 203);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(61, 30);
            button1.TabIndex = 40;
            button1.Text = "Ta bort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Referens;
            pictureBox1.Location = new Point(617, 38);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // buttonRefBild
            // 
            buttonRefBild.Location = new Point(617, 202);
            buttonRefBild.Margin = new Padding(3, 4, 3, 4);
            buttonRefBild.Name = "buttonRefBild";
            buttonRefBild.Size = new Size(141, 31);
            buttonRefBild.TabIndex = 38;
            buttonRefBild.Text = "Hämta referensbild";
            buttonRefBild.UseVisualStyleBackColor = true;
            buttonRefBild.Click += buttonRefBild_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 37;
            label2.Text = "Kommentar";
            // 
            // button2
            // 
            button2.Location = new Point(698, 271);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(129, 34);
            button2.TabIndex = 36;
            button2.Text = "Lägg till Orderrad";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.SizeAll;
            comboBox3.FormattingEnabled = true;
            comboBox3.ImeMode = ImeMode.Katakana;
            comboBox3.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            comboBox3.Location = new Point(391, 206);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(130, 28);
            comboBox3.TabIndex = 35;
            comboBox3.Text = "Storlek";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(391, 38);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(210, 156);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(302, 110);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 29;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 78);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Antal";
            textBox1.Size = new Size(83, 27);
            textBox1.TabIndex = 28;
            // 
            // listView1
            // 
            listView1.Location = new Point(16, 151);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(281, 119);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(16, 38);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(281, 104);
            listBox1.TabIndex = 22;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Location = new Point(152, 282);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(175, 31);
            button6.TabIndex = 32;
            button6.Text = "Registrera nytt material";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // lvBeställningar
            // 
            lvBeställningar.Columns.AddRange(new ColumnHeader[] { Typ, Modell, Storlek });
            lvBeställningar.FullRowSelect = true;
            lvBeställningar.Location = new Point(920, 103);
            lvBeställningar.Margin = new Padding(2);
            lvBeställningar.Name = "lvBeställningar";
            lvBeställningar.Size = new Size(342, 298);
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
            lblTotal.Location = new Point(920, 420);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(1362, 28);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(75, 24);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rtxtBesk);
            panel1.Controls.Add(txtEnhet);
            panel1.Controls.Add(txtFarg);
            panel1.Controls.Add(txtNamn);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(920, 470);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 326);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 150);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 37;
            label1.Text = "Beskrivning";
            // 
            // rtxtBesk
            // 
            rtxtBesk.Location = new Point(22, 174);
            rtxtBesk.Margin = new Padding(3, 4, 3, 4);
            rtxtBesk.Name = "rtxtBesk";
            rtxtBesk.Size = new Size(279, 88);
            rtxtBesk.TabIndex = 37;
            rtxtBesk.Text = "";
            // 
            // txtEnhet
            // 
            txtEnhet.Location = new Point(22, 67);
            txtEnhet.Margin = new Padding(4);
            txtEnhet.Name = "txtEnhet";
            txtEnhet.PlaceholderText = "Enhet";
            txtEnhet.Size = new Size(114, 27);
            txtEnhet.TabIndex = 44;
            // 
            // txtFarg
            // 
            txtFarg.Location = new Point(22, 111);
            txtFarg.Margin = new Padding(4);
            txtFarg.Name = "txtFarg";
            txtFarg.PlaceholderText = "Färg";
            txtFarg.Size = new Size(114, 27);
            txtFarg.TabIndex = 43;
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(22, 26);
            txtNamn.Margin = new Padding(4);
            txtNamn.Name = "txtNamn";
            txtNamn.PlaceholderText = "Namn";
            txtNamn.Size = new Size(114, 27);
            txtNamn.TabIndex = 41;
            // 
            // LaggTillLagerhattar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 840);
            Controls.Add(panel1);
            Controls.Add(lblTotal);
            Controls.Add(lvBeställningar);
            Controls.Add(panelSpecHattar);
            Controls.Add(panelLagerHattar);
            Controls.Add(btnVisaBeställning);
            Controls.Add(lblNamn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "LaggTillLagerhattar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaggTillLagerhattar";
            Load += LaggTillLagerhattar_Load;
            ((System.ComponentModel.ISupportInitialize)pbReferens).EndInit();
            panelLagerHattar.ResumeLayout(false);
            panelLagerHattar.PerformLayout();
            panelSpecHattar.ResumeLayout(false);
            panelSpecHattar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbReferens;
        private Label lblNamn;
        private Button btnLäggtill;
        private Label lblPris;
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
        private ListBox listBox1;
        private ListView listView1;
        private TextBox textBox1;
        private Button button3;
        private Button button6;
        private RichTextBox richTextBox1;
        private ComboBox comboBox3;
        private Button button2;
        private Panel panel1;
        private TextBox txtNamn;
        private TextBox txtEnhet;
        private TextBox txtFarg;
        private RichTextBox rtxtBesk;
        private Label label2;
        private Label label1;
        private Button buttonRefBild;
        private PictureBox pictureBox1;
        private Button button1;
    }
}