namespace Hattmakarens_system.Presentationslager
{
    partial class AnpassaLagerhattar
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
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            btnGaVidare = new Button();
            btnRegistrera = new Button();
            lblRubrik = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(47, 118);
            listBox1.Margin = new Padding(2, 2, 2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(398, 144);
            listBox1.TabIndex = 38;
            // 
            // button2
            // 
            button2.Location = new Point(351, 66);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 37;
            button2.Text = "Sök";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 66);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 36;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 35;
            label2.Text = "Sök på material:";
            // 
            // button1
            // 
            button1.Location = new Point(118, 275);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(230, 29);
            button1.TabIndex = 34;
            button1.Text = "Lägg till material på hattmodell";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGaVidare
            // 
            btnGaVidare.Location = new Point(790, 400);
            btnGaVidare.Margin = new Padding(2, 2, 2, 2);
            btnGaVidare.Name = "btnGaVidare";
            btnGaVidare.Size = new Size(92, 29);
            btnGaVidare.TabIndex = 8;
            btnGaVidare.Text = "Gå vidare";
            btnGaVidare.UseVisualStyleBackColor = true;
            btnGaVidare.Click += btnGaVidare_Click;
            // 
            // btnRegistrera
            // 
            btnRegistrera.Location = new Point(565, 97);
            btnRegistrera.Margin = new Padding(4, 4, 4, 4);
            btnRegistrera.Name = "btnRegistrera";
            btnRegistrera.Size = new Size(151, 31);
            btnRegistrera.TabIndex = 33;
            btnRegistrera.Text = "Lägg till material";
            btnRegistrera.UseVisualStyleBackColor = true;
            btnRegistrera.Click += btnRegistrera_Click;
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Location = new Point(565, 27);
            lblRubrik.Margin = new Padding(4, 0, 4, 0);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(164, 20);
            lblRubrik.TabIndex = 27;
            lblRubrik.Text = "Registrera nytt material";
            // 
            // AnpassaLagerhattar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 631);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnRegistrera);
            Controls.Add(lblRubrik);
            Controls.Add(btnGaVidare);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AnpassaLagerhattar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnpassaLagerhattar";
            Load += AnpassaLagerhattar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button btnGaVidare;
        private Button btnRegistrera;
        private Label lblRubrik;
    }
}