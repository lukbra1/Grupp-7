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
            listBox1.Location = new Point(76, 188);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(644, 228);
            listBox1.TabIndex = 38;
            // 
            // button2
            // 
            button2.Location = new Point(570, 106);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 37;
            button2.Text = "Sök";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 39);
            textBox1.TabIndex = 36;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 110);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 35;
            label2.Text = "Sök på material:";
            // 
            // button1
            // 
            button1.Location = new Point(192, 440);
            button1.Name = "button1";
            button1.Size = new Size(373, 46);
            button1.TabIndex = 34;
            button1.Text = "Lägg till material på hattmodell";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGaVidare
            // 
            btnGaVidare.Location = new Point(1284, 640);
            btnGaVidare.Name = "btnGaVidare";
            btnGaVidare.Size = new Size(150, 46);
            btnGaVidare.TabIndex = 8;
            btnGaVidare.Text = "Gå vidare";
            btnGaVidare.UseVisualStyleBackColor = true;
            // 
            // btnRegistrera
            // 
            btnRegistrera.Location = new Point(918, 155);
            btnRegistrera.Margin = new Padding(6);
            btnRegistrera.Name = "btnRegistrera";
            btnRegistrera.Size = new Size(246, 49);
            btnRegistrera.TabIndex = 33;
            btnRegistrera.Text = "Lägg till material";
            btnRegistrera.UseVisualStyleBackColor = true;
            btnRegistrera.Click += btnRegistrera_Click;
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Location = new Point(918, 43);
            lblRubrik.Margin = new Padding(6, 0, 6, 0);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(261, 32);
            lblRubrik.TabIndex = 27;
            lblRubrik.Text = "Registrera nytt material";
            // 
            // AnpassaLagerhattar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 710);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnRegistrera);
            Controls.Add(lblRubrik);
            Controls.Add(btnGaVidare);
            Name = "AnpassaLagerhattar";
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