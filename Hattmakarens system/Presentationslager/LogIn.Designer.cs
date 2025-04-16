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
            label3 = new Label();
            lblError = new Label();
            label4 = new Label();
            lblEpostError = new Label();
            lblLosenordError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 110);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Epost:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 186);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Lösenord:";
            // 
            // txtEpost
            // 
            txtEpost.Location = new Point(434, 108);
            txtEpost.Margin = new Padding(2, 2, 2, 2);
            txtEpost.Name = "txtEpost";
            txtEpost.Size = new Size(342, 27);
            txtEpost.TabIndex = 2;
            txtEpost.TextChanged += txtAnvändarnamn_TextChanged;
            // 
            // txtLösenord
            // 
            txtLösenord.Location = new Point(434, 181);
            txtLösenord.Margin = new Padding(2, 2, 2, 2);
            txtLösenord.Name = "txtLösenord";
            txtLösenord.Size = new Size(345, 27);
            txtLösenord.TabIndex = 3;
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.Location = new Point(670, 267);
            btnLoggaIn.Margin = new Padding(2, 2, 2, 2);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(105, 31);
            btnLoggaIn.TabIndex = 4;
            btnLoggaIn.Text = "Logga in";
            btnLoggaIn.UseVisualStyleBackColor = true;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(701, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(866, 179);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 52);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 7;
            label4.Text = "Logga in";
            label4.Click += label4_Click;
            // 
            // lblEpostError
            // 
            lblEpostError.AutoSize = true;
            lblEpostError.Location = new Point(448, 141);
            lblEpostError.Margin = new Padding(2, 0, 2, 0);
            lblEpostError.Name = "lblEpostError";
            lblEpostError.Size = new Size(0, 20);
            lblEpostError.TabIndex = 8;
            // 
            // lblLosenordError
            // 
            lblLosenordError.AutoSize = true;
            lblLosenordError.Location = new Point(434, 223);
            lblLosenordError.Margin = new Padding(2, 0, 2, 0);
            lblLosenordError.Name = "lblLosenordError";
            lblLosenordError.Size = new Size(0, 20);
            lblLosenordError.TabIndex = 9;
            // 
            // LoggaInGränsnittt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 519);
            Controls.Add(lblLosenordError);
            Controls.Add(lblEpostError);
            Controls.Add(label4);
            Controls.Add(lblError);
            Controls.Add(label3);
            Controls.Add(btnLoggaIn);
            Controls.Add(txtLösenord);
            Controls.Add(txtEpost);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
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
        private Label label3;
        private Label lblError;
        private Label label4;
        private Label lblEpostError;
        private Label lblLosenordError;
    }
}
