namespace Hattmakarens_system.Presentationslager
{
    partial class SkapaFraktsedelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkapaFraktsedelForm));
            txtVikt = new TextBox();
            txtExportkod = new TextBox();
            txtKostnad = new TextBox();
            txtMoms = new TextBox();
            btnSkapa = new Button();
            btnSkrivUt = new Button();
            lblOrderId = new Label();
            lblVikt = new Label();
            lblKostnad = new Label();
            lblExportKod = new Label();
            lblMoms = new Label();
            txtAdress = new TextBox();
            lblAdress = new Label();
            labellblAvsandre = new Label();
            label4 = new Label();
            lblBeskrivning = new Label();
            txtAvsandare = new TextBox();
            txtMottagare = new TextBox();
            rchtxtBeskrivning = new RichTextBox();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            lblStatusFraktsedel = new Label();
            SuspendLayout();
            // 
            // txtVikt
            // 
            txtVikt.Location = new Point(162, 55);
            txtVikt.Name = "txtVikt";
            txtVikt.Size = new Size(273, 27);
            txtVikt.TabIndex = 0;
            txtVikt.TextChanged += txtVikt_TextChanged;
            // 
            // txtExportkod
            // 
            txtExportkod.Location = new Point(162, 88);
            txtExportkod.Name = "txtExportkod";
            txtExportkod.Size = new Size(273, 27);
            txtExportkod.TabIndex = 1;
            // 
            // txtKostnad
            // 
            txtKostnad.Location = new Point(162, 121);
            txtKostnad.Name = "txtKostnad";
            txtKostnad.Size = new Size(273, 27);
            txtKostnad.TabIndex = 2;
            // 
            // txtMoms
            // 
            txtMoms.Location = new Point(162, 154);
            txtMoms.Name = "txtMoms";
            txtMoms.Size = new Size(273, 27);
            txtMoms.TabIndex = 3;
            // 
            // btnSkapa
            // 
            btnSkapa.Location = new Point(7, 513);
            btnSkapa.Name = "btnSkapa";
            btnSkapa.Size = new Size(145, 29);
            btnSkapa.TabIndex = 4;
            btnSkapa.Text = "Skapa Fraktsedel";
            btnSkapa.UseVisualStyleBackColor = true;
            btnSkapa.Click += btnSkapa_Click;
            // 
            // btnSkrivUt
            // 
            btnSkrivUt.Location = new Point(294, 509);
            btnSkrivUt.Name = "btnSkrivUt";
            btnSkrivUt.Size = new Size(145, 29);
            btnSkrivUt.TabIndex = 5;
            btnSkrivUt.Text = "Skriv ut";
            btnSkrivUt.UseVisualStyleBackColor = true;
            btnSkrivUt.Click += btnSkrivUt_Click;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(53, 9);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(0, 20);
            lblOrderId.TabIndex = 6;
            // 
            // lblVikt
            // 
            lblVikt.AutoSize = true;
            lblVikt.Location = new Point(53, 62);
            lblVikt.Name = "lblVikt";
            lblVikt.Size = new Size(34, 20);
            lblVikt.TabIndex = 7;
            lblVikt.Text = "Vikt";
            // 
            // lblKostnad
            // 
            lblKostnad.AutoSize = true;
            lblKostnad.Location = new Point(53, 95);
            lblKostnad.Name = "lblKostnad";
            lblKostnad.Size = new Size(99, 20);
            lblKostnad.TabIndex = 8;
            lblKostnad.Text = "Frakt Kostnad";
            // 
            // lblExportKod
            // 
            lblExportKod.AutoSize = true;
            lblExportKod.Location = new Point(53, 128);
            lblExportKod.Name = "lblExportKod";
            lblExportKod.Size = new Size(83, 20);
            lblExportKod.TabIndex = 9;
            lblExportKod.Text = "Export Kod";
            // 
            // lblMoms
            // 
            lblMoms.AutoSize = true;
            lblMoms.Location = new Point(53, 161);
            lblMoms.Name = "lblMoms";
            lblMoms.Size = new Size(50, 20);
            lblMoms.TabIndex = 10;
            lblMoms.Text = "Moms";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(166, 238);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(273, 27);
            txtAdress.TabIndex = 11;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(53, 245);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(53, 20);
            lblAdress.TabIndex = 14;
            lblAdress.Text = "Adress";
            // 
            // labellblAvsandre
            // 
            labellblAvsandre.AutoSize = true;
            labellblAvsandre.Location = new Point(53, 294);
            labellblAvsandre.Name = "labellblAvsandre";
            labellblAvsandre.Size = new Size(78, 20);
            labellblAvsandre.TabIndex = 15;
            labellblAvsandre.Text = "Avsändare";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 336);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 16;
            label4.Text = "Mottagre";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(53, 386);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(84, 20);
            lblBeskrivning.TabIndex = 17;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // txtAvsandare
            // 
            txtAvsandare.Location = new Point(162, 287);
            txtAvsandare.Name = "txtAvsandare";
            txtAvsandare.Size = new Size(273, 27);
            txtAvsandare.TabIndex = 18;
            // 
            // txtMottagare
            // 
            txtMottagare.Location = new Point(162, 329);
            txtMottagare.Name = "txtMottagare";
            txtMottagare.Size = new Size(273, 27);
            txtMottagare.TabIndex = 19;
            // 
            // rchtxtBeskrivning
            // 
            rchtxtBeskrivning.Location = new Point(162, 383);
            rchtxtBeskrivning.Name = "rchtxtBeskrivning";
            rchtxtBeskrivning.Size = new Size(273, 120);
            rchtxtBeskrivning.TabIndex = 20;
            rchtxtBeskrivning.Text = "";
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
            // lblStatusFraktsedel
            // 
            lblStatusFraktsedel.AutoSize = true;
            lblStatusFraktsedel.Location = new Point(525, 88);
            lblStatusFraktsedel.Name = "lblStatusFraktsedel";
            lblStatusFraktsedel.Size = new Size(50, 20);
            lblStatusFraktsedel.TabIndex = 21;
            lblStatusFraktsedel.Text = "label1";
            // 
            // SkapaFraktsedelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 631);
            Controls.Add(lblStatusFraktsedel);
            Controls.Add(rchtxtBeskrivning);
            Controls.Add(txtMottagare);
            Controls.Add(txtAvsandare);
            Controls.Add(lblBeskrivning);
            Controls.Add(label4);
            Controls.Add(labellblAvsandre);
            Controls.Add(lblAdress);
            Controls.Add(txtAdress);
            Controls.Add(lblMoms);
            Controls.Add(lblExportKod);
            Controls.Add(lblKostnad);
            Controls.Add(lblVikt);
            Controls.Add(lblOrderId);
            Controls.Add(btnSkrivUt);
            Controls.Add(btnSkapa);
            Controls.Add(txtMoms);
            Controls.Add(txtKostnad);
            Controls.Add(txtExportkod);
            Controls.Add(txtVikt);
            Name = "SkapaFraktsedelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SkapaFraktsedelForm";
            Load += SkapaFraktsedelForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVikt;
        private TextBox txtExportkod;
        private TextBox txtKostnad;
        private TextBox txtMoms;
        private Button btnSkapa;
        private Button btnSkrivUt;
        private Label lblOrderId;
        private Label lblVikt;
        private Label lblKostnad;
        private Label lblExportKod;
        private Label lblMoms;
        private TextBox txtAdress;
        private TextBox txtAvsändare;
        private Label lblAdress;
        private Label labellblAvsandre;
        private Label label4;
        private Label lblBeskrivning;
        private TextBox txtAvsandare;
        private TextBox txtMottagare;
        private RichTextBox richTextBox1;
        private RichTextBox rchtxtBeskrivning;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label lblStatusFraktsedel;
    }
}