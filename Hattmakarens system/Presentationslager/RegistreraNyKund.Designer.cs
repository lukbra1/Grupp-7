namespace Hattmakarens_system.Presentationslager
{
    partial class RegistreraNyKund
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
            KnappOk = new Button();
            KnappAvbryt = new Button();
            LblFornamn = new Label();
            LblEfternamn = new Label();
            LblTelefonNr = new Label();
            LblAdress = new Label();
            TextBoxFornamn = new TextBox();
            TextBoxEfternamn = new TextBox();
            TextBoxTelefonNr = new TextBox();
            TextBoxAdress = new TextBox();
            SuspendLayout();
            // 
            // KnappOk
            // 
            KnappOk.Location = new Point(170, 202);
            KnappOk.Name = "KnappOk";
            KnappOk.Size = new Size(94, 29);
            KnappOk.TabIndex = 0;
            KnappOk.Text = "Ok";
            KnappOk.UseVisualStyleBackColor = true;
            KnappOk.Click += KnappOk_Click;
            // 
            // KnappAvbryt
            // 
            KnappAvbryt.Location = new Point(283, 202);
            KnappAvbryt.Name = "KnappAvbryt";
            KnappAvbryt.Size = new Size(94, 29);
            KnappAvbryt.TabIndex = 1;
            KnappAvbryt.Text = "Avbryt";
            KnappAvbryt.UseVisualStyleBackColor = true;
            KnappAvbryt.Click += KnappAvbryt_Click;
            // 
            // TextFornamn
            // 
            LblFornamn.AutoSize = true;
            LblFornamn.Location = new Point(57, 25);
            LblFornamn.Name = "LblFornamn";
            LblFornamn.Size = new Size(70, 20);
            LblFornamn.TabIndex = 2;
            LblFornamn.Text = "Förnamn:";
            // 
            // LblEfternamn
            // 
            LblEfternamn.AutoSize = true;
            LblEfternamn.Location = new Point(50, 66);
            LblEfternamn.Name = "LblEfternamn";
            LblEfternamn.Size = new Size(80, 20);
            LblEfternamn.TabIndex = 3;
            LblEfternamn.Text = "Efternamn:";
            // 
            // LblTelefonNr
            // 
            LblTelefonNr.AutoSize = true;
            LblTelefonNr.Location = new Point(17, 104);
            LblTelefonNr.Name = "LblTelefonNr";
            LblTelefonNr.Size = new Size(116, 20);
            LblTelefonNr.TabIndex = 4;
            LblTelefonNr.Text = "Telefonnummer:";
            // 
            // LblAdress
            // 
            LblAdress.AutoSize = true;
            LblAdress.Location = new Point(74, 145);
            LblAdress.Name = "LblAdress";
            LblAdress.Size = new Size(56, 20);
            LblAdress.TabIndex = 5;
            LblAdress.Text = "Adress:";
            // 
            // TextBoxFornamn
            // 
            TextBoxFornamn.Location = new Point(150, 25);
            TextBoxFornamn.Name = "TextBoxFornamn";
            TextBoxFornamn.Size = new Size(202, 27);
            TextBoxFornamn.TabIndex = 6;
            // 
            // TextBoxEfternamn
            // 
            TextBoxEfternamn.Location = new Point(150, 66);
            TextBoxEfternamn.Name = "TextBoxEfternamn";
            TextBoxEfternamn.Size = new Size(202, 27);
            TextBoxEfternamn.TabIndex = 7;
            // 
            // TextBoxTelefonNr
            // 
            TextBoxTelefonNr.Location = new Point(150, 104);
            TextBoxTelefonNr.Name = "TextBoxTelefonNr";
            TextBoxTelefonNr.Size = new Size(202, 27);
            TextBoxTelefonNr.TabIndex = 8;
            // 
            // TextBoxAdress
            // 
            TextBoxAdress.Location = new Point(150, 145);
            TextBoxAdress.Name = "TextBoxAdress";
            TextBoxAdress.Size = new Size(202, 27);
            TextBoxAdress.TabIndex = 9;
            // 
            // RegistreraNyKund
            // 
            AcceptButton = KnappOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = KnappAvbryt;
            ClientSize = new Size(404, 249);
            Controls.Add(TextBoxAdress);
            Controls.Add(TextBoxTelefonNr);
            Controls.Add(TextBoxEfternamn);
            Controls.Add(TextBoxFornamn);
            Controls.Add(LblAdress);
            Controls.Add(LblTelefonNr);
            Controls.Add(LblEfternamn);
            Controls.Add(LblFornamn);
            Controls.Add(KnappAvbryt);
            Controls.Add(KnappOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistreraNyKund";
            ShowIcon = false;
            Text = "Registrera ny kund";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button KnappOk;
        private Button KnappAvbryt;
        private Label LblFornamn;
        private Label LblEfternamn;
        private Label LblTelefonNr;
        private Label LblAdress;
        private TextBox TextBoxFornamn;
        private TextBox TextBoxEfternamn;
        private TextBox TextBoxTelefonNr;
        private TextBox TextBoxAdress;
    }
}