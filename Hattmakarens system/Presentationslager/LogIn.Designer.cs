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
            txtAnvändarnamn = new TextBox();
            txtLösenord = new TextBox();
            btnLoggaIn = new Button();
            label3 = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(963, 247);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "Användarnamn:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1027, 309);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 1;
            label2.Text = "Lösenord:";
            // 
            // txtAnvändarnamn
            // 
            txtAnvändarnamn.Location = new Point(1139, 247);
            txtAnvändarnamn.Name = "txtAnvändarnamn";
            txtAnvändarnamn.Size = new Size(200, 39);
            txtAnvändarnamn.TabIndex = 2;
            // 
            // txtLösenord
            // 
            txtLösenord.Location = new Point(1139, 309);
            txtLösenord.Name = "txtLösenord";
            txtLösenord.Size = new Size(200, 39);
            txtLösenord.TabIndex = 3;
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.Location = new Point(1189, 379);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(150, 46);
            btnLoggaIn.TabIndex = 4;
            btnLoggaIn.Text = "Logga in";
            btnLoggaIn.UseVisualStyleBackColor = true;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1139, 176);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 5;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(1408, 287);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 32);
            lblError.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2407, 830);
            Controls.Add(lblError);
            Controls.Add(label3);
            Controls.Add(btnLoggaIn);
            Controls.Add(txtLösenord);
            Controls.Add(txtAnvändarnamn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Inloggning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAnvändarnamn;
        private TextBox txtLösenord;
        private Button btnLoggaIn;
        private Label label3;
        private Label lblError;
    }
}
