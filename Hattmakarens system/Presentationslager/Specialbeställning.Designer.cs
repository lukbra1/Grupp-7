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
            txtExtraMat.Location = new Point(24, 89);
            txtExtraMat.Margin = new Padding(4, 4, 4, 4);
            txtExtraMat.Name = "txtExtraMat";
            txtExtraMat.Size = new Size(482, 31);
            txtExtraMat.TabIndex = 6;
            txtExtraMat.Text = "Sök material";
            txtExtraMat.TextChanged += txtExtraMat_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(24, 144);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(482, 129);
            listBox1.TabIndex = 19;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(516, 89);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 20;
            button1.Text = "Sök";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(516, 236);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(104, 39);
            button3.TabIndex = 22;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(516, 186);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 31);
            textBox1.TabIndex = 23;
            textBox1.Text = "Antal";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(24, 285);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(482, 240);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(664, 90);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(513, 438);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "Skriv en kommentar";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(1201, 236);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(261, 39);
            button2.TabIndex = 28;
            button2.Text = "Lägg till Orderrad";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(18, 555);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(219, 39);
            button6.TabIndex = 31;
            button6.Text = "Registrera nytt material";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1201, 164);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 31);
            textBox3.TabIndex = 33;
            textBox3.Text = "Referensbild";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            comboBox3.Location = new Point(1201, 90);
            comboBox3.Margin = new Padding(4, 5, 4, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(260, 33);
            comboBox3.TabIndex = 34;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Specialbeställning
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 789);
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
            Margin = new Padding(4, 4, 4, 4);
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