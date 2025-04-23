namespace Hattmakarens_system.Presentationslager
{
    partial class FoljesedelForm
    {
        private System.ComponentModel.IContainer components = null;
        private RichTextBox rtbMeddelande;
        private TextBox txtKundNamn;
        private TextBox txtKundAdress;
        private ListView lvOrderrader;
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
            rtbMeddelande = new RichTextBox();
            txtKundNamn = new TextBox();
            txtKundAdress = new TextBox();
            lvOrderrader = new ListView();
            btnSkrivFöljesedel = new Button();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            SuspendLayout();
            // 
            // rtbMeddelande
            // 
            rtbMeddelande.Location = new Point(12, 12);
            rtbMeddelande.Name = "rtbMeddelande";
            rtbMeddelande.Size = new Size(760, 100);
            rtbMeddelande.TabIndex = 0;
            rtbMeddelande.Text = "";
            // 
            // txtKundNamn
            // 
            txtKundNamn.Location = new Point(12, 120);
            txtKundNamn.Name = "txtKundNamn";
            txtKundNamn.PlaceholderText = "Kundnamn";
            txtKundNamn.Size = new Size(300, 31);
            txtKundNamn.TabIndex = 1;
            // 
            // txtKundAdress
            // 
            txtKundAdress.Location = new Point(12, 160);
            txtKundAdress.Name = "txtKundAdress";
            txtKundAdress.PlaceholderText = "Kundadress";
            txtKundAdress.Size = new Size(300, 31);
            txtKundAdress.TabIndex = 2;
            // 
            // lvOrderrader
            // 
            lvOrderrader.FullRowSelect = true;
            lvOrderrader.Location = new Point(12, 200);
            lvOrderrader.Name = "lvOrderrader";
            lvOrderrader.Size = new Size(760, 200);
            lvOrderrader.TabIndex = 3;
            lvOrderrader.UseCompatibleStateImageBehavior = false;
            lvOrderrader.View = View.Details;
            // 
            // btnSkrivFöljesedel
            // 
            btnSkrivFöljesedel.Location = new Point(12, 420);
            btnSkrivFöljesedel.Name = "btnSkrivFöljesedel";
            btnSkrivFöljesedel.Size = new Size(120, 30);
            btnSkrivFöljesedel.TabIndex = 4;
            btnSkrivFöljesedel.Text = "Skriv Följesedel";
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
            // FoljesedelForm
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(btnSkrivFöljesedel);
            Controls.Add(lvOrderrader);
            Controls.Add(txtKundAdress);
            Controls.Add(txtKundNamn);
            Controls.Add(rtbMeddelande);
            Name = "FoljesedelForm";
            Text = "Följesedel";
            Load += FoljesedelForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtAdress;
        private RichTextBox richTextBox1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}