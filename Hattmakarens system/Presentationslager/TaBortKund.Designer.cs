namespace Hattmakarens_system.Presentationslager
{
    partial class TaBortKund
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
            lstKunder = new ListBox();
            btnTaBortKund = new Button();
            menuStrip1 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstKunder
            // 
            lstKunder.FormattingEnabled = true;
            lstKunder.Location = new Point(34, 88);
            lstKunder.Name = "lstKunder";
            lstKunder.Size = new Size(392, 484);
            lstKunder.TabIndex = 0;
            // 
            // btnTaBortKund
            // 
            btnTaBortKund.Location = new Point(803, 661);
            btnTaBortKund.Name = "btnTaBortKund";
            btnTaBortKund.Size = new Size(182, 46);
            btnTaBortKund.TabIndex = 1;
            btnTaBortKund.Text = "Ta bort kund";
            btnTaBortKund.UseVisualStyleBackColor = true;
            btnTaBortKund.Click += btnTaBortKund_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1034, 40);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(115, 36);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // TaBortKund
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 757);
            Controls.Add(btnTaBortKund);
            Controls.Add(lstKunder);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TaBortKund";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hantera kund";
            FormClosed += TaBortKund_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstKunder;
        private Button btnTaBortKund;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
    }
}