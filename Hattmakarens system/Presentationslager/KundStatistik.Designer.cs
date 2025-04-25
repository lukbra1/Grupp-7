namespace Hattmakarens_system.Presentationslager
{
    partial class KundStatistik
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
            listBox1 = new ListBox();
            label1 = new Label();
            lblSlutdatum = new Label();
            lblStartDate = new Label();
            btnVisa = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            lblFel2 = new Label();
            lblFel1 = new Label();
            listBox2 = new ListBox();
            button2 = new Button();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(547, 161);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(423, 420);
            listBox1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(547, 91);
            label1.Name = "label1";
            label1.Size = new Size(275, 32);
            label1.TabIndex = 18;
            label1.Text = "Se statesik för vald kund";
            label1.Click += label1_Click;
            // 
            // lblSlutdatum
            // 
            lblSlutdatum.AutoSize = true;
            lblSlutdatum.Location = new Point(57, 468);
            lblSlutdatum.Name = "lblSlutdatum";
            lblSlutdatum.Size = new Size(124, 32);
            lblSlutdatum.TabIndex = 16;
            lblSlutdatum.Text = "Slutdatum";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(57, 343);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(131, 32);
            lblStartDate.TabIndex = 15;
            lblStartDate.Text = "Startdatum";
            // 
            // btnVisa
            // 
            btnVisa.Location = new Point(174, 589);
            btnVisa.Name = "btnVisa";
            btnVisa.Size = new Size(150, 46);
            btnVisa.TabIndex = 13;
            btnVisa.Text = "Visa Statestik";
            btnVisa.UseVisualStyleBackColor = true;
            btnVisa.Click += btnVisa_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(57, 503);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(400, 39);
            dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(57, 378);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 11;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1031, 40);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(115, 36);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // lblFel2
            // 
            lblFel2.AutoSize = true;
            lblFel2.Location = new Point(445, 328);
            lblFel2.Margin = new Padding(6, 0, 6, 0);
            lblFel2.Name = "lblFel2";
            lblFel2.Size = new Size(0, 32);
            lblFel2.TabIndex = 60;
            // 
            // lblFel1
            // 
            lblFel1.AutoSize = true;
            lblFel1.Location = new Point(457, 295);
            lblFel1.Margin = new Padding(6, 0, 6, 0);
            lblFel1.Name = "lblFel1";
            lblFel1.Size = new Size(0, 32);
            lblFel1.TabIndex = 59;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(57, 161);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(401, 164);
            listBox2.TabIndex = 58;
            // 
            // button2
            // 
            button2.Location = new Point(382, 84);
            button2.Name = "button2";
            button2.Size = new Size(88, 46);
            button2.TabIndex = 57;
            button2.Text = "Sök";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 88);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Sök på kundens förnamn";
            textBox1.Size = new Size(306, 39);
            textBox1.TabIndex = 56;
            // 
            // KundStatistik
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 699);
            Controls.Add(lblFel2);
            Controls.Add(lblFel1);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(lblSlutdatum);
            Controls.Add(lblStartDate);
            Controls.Add(btnVisa);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            Name = "KundStatistik";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KundStatistik";
            Load += KundStatistik_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label lblSlutdatum;
        private Label lblStartDate;
        private Button btnVisa;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
        private Label lblFel2;
        private Label lblFel1;
        private ListBox listBox2;
        private Button button2;
        private TextBox textBox1;
    }
}