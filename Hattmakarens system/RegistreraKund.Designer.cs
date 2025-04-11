namespace Hattmakarens_system
{
    partial class RegistreraKund
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
            txtFörnamn = new Label();
            txtEfternamn = new Label();
            txtTelefon = new Label();
            txtEpost = new Label();
            txtAdress = new Label();
            txtForNamn = new TextBox();
            txtEfterName = new TextBox();
            txtTel = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            lblRubrik = new Label();
            lblFel1 = new Label();
            lblFel2 = new Label();
            lblFel3 = new Label();
            lblFel4 = new Label();
            lblFel6 = new Label();
            btnRegistrera = new Button();
            SuspendLayout();
            // 
            // txtFörnamn
            // 
            txtFörnamn.AutoSize = true;
            txtFörnamn.Location = new Point(93, 46);
            txtFörnamn.Name = "txtFörnamn";
            txtFörnamn.Size = new Size(55, 15);
            txtFörnamn.TabIndex = 0;
            txtFörnamn.Text = "Förnamn";
            // 
            // txtEfternamn
            // 
            txtEfternamn.AutoSize = true;
            txtEfternamn.Location = new Point(93, 92);
            txtEfternamn.Name = "txtEfternamn";
            txtEfternamn.Size = new Size(62, 15);
            txtEfternamn.TabIndex = 1;
            txtEfternamn.Text = "Efternamn";
            // 
            // txtTelefon
            // 
            txtTelefon.AutoSize = true;
            txtTelefon.Location = new Point(93, 145);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(45, 15);
            txtTelefon.TabIndex = 2;
            txtTelefon.Text = "Telefon";
            // 
            // txtEpost
            // 
            txtEpost.AutoSize = true;
            txtEpost.Location = new Point(100, 190);
            txtEpost.Name = "txtEpost";
            txtEpost.Size = new Size(36, 15);
            txtEpost.TabIndex = 3;
            txtEpost.Text = "Epost";
            // 
            // txtAdress
            // 
            txtAdress.AutoSize = true;
            txtAdress.Location = new Point(93, 237);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(42, 15);
            txtAdress.TabIndex = 4;
            txtAdress.Text = "Adress";
            // 
            // txtForNamn
            // 
            txtForNamn.Location = new Point(184, 43);
            txtForNamn.Name = "txtForNamn";
            txtForNamn.Size = new Size(100, 23);
            txtForNamn.TabIndex = 5;
            // 
            // txtEfterName
            // 
            txtEfterName.Location = new Point(184, 89);
            txtEfterName.Name = "txtEfterName";
            txtEfterName.Size = new Size(100, 23);
            txtEfterName.TabIndex = 6;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(184, 137);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(184, 234);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 9;
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Location = new Point(159, 9);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(105, 15);
            lblRubrik.TabIndex = 10;
            lblRubrik.Text = "Registrera ny kund";
            // 
            // lblFel1
            // 
            lblFel1.AutoSize = true;
            lblFel1.Location = new Point(314, 46);
            lblFel1.Name = "lblFel1";
            lblFel1.Size = new Size(0, 15);
            lblFel1.TabIndex = 11;
            // 
            // lblFel2
            // 
            lblFel2.AutoSize = true;
            lblFel2.Location = new Point(314, 89);
            lblFel2.Name = "lblFel2";
            lblFel2.Size = new Size(0, 15);
            lblFel2.TabIndex = 12;
            // 
            // lblFel3
            // 
            lblFel3.AutoSize = true;
            lblFel3.Location = new Point(314, 145);
            lblFel3.Name = "lblFel3";
            lblFel3.Size = new Size(0, 15);
            lblFel3.TabIndex = 13;
            // 
            // lblFel4
            // 
            lblFel4.AutoSize = true;
            lblFel4.Location = new Point(314, 195);
            lblFel4.Name = "lblFel4";
            lblFel4.Size = new Size(0, 15);
            lblFel4.TabIndex = 14;
            // 
            // lblFel6
            // 
            lblFel6.AutoSize = true;
            lblFel6.Location = new Point(314, 242);
            lblFel6.Name = "lblFel6";
            lblFel6.Size = new Size(0, 15);
            lblFel6.TabIndex = 15;
            // 
            // btnRegistrera
            // 
            btnRegistrera.Location = new Point(129, 263);
            btnRegistrera.Name = "btnRegistrera";
            btnRegistrera.Size = new Size(75, 23);
            btnRegistrera.TabIndex = 16;
            btnRegistrera.Text = "Registrera";
            btnRegistrera.UseVisualStyleBackColor = true;
            btnRegistrera.Click += btnRegistrera_Click;
            // 
            // RegistreraKund
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 450);
            Controls.Add(btnRegistrera);
            Controls.Add(lblFel6);
            Controls.Add(lblFel4);
            Controls.Add(lblFel3);
            Controls.Add(lblFel2);
            Controls.Add(lblFel1);
            Controls.Add(lblRubrik);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtTel);
            Controls.Add(txtEfterName);
            Controls.Add(txtForNamn);
            Controls.Add(txtAdress);
            Controls.Add(txtEpost);
            Controls.Add(txtTelefon);
            Controls.Add(txtEfternamn);
            Controls.Add(txtFörnamn);
            Name = "RegistreraKund";
            Text = "RegistreraKund";
            TransparencyKey = Color.FromArgb(255, 128, 128);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtFörnamn;
        private Label txtEfternamn;
        private Label txtTelefon;
        private Label txtEpost;
        private Label txtAdress;
        private TextBox txtForNamn;
        private TextBox txtEfterName;
        private TextBox txtTel;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label lblRubrik;
        private Label lblFel1;
        private Label lblFel2;
        private Label lblFel3;
        private Label lblFel4;
        private Label lblFel6;
        private Button btnRegistrera;
    }
}