namespace Hattmakarens_system
{
    partial class LoggaInGränsnittt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEpost = new TextBox();
            txtLösenord = new TextBox();
            btnLoggaIn = new Button();
            label4 = new Label();
            lblEpostError = new Label();
            lblLosenordError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 77);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Epost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 140);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Lösenord:";
            // 
            // txtEpost
            // 
            txtEpost.Location = new Point(91, 74);
            txtEpost.Margin = new Padding(2);
            txtEpost.Name = "txtEpost";
            txtEpost.Size = new Size(290, 27);
            txtEpost.TabIndex = 2;
            txtEpost.Text = "admin@example.com";
            // 
            // txtLösenord
            // 
            txtLösenord.Location = new Point(88, 137);
            txtLösenord.Margin = new Padding(2);
            txtLösenord.Name = "txtLösenord";
            txtLösenord.PasswordChar = '*';
            txtLösenord.Size = new Size(293, 27);
            txtLösenord.TabIndex = 3;
            txtLösenord.Text = "admin123";
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.Location = new Point(276, 197);
            btnLoggaIn.Margin = new Padding(2);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(105, 31);
            btnLoggaIn.TabIndex = 4;
            btnLoggaIn.Text = "Logga in";
            btnLoggaIn.UseVisualStyleBackColor = true;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 21);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 7;
            label4.Text = "Logga in";
            // 
            // lblEpostError
            // 
            lblEpostError.AutoSize = true;
            lblEpostError.ForeColor = Color.Red;
            lblEpostError.Location = new Point(96, 108);
            lblEpostError.Margin = new Padding(2, 0, 2, 0);
            lblEpostError.Name = "lblEpostError";
            lblEpostError.Size = new Size(0, 20);
            lblEpostError.TabIndex = 8;
            // 
            // lblLosenordError
            // 
            lblLosenordError.AutoSize = true;
            lblLosenordError.ForeColor = Color.Red;
            lblLosenordError.Location = new Point(96, 173);
            lblLosenordError.Margin = new Padding(2, 0, 2, 0);
            lblLosenordError.Name = "lblLosenordError";
            lblLosenordError.Size = new Size(0, 20);
            lblLosenordError.TabIndex = 9;
            // 
            // LoggaInGränsnittt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 252);
            Controls.Add(lblLosenordError);
            Controls.Add(lblEpostError);
            Controls.Add(label4);
            Controls.Add(btnLoggaIn);
            Controls.Add(txtLösenord);
            Controls.Add(txtEpost);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "LoggaInGränsnittt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inloggning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEpost;
        private TextBox txtLösenord;
        private Button btnLoggaIn;
        private Label label4;
        private Label lblEpostError;
        private Label lblLosenordError;
    }
}
