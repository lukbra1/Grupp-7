namespace Hattmakarens_system
{
    partial class Specialbeställning
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
            txtExtraMat = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button6 = new Button();
            textBox3 = new TextBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // txtExtraMat
            // 
            txtExtraMat.Location = new Point(19, 71);
            txtExtraMat.Name = "txtExtraMat";
            txtExtraMat.Size = new Size(386, 27);
            txtExtraMat.TabIndex = 6;
            txtExtraMat.Text = "Sök material";
            txtExtraMat.TextChanged += txtExtraMat_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(19, 115);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(386, 104);
            listBox1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(413, 71);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(83, 31);
            button1.TabIndex = 20;
            button1.Text = "Sök";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(413, 189);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(83, 31);
            button3.TabIndex = 22;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(413, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 27);
            textBox1.TabIndex = 23;
            textBox1.Text = "Antal";
            // 
            // listView1
            // 
            listView1.Location = new Point(19, 228);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(386, 193);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(531, 72);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(411, 351);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "Skriv en kommentar";
            // 
            // button2
            // 
            button2.Location = new Point(961, 189);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(209, 31);
            button2.TabIndex = 28;
            button2.Text = "Lägg till Orderrad";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(14, 444);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(175, 31);
            button6.TabIndex = 31;
            button6.Text = "Registrera nytt material";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(961, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 27);
            textBox3.TabIndex = 33;
            textBox3.Text = "Referensbild";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            comboBox3.Location = new Point(961, 72);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(209, 28);
            comboBox3.TabIndex = 34;
            // 
            // Specialbeställning
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 631);
            Controls.Add(comboBox3);
            Controls.Add(textBox3);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(txtExtraMat);
            Name = "Specialbeställning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Specialbeställning";
            Load += Specialbeställning_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFärg;
        private TextBox txtTyg;
        private TextBox txtDek;
        private TextBox txtStorlek;
        private TextBox txtModell;
        private TextBox txtFjäder;
        private TextBox txtExtraMat;
        private TextBox txtText;
        private Label lblFärg;
        private Label lblTyg;
        private Label lblDek;
        private Label lblText;
        private Label lblStorlek;
        private Label lblModell;
        private Label lblFjäder;
        private Label lblExtraMat;
        private Label lblKommentar;
        private RichTextBox rtxtKommentar;
        private Button btnSparaSpecialBeställning;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ListBox listBox1;
        private Button button1;
        private Button button3;
        private Label label2;
        private ListView listView1;
        private ListView listView2;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button6;
        private TextBox textBox3;
        private ComboBox comboBox3;
    }
}