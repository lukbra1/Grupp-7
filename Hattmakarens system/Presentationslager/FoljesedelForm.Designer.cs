namespace Hattmakarens_system.Presentationslager
{
    partial class FoljesedelForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSkrivFöljesedel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
       

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoljesedelForm));
            btnSkrivFöljesedel = new Button();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            cbSprak = new ComboBox();
            menuStrip1 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSkrivFöljesedel
            // 
            btnSkrivFöljesedel.Location = new Point(112, 139);
            btnSkrivFöljesedel.Name = "btnSkrivFöljesedel";
            btnSkrivFöljesedel.Size = new Size(166, 30);
            btnSkrivFöljesedel.TabIndex = 4;
            btnSkrivFöljesedel.Text = "Skriv ut Följesedel";
            btnSkrivFöljesedel.UseVisualStyleBackColor = true;
            btnSkrivFöljesedel.Click += btnSkrivFöljesedel_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // cbSprak
            // 
            cbSprak.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSprak.FormattingEnabled = true;
            cbSprak.Location = new Point(112, 85);
            cbSprak.Name = "cbSprak";
            cbSprak.Size = new Size(166, 33);
            cbSprak.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(389, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(87, 29);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 46);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 7;
            label1.Text = "Välj språk";
            // 
            // FoljesedelForm
            // 
            ClientSize = new Size(389, 250);
            Controls.Add(label1);
            Controls.Add(cbSprak);
            Controls.Add(btnSkrivFöljesedel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FoljesedelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Följesedel";
            Load += FoljesedelForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtAdress;
        private RichTextBox richTextBox1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private ComboBox cbSprak;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
        private Label label1;
    }
}