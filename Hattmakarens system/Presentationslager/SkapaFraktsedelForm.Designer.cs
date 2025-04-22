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
            txtTotalPris = new TextBox();
            txtExKod = new TextBox();
            btnSkapa = new Button();
            btnSkrivUt = new Button();
            lblOrderId = new Label();
            lblVikt = new Label();
            lblKostnad = new Label();
            lblExportKod = new Label();
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
            txtVikt.Location = new Point(263, 88);
            txtVikt.Margin = new Padding(5);
            txtVikt.Name = "txtVikt";
            txtVikt.Size = new Size(441, 39);
            txtVikt.TabIndex = 0;
            txtVikt.TextChanged += txtVikt_TextChanged;
            // 
            // txtTotalPris
            // 
            txtTotalPris.Location = new Point(263, 141);
            txtTotalPris.Margin = new Padding(5);
            txtTotalPris.Name = "txtTotalPris";
            txtTotalPris.Size = new Size(441, 39);
            txtTotalPris.TabIndex = 1;
            // 
            // txtExKod
            // 
            txtExKod.Location = new Point(263, 194);
            txtExKod.Margin = new Padding(5);
            txtExKod.Name = "txtExKod";
            txtExKod.Size = new Size(441, 39);
            txtExKod.TabIndex = 2;
            // 
            // btnSkapa
            // 
            btnSkapa.Location = new Point(11, 821);
            btnSkapa.Margin = new Padding(5);
            btnSkapa.Name = "btnSkapa";
            btnSkapa.Size = new Size(236, 46);
            btnSkapa.TabIndex = 4;
            btnSkapa.Text = "Skapa Fraktsedel";
            btnSkapa.UseVisualStyleBackColor = true;
            btnSkapa.Click += btnSkapa_Click;
            // 
            // btnSkrivUt
            // 
            btnSkrivUt.Location = new Point(478, 814);
            btnSkrivUt.Margin = new Padding(5);
            btnSkrivUt.Name = "btnSkrivUt";
            btnSkrivUt.Size = new Size(236, 46);
            btnSkrivUt.TabIndex = 5;
            btnSkrivUt.Text = "Skriv ut";
            btnSkrivUt.UseVisualStyleBackColor = true;
            btnSkrivUt.Click += btnSkrivUt_Click;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(86, 14);
            lblOrderId.Margin = new Padding(5, 0, 5, 0);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(0, 32);
            lblOrderId.TabIndex = 6;
            // 
            // lblVikt
            // 
            lblVikt.AutoSize = true;
            lblVikt.Location = new Point(86, 99);
            lblVikt.Margin = new Padding(5, 0, 5, 0);
            lblVikt.Name = "lblVikt";
            lblVikt.Size = new Size(55, 32);
            lblVikt.TabIndex = 7;
            lblVikt.Text = "Vikt";
            // 
            // lblKostnad
            // 
            lblKostnad.AutoSize = true;
            lblKostnad.Location = new Point(86, 152);
            lblKostnad.Margin = new Padding(5, 0, 5, 0);
            lblKostnad.Name = "lblKostnad";
            lblKostnad.Size = new Size(110, 32);
            lblKostnad.TabIndex = 8;
            lblKostnad.Text = "Total pris";
            // 
            // lblExportKod
            // 
            lblExportKod.AutoSize = true;
            lblExportKod.Location = new Point(86, 205);
            lblExportKod.Margin = new Padding(5, 0, 5, 0);
            lblExportKod.Name = "lblExportKod";
            lblExportKod.Size = new Size(129, 32);
            lblExportKod.TabIndex = 9;
            lblExportKod.Text = "Export Kod";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(270, 381);
            txtAdress.Margin = new Padding(5);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(441, 39);
            txtAdress.TabIndex = 11;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(86, 392);
            lblAdress.Margin = new Padding(5, 0, 5, 0);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(84, 32);
            lblAdress.TabIndex = 14;
            lblAdress.Text = "Adress";
            // 
            // labellblAvsandre
            // 
            labellblAvsandre.AutoSize = true;
            labellblAvsandre.Location = new Point(86, 470);
            labellblAvsandre.Margin = new Padding(5, 0, 5, 0);
            labellblAvsandre.Name = "labellblAvsandre";
            labellblAvsandre.Size = new Size(124, 32);
            labellblAvsandre.TabIndex = 15;
            labellblAvsandre.Text = "Avsändare";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 538);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 16;
            label4.Text = "Mottagre";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(86, 618);
            lblBeskrivning.Margin = new Padding(5, 0, 5, 0);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(137, 32);
            lblBeskrivning.TabIndex = 17;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // txtAvsandare
            // 
            txtAvsandare.Location = new Point(263, 459);
            txtAvsandare.Margin = new Padding(5);
            txtAvsandare.Name = "txtAvsandare";
            txtAvsandare.Size = new Size(441, 39);
            txtAvsandare.TabIndex = 18;
            // 
            // txtMottagare
            // 
            txtMottagare.Location = new Point(263, 526);
            txtMottagare.Margin = new Padding(5);
            txtMottagare.Name = "txtMottagare";
            txtMottagare.Size = new Size(441, 39);
            txtMottagare.TabIndex = 19;
            // 
            // rchtxtBeskrivning
            // 
            rchtxtBeskrivning.Location = new Point(263, 613);
            rchtxtBeskrivning.Margin = new Padding(5);
            rchtxtBeskrivning.Name = "rchtxtBeskrivning";
            rchtxtBeskrivning.Size = new Size(441, 190);
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
            lblStatusFraktsedel.Location = new Point(855, 91);
            lblStatusFraktsedel.Margin = new Padding(5, 0, 5, 0);
            lblStatusFraktsedel.Name = "lblStatusFraktsedel";
            lblStatusFraktsedel.Size = new Size(78, 32);
            lblStatusFraktsedel.TabIndex = 21;
            lblStatusFraktsedel.Text = "label1";
            // 
            // SkapaFraktsedelForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1895, 1010);
            Controls.Add(lblStatusFraktsedel);
            Controls.Add(rchtxtBeskrivning);
            Controls.Add(txtMottagare);
            Controls.Add(txtAvsandare);
            Controls.Add(lblBeskrivning);
            Controls.Add(label4);
            Controls.Add(labellblAvsandre);
            Controls.Add(lblAdress);
            Controls.Add(txtAdress);
            Controls.Add(lblExportKod);
            Controls.Add(lblKostnad);
            Controls.Add(lblVikt);
            Controls.Add(lblOrderId);
            Controls.Add(btnSkrivUt);
            Controls.Add(btnSkapa);
            Controls.Add(txtExKod);
            Controls.Add(txtTotalPris);
            Controls.Add(txtVikt);
            Margin = new Padding(5);
            Name = "SkapaFraktsedelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SkapaFraktsedelForm";
            Load += SkapaFraktsedelForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVikt;
        private TextBox txtTotalPris;
        private TextBox txtExKod;
        private Button btnSkapa;
        private Button btnSkrivUt;
        private Label lblOrderId;
        private Label lblVikt;
        private Label lblKostnad;
        private Label lblExportKod;
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