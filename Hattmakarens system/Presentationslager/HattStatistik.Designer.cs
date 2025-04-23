namespace Hattmakarens_system.Presentationslager
{
    partial class HattStatistik
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
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnVisa = new Button();
            lblVälj = new Label();
            lblStartDate = new Label();
            lblSlutdatum = new Label();
            menuStrip1 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 139);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(36, 213);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(36, 291);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(248, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // btnVisa
            // 
            btnVisa.Location = new Point(108, 345);
            btnVisa.Margin = new Padding(2);
            btnVisa.Name = "btnVisa";
            btnVisa.Size = new Size(92, 29);
            btnVisa.TabIndex = 3;
            btnVisa.Text = "Visa Statestik";
            btnVisa.UseVisualStyleBackColor = true;
            btnVisa.Click += btnVisa_Click;
            // 
            // lblVälj
            // 
            lblVälj.AutoSize = true;
            lblVälj.Location = new Point(36, 118);
            lblVälj.Margin = new Padding(2, 0, 2, 0);
            lblVälj.Name = "lblVälj";
            lblVälj.Size = new Size(85, 20);
            lblVälj.TabIndex = 4;
            lblVälj.Text = "Hattmodell";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(36, 191);
            lblStartDate.Margin = new Padding(2, 0, 2, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(83, 20);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Startdatum";
            // 
            // lblSlutdatum
            // 
            lblSlutdatum.AutoSize = true;
            lblSlutdatum.Location = new Point(36, 269);
            lblSlutdatum.Margin = new Padding(2, 0, 2, 0);
            lblSlutdatum.Name = "lblSlutdatum";
            lblSlutdatum.Size = new Size(77, 20);
            lblSlutdatum.TabIndex = 6;
            lblSlutdatum.Text = "Slutdatum";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(833, 26);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(75, 24);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 8;
            label1.Text = "Se statisik för vald hatt";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(328, 118);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(262, 264);
            listBox1.TabIndex = 9;
            // 
            // HattStatistik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 518);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(lblSlutdatum);
            Controls.Add(lblStartDate);
            Controls.Add(lblVälj);
            Controls.Add(btnVisa);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "HattStatistik";
            Text = "Hatt statistik";
            FormClosed += HattStatistik_FormClosed;
            Load += HattStatestik_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnVisa;
        private Label lblVälj;
        private Label lblStartDate;
        private Label lblSlutdatum;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
        private Label label1;
        private ListBox listBox1;
    }
}