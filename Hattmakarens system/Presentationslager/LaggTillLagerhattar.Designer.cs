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
            button2 = new Button();
            textBox3 = new TextBox();
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
            rtxtBesk = new RichTextBox();
            txtEnhet = new TextBox();
            txtFarg = new TextBox();
            txtNamn = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbReferens).BeginInit();
            panelLagerHattar.SuspendLayout();
            panelSpecHattar.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbReferens
            // 
            pbReferens.Image = Properties.Resources.Oktoberhatt;
            pbReferens.Location = new Point(4, 83);
            pbReferens.Margin = new Padding(2);
            pbReferens.Name = "pbReferens";
            pbReferens.Size = new Size(172, 173);
            pbReferens.SizeMode = PictureBoxSizeMode.Zoom;
            pbReferens.TabIndex = 0;
            pbReferens.TabStop = false;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(69, 288);
            lblNamn.Margin = new Padding(2, 0, 2, 0);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(125, 25);
            lblNamn.TabIndex = 5;
            lblNamn.Text = "Studentmössa";
            // 
            // btnLäggtill
            // 
            btnLäggtill.Location = new Point(25, 345);
            btnLäggtill.Margin = new Padding(2);
            btnLäggtill.Name = "btnLäggtill";
            btnLäggtill.Size = new Size(115, 36);
            btnLäggtill.TabIndex = 10;
            btnLäggtill.Text = "Lägg till";
            btnLäggtill.UseVisualStyleBackColor = true;
            btnLäggtill.Click += btnLäggtill_Click;
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(44, 267);
            lblPris.Margin = new Padding(2, 0, 2, 0);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(62, 25);
            lblPris.TabIndex = 14;
            lblPris.Text = "800 kr";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 17);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(149, 25);
            label11.TabIndex = 21;
            label11.Text = "Skapa specialhatt";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(2, 9);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(119, 25);
            label12.TabIndex = 22;
            label12.Text = "Välj lager hatt";
            // 
            // btnVisaBeställning
            // 
            btnVisaBeställning.Location = new Point(1385, 1049);
            btnVisaBeställning.Margin = new Padding(2);
            btnVisaBeställning.Name = "btnVisaBeställning";
            btnVisaBeställning.Size = new Size(226, 36);
            btnVisaBeställning.TabIndex = 23;
            btnVisaBeställning.Text = "Visa beställning";
            btnVisaBeställning.UseVisualStyleBackColor = true;
            btnVisaBeställning.Click += btnVisaBeställning_Click;
            // 
            // chbAnpassa
            // 
            chbAnpassa.AutoSize = true;
            chbAnpassa.Location = new Point(25, 302);
            chbAnpassa.Margin = new Padding(2);
            chbAnpassa.Name = "chbAnpassa";
            chbAnpassa.Size = new Size(105, 29);
            chbAnpassa.TabIndex = 25;
            chbAnpassa.Text = "Anpassa";
            chbAnpassa.UseVisualStyleBackColor = true;
            // 
            // cbVäljHatt
            // 
            cbVäljHatt.FormattingEnabled = true;
            cbVäljHatt.Location = new Point(4, 38);
            cbVäljHatt.Margin = new Padding(4);
            cbVäljHatt.Name = "cbVäljHatt";
            cbVäljHatt.Size = new Size(188, 33);
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
            panelLagerHattar.Location = new Point(47, 129);
            panelLagerHattar.Margin = new Padding(2);
            panelLagerHattar.Name = "panelLagerHattar";
            panelLagerHattar.Size = new Size(1061, 421);
            panelLagerHattar.TabIndex = 27;
            panelLagerHattar.Paint += panelLagerHattar_Paint;
            // 
            // panelSpecHattar
            // 
            panelSpecHattar.BackColor = SystemColors.ActiveCaption;
            panelSpecHattar.BorderStyle = BorderStyle.Fixed3D;
            panelSpecHattar.Controls.Add(button2);
            panelSpecHattar.Controls.Add(textBox3);
            panelSpecHattar.Controls.Add(comboBox3);
            panelSpecHattar.Controls.Add(richTextBox1);
            panelSpecHattar.Controls.Add(button3);
            panelSpecHattar.Controls.Add(textBox1);
            panelSpecHattar.Controls.Add(listView1);
            panelSpecHattar.Controls.Add(listBox1);
            panelSpecHattar.Controls.Add(label11);
            panelSpecHattar.Location = new Point(47, 587);
            panelSpecHattar.Margin = new Padding(2);
            panelSpecHattar.Name = "panelSpecHattar";
            panelSpecHattar.Size = new Size(1061, 406);
            panelSpecHattar.TabIndex = 28;
            panelSpecHattar.Paint += panelSpecHattar_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(854, 251);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(161, 42);
            button2.TabIndex = 36;
            button2.Text = "Lägg till Orderrad";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(672, 257);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 31);
            textBox3.TabIndex = 34;
            textBox3.Text = "Referensbild";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            comboBox3.Location = new Point(489, 257);
            comboBox3.Margin = new Padding(4, 5, 4, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(161, 33);
            comboBox3.TabIndex = 35;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(489, 47);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(526, 194);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "Skriv en kommentar";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(378, 137);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(103, 39);
            button3.TabIndex = 29;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(378, 97);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 31);
            textBox1.TabIndex = 28;
            textBox1.Text = "Antal";
            // 
            // listView1
            // 
            listView1.Location = new Point(20, 189);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(350, 148);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(20, 47);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(350, 129);
            listBox1.TabIndex = 22;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Location = new Point(190, 353);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(219, 39);
            button6.TabIndex = 32;
            button6.Text = "Registrera nytt material";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // lvBeställningar
            // 
            lvBeställningar.Columns.AddRange(new ColumnHeader[] { Typ, Modell, Storlek });
            lvBeställningar.FullRowSelect = true;
            lvBeställningar.Location = new Point(1150, 129);
            lvBeställningar.Margin = new Padding(2);
            lvBeställningar.Name = "lvBeställningar";
            lvBeställningar.Size = new Size(426, 372);
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
            lblTotal.Location = new Point(1150, 525);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 25);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1703, 33);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(87, 29);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(rtxtBesk);
            panel1.Controls.Add(txtEnhet);
            panel1.Controls.Add(txtFarg);
            panel1.Controls.Add(txtNamn);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(1150, 587);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 406);
            panel1.TabIndex = 27;
            // 
            // rtxtBesk
            // 
            rtxtBesk.Location = new Point(28, 203);
            rtxtBesk.Margin = new Padding(4, 5, 4, 5);
            rtxtBesk.Name = "rtxtBesk";
            rtxtBesk.Size = new Size(348, 123);
            rtxtBesk.TabIndex = 37;
            rtxtBesk.Text = "Skriv en beskrivning";
            // 
            // txtEnhet
            // 
            txtEnhet.Location = new Point(28, 84);
            txtEnhet.Margin = new Padding(5);
            txtEnhet.Name = "txtEnhet";
            txtEnhet.Size = new Size(142, 31);
            txtEnhet.TabIndex = 44;
            txtEnhet.Text = "Enhet";
            // 
            // txtFarg
            // 
            txtFarg.Location = new Point(28, 139);
            txtFarg.Margin = new Padding(5);
            txtFarg.Name = "txtFarg";
            txtFarg.Size = new Size(142, 31);
            txtFarg.TabIndex = 43;
            txtFarg.Text = "Färg";
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(28, 33);
            txtNamn.Margin = new Padding(5);
            txtNamn.Name = "txtNamn";
            txtNamn.Size = new Size(142, 31);
            txtNamn.TabIndex = 41;
            txtNamn.Text = "Namn";
            // 
            // LaggTillLagerhattar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1703, 1050);
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
        private TextBox textBox3;
        private Button button2;
        private Panel panel1;
        private TextBox txtNamn;
        private TextBox txtEnhet;
        private TextBox txtFarg;
        private RichTextBox rtxtBesk;
    }
}