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
            SuspendLayout();
            // 
            // txtExtraMat
            // 
            txtExtraMat.Location = new Point(17, 53);
            txtExtraMat.Margin = new Padding(3, 2, 3, 2);
            txtExtraMat.Name = "txtExtraMat";
            txtExtraMat.Size = new Size(338, 23);
            txtExtraMat.TabIndex = 6;
            txtExtraMat.Text = "Sök material";
            txtExtraMat.TextChanged += txtExtraMat_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(17, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(338, 79);
            listBox1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(361, 53);
            button1.Name = "button1";
            button1.Size = new Size(73, 23);
            button1.TabIndex = 20;
            button1.Text = "Sök";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(361, 142);
            button3.Name = "button3";
            button3.Size = new Size(73, 23);
            button3.TabIndex = 22;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(361, 112);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 23);
            textBox1.TabIndex = 23;
            textBox1.Text = "Antal";
            // 
            // listView1
            // 
            listView1.Location = new Point(17, 171);
            listView1.Name = "listView1";
            listView1.Size = new Size(338, 146);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(465, 54);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(360, 264);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "Skriv en kommentar";
            // 
            // button2
            // 
            button2.Location = new Point(706, 338);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 28;
            button2.Text = "Lägg till Orderrad";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 333);
            button6.Name = "button6";
            button6.Size = new Size(153, 23);
            button6.TabIndex = 31;
            button6.Text = "Registrera nytt material";
            button6.UseVisualStyleBackColor = true;
            // 
            // Specialbeställning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 373);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(txtExtraMat);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Specialbeställning";
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
        private TextBox textBox2;
        private ListView listView2;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button6;
    }
}