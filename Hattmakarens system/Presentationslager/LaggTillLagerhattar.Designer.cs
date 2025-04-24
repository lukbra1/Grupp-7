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
            label11 = new Label();
            label12 = new Label();
            cbVäljHatt = new ComboBox();
            panelLagerHattar = new Panel();
            listView2 = new ListView();
            Matrial = new ColumnHeader();
            Antal = new ColumnHeader();
            textBox2 = new TextBox();
            listBox3 = new ListBox();
            label4 = new Label();
            cbStorlek = new ComboBox();
            label3 = new Label();
            button5 = new Button();
            panelSpecHattar = new Panel();
            comboBox4 = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            buttonRefBild = new Button();
            button2 = new Button();
            comboBox3 = new ComboBox();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button6 = new Button();
            lvBeställningar = new ListView();
            Typ = new ColumnHeader();
            Modell = new ColumnHeader();
            Storlek = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            rtxtBesk = new RichTextBox();
            txtEnhet = new TextBox();
            txtFarg = new TextBox();
            txtNamn = new TextBox();
            button4 = new Button();
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
            pbReferens.Location = new Point(26, 117);
            pbReferens.Name = "pbReferens";
            pbReferens.Size = new Size(387, 386);
            pbReferens.SizeMode = PictureBoxSizeMode.Zoom;
            pbReferens.TabIndex = 0;
            pbReferens.TabStop = false;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(65, 285);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(164, 32);
            lblNamn.TabIndex = 5;
            lblNamn.Text = "Studentmössa";
            // 
            // btnLäggtill
            // 
            btnLäggtill.Location = new Point(1191, 456);
            btnLäggtill.Name = "btnLäggtill";
            btnLäggtill.Size = new Size(150, 46);
            btnLäggtill.TabIndex = 10;
            btnLäggtill.Text = "Lägg till";
            btnLäggtill.UseVisualStyleBackColor = true;
            btnLäggtill.Click += btnLäggtill_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(26, 13);
            label11.Name = "label11";
            label11.Size = new Size(330, 54);
            label11.TabIndex = 21;
            label11.Text = "Skapa specialhatt";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(26, 29);
            label12.Name = "label12";
            label12.Size = new Size(369, 54);
            label12.TabIndex = 22;
            label12.Text = "Lägg till hattmodell";
            // 
            // cbVäljHatt
            // 
            cbVäljHatt.FormattingEnabled = true;
            cbVäljHatt.Location = new Point(450, 117);
            cbVäljHatt.Margin = new Padding(5);
            cbVäljHatt.Name = "cbVäljHatt";
            cbVäljHatt.Size = new Size(277, 40);
            cbVäljHatt.TabIndex = 26;
            cbVäljHatt.Text = "Hattmodell";
            cbVäljHatt.SelectedIndexChanged += cbVäljHatt_SelectedIndexChanged;
            // 
            // panelLagerHattar
            // 
            panelLagerHattar.BackColor = SystemColors.ActiveCaption;
            panelLagerHattar.BorderStyle = BorderStyle.Fixed3D;
            panelLagerHattar.Controls.Add(listView2);
            panelLagerHattar.Controls.Add(textBox2);
            panelLagerHattar.Controls.Add(listBox3);
            panelLagerHattar.Controls.Add(label4);
            panelLagerHattar.Controls.Add(cbStorlek);
            panelLagerHattar.Controls.Add(label12);
            panelLagerHattar.Controls.Add(label3);
            panelLagerHattar.Controls.Add(cbVäljHatt);
            panelLagerHattar.Controls.Add(button5);
            panelLagerHattar.Controls.Add(pbReferens);
            panelLagerHattar.Controls.Add(btnLäggtill);
            panelLagerHattar.Location = new Point(37, 82);
            panelLagerHattar.Name = "panelLagerHattar";
            panelLagerHattar.Size = new Size(1379, 538);
            panelLagerHattar.TabIndex = 27;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { Matrial, Antal });
            listView2.Location = new Point(1071, 117);
            listView2.Margin = new Padding(5, 6, 5, 6);
            listView2.Name = "listView2";
            listView2.Size = new Size(272, 327);
            listView2.TabIndex = 32;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // Matrial
            // 
            Matrial.Text = "Matrial";
            Matrial.Width = 100;
            // 
            // Antal
            // 
            Antal.Text = "Antal";
            Antal.Width = 40;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(450, 402);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Antal";
            textBox2.Size = new Size(456, 39);
            textBox2.TabIndex = 48;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(450, 222);
            listBox3.Margin = new Padding(5, 6, 5, 6);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(596, 164);
            listBox3.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1071, 69);
            label4.Name = "label4";
            label4.Size = new Size(202, 32);
            label4.TabIndex = 46;
            label4.Text = "Adderade matrial:";
            // 
            // cbStorlek
            // 
            cbStorlek.FormattingEnabled = true;
            cbStorlek.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            cbStorlek.Location = new Point(756, 117);
            cbStorlek.Name = "cbStorlek";
            cbStorlek.Size = new Size(298, 40);
            cbStorlek.TabIndex = 44;
            cbStorlek.Text = "Storlek";
            cbStorlek.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 182);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 40;
            label3.Text = "Välj material:";
            // 
            // button5
            // 
            button5.Location = new Point(926, 398);
            button5.Name = "button5";
            button5.Size = new Size(120, 46);
            button5.TabIndex = 39;
            button5.Text = "Lägg till";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panelSpecHattar
            // 
            panelSpecHattar.BackColor = SystemColors.ActiveCaption;
            panelSpecHattar.BorderStyle = BorderStyle.Fixed3D;
            panelSpecHattar.Controls.Add(comboBox4);
            panelSpecHattar.Controls.Add(label5);
            panelSpecHattar.Controls.Add(button1);
            panelSpecHattar.Controls.Add(pictureBox1);
            panelSpecHattar.Controls.Add(buttonRefBild);
            panelSpecHattar.Controls.Add(button2);
            panelSpecHattar.Controls.Add(comboBox3);
            panelSpecHattar.Controls.Add(richTextBox1);
            panelSpecHattar.Controls.Add(button3);
            panelSpecHattar.Controls.Add(label11);
            panelSpecHattar.Controls.Add(listView1);
            panelSpecHattar.Controls.Add(textBox1);
            panelSpecHattar.Controls.Add(listBox1);
            panelSpecHattar.Location = new Point(37, 669);
            panelSpecHattar.Name = "panelSpecHattar";
            panelSpecHattar.Size = new Size(1379, 519);
            panelSpecHattar.TabIndex = 28;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            comboBox4.Location = new Point(786, 138);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(259, 40);
            comboBox4.TabIndex = 42;
            comboBox4.Text = "Storlek";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1071, 72);
            label5.Name = "label5";
            label5.Size = new Size(202, 32);
            label5.TabIndex = 41;
            label5.Text = "Adderade matrial:";
            // 
            // button1
            // 
            button1.Location = new Point(280, 434);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(133, 50);
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
            pictureBox1.Location = new Point(26, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // buttonRefBild
            // 
            buttonRefBild.Location = new Point(26, 434);
            buttonRefBild.Margin = new Padding(5, 6, 5, 6);
            buttonRefBild.Name = "buttonRefBild";
            buttonRefBild.Size = new Size(244, 50);
            buttonRefBild.TabIndex = 38;
            buttonRefBild.Text = "Hämta referensbild";
            buttonRefBild.UseVisualStyleBackColor = true;
            buttonRefBild.Click += buttonRefBild_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1191, 434);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(153, 54);
            button2.TabIndex = 36;
            button2.Text = "Lägg till";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.SizeAll;
            comboBox3.FormattingEnabled = true;
            comboBox3.ImeMode = ImeMode.Katakana;
            comboBox3.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            comboBox3.Location = new Point(-765, -898);
            comboBox3.Margin = new Padding(5, 6, 5, 6);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(324, 40);
            comboBox3.TabIndex = 35;
            comboBox3.Text = "Storlek";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(786, 227);
            richTextBox1.Margin = new Padding(5, 6, 5, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(261, 174);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "Kommentar:";
            // 
            // button3
            // 
            button3.Location = new Point(618, 363);
            button3.Margin = new Padding(5, 6, 5, 6);
            button3.Name = "button3";
            button3.Size = new Size(145, 50);
            button3.TabIndex = 29;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(1071, 120);
            listView1.Margin = new Padding(5, 6, 5, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(272, 282);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Matrial";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Antal";
            columnHeader2.Width = 40;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(436, 370);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Antal";
            textBox1.Size = new Size(152, 39);
            textBox1.TabIndex = 28;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(436, 85);
            listBox1.Margin = new Padding(5, 6, 5, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 260);
            listBox1.TabIndex = 22;
            // 
            // button6
            // 
            button6.Location = new Point(247, 451);
            button6.Margin = new Padding(5, 6, 5, 6);
            button6.Name = "button6";
            button6.Size = new Size(284, 50);
            button6.TabIndex = 32;
            button6.Text = "Registrera nytt material";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // lvBeställningar
            // 
            lvBeställningar.BackColor = SystemColors.InactiveCaption;
            lvBeställningar.Columns.AddRange(new ColumnHeader[] { Typ, Modell, Storlek });
            lvBeställningar.FullRowSelect = true;
            lvBeställningar.Location = new Point(1471, 82);
            lvBeställningar.Name = "lvBeställningar";
            lvBeställningar.Size = new Size(553, 474);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1924, 42);
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
            panel1.Location = new Point(1471, 669);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 519);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 242);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 37;
            label1.Text = "Beskrivning";
            // 
            // rtxtBesk
            // 
            rtxtBesk.Location = new Point(36, 278);
            rtxtBesk.Margin = new Padding(5, 6, 5, 6);
            rtxtBesk.Name = "rtxtBesk";
            rtxtBesk.Size = new Size(451, 138);
            rtxtBesk.TabIndex = 37;
            rtxtBesk.Text = "";
            // 
            // txtEnhet
            // 
            txtEnhet.Location = new Point(36, 109);
            txtEnhet.Margin = new Padding(6);
            txtEnhet.Name = "txtEnhet";
            txtEnhet.PlaceholderText = "Enhet";
            txtEnhet.Size = new Size(183, 39);
            txtEnhet.TabIndex = 44;
            // 
            // txtFarg
            // 
            txtFarg.Location = new Point(36, 178);
            txtFarg.Margin = new Padding(6);
            txtFarg.Name = "txtFarg";
            txtFarg.PlaceholderText = "Färg";
            txtFarg.Size = new Size(183, 39);
            txtFarg.TabIndex = 43;
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(36, 42);
            txtNamn.Margin = new Padding(6);
            txtNamn.Name = "txtNamn";
            txtNamn.PlaceholderText = "Namn";
            txtNamn.Size = new Size(183, 39);
            txtNamn.TabIndex = 41;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(1571, 579);
            button4.Name = "button4";
            button4.Size = new Size(343, 56);
            button4.TabIndex = 32;
            button4.Text = "Slutför Beställning";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // LaggTillLagerhattar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1054);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(lvBeställningar);
            Controls.Add(panelSpecHattar);
            Controls.Add(panelLagerHattar);
            Controls.Add(lblNamn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "LaggTillLagerhattar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skapa Beställning";
            FormClosed += LaggTillLagerhattar_FormClosed;
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
        private Label label11;
        private Label label12;
        private ComboBox cbVäljHatt;
        private Panel panelLagerHattar;
        private Panel panelSpecHattar;
        private ListView lvBeställningar;
        private ColumnHeader Typ;
        private ColumnHeader Modell;
        private ColumnHeader Storlek;
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
        private Label label1;
        private Button buttonRefBild;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private Button button5;
        private ComboBox cbStorlek;
        private Label label4;
        private Label label5;
        private ComboBox comboBox4;
        private TextBox textBox2;
        private ListBox listBox3;
        private ListView listView2;
        private ColumnHeader Matrial;
        private ColumnHeader Antal;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button4;
    }
}