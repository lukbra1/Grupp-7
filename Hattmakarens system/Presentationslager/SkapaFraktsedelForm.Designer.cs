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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            tillbakaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // txtVikt
            // 
            txtVikt.Location = new Point(142, 41);
            txtVikt.Margin = new Padding(3, 2, 3, 2);
            txtVikt.Name = "txtVikt";
            txtVikt.Size = new Size(239, 23);
            txtVikt.TabIndex = 0;
            txtVikt.TextChanged += txtVikt_TextChanged;
            // 
            // txtExportkod
            // 
            txtExportkod.Location = new Point(142, 66);
            txtExportkod.Margin = new Padding(3, 2, 3, 2);
            txtExportkod.Name = "txtExportkod";
            txtExportkod.Size = new Size(239, 23);
            txtExportkod.TabIndex = 1;
            // 
            // txtKostnad
            // 
            txtKostnad.Location = new Point(142, 91);
            txtKostnad.Margin = new Padding(3, 2, 3, 2);
            txtKostnad.Name = "txtKostnad";
            txtKostnad.Size = new Size(239, 23);
            txtKostnad.TabIndex = 2;
            // 
            // txtMoms
            // 
            txtMoms.Location = new Point(142, 116);
            txtMoms.Margin = new Padding(3, 2, 3, 2);
            txtMoms.Name = "txtMoms";
            txtMoms.Size = new Size(239, 23);
            txtMoms.TabIndex = 3;
            // 
            // btnSkapa
            // 
            btnSkapa.Location = new Point(6, 385);
            btnSkapa.Margin = new Padding(3, 2, 3, 2);
            btnSkapa.Name = "btnSkapa";
            btnSkapa.Size = new Size(127, 22);
            btnSkapa.TabIndex = 4;
            btnSkapa.Text = "Skapa Fraktsedel";
            btnSkapa.UseVisualStyleBackColor = true;
            btnSkapa.Click += btnSkapa_Click;
            // 
            // btnSkrivUt
            // 
            btnSkrivUt.Location = new Point(257, 382);
            btnSkrivUt.Margin = new Padding(3, 2, 3, 2);
            btnSkrivUt.Name = "btnSkrivUt";
            btnSkrivUt.Size = new Size(127, 22);
            btnSkrivUt.TabIndex = 5;
            btnSkrivUt.Text = "Skriv ut";
            btnSkrivUt.UseVisualStyleBackColor = true;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(46, 7);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(0, 15);
            lblOrderId.TabIndex = 6;
            // 
            // lblVikt
            // 
            lblVikt.AutoSize = true;
            lblVikt.Location = new Point(46, 46);
            lblVikt.Name = "lblVikt";
            lblVikt.Size = new Size(27, 15);
            lblVikt.TabIndex = 7;
            lblVikt.Text = "Vikt";
            // 
            // lblKostnad
            // 
            lblKostnad.AutoSize = true;
            lblKostnad.Location = new Point(46, 71);
            lblKostnad.Name = "lblKostnad";
            lblKostnad.Size = new Size(79, 15);
            lblKostnad.TabIndex = 8;
            lblKostnad.Text = "Frakt Kostnad";
            // 
            // lblExportKod
            // 
            lblExportKod.AutoSize = true;
            lblExportKod.Location = new Point(46, 96);
            lblExportKod.Name = "lblExportKod";
            lblExportKod.Size = new Size(65, 15);
            lblExportKod.TabIndex = 9;
            lblExportKod.Text = "Export Kod";
            // 
            // lblMoms
            // 
            lblMoms.AutoSize = true;
            lblMoms.Location = new Point(46, 121);
            lblMoms.Name = "lblMoms";
            lblMoms.Size = new Size(41, 15);
            lblMoms.TabIndex = 10;
            lblMoms.Text = "Moms";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(145, 178);
            txtAdress.Margin = new Padding(3, 2, 3, 2);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(239, 23);
            txtAdress.TabIndex = 11;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(46, 184);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(42, 15);
            lblAdress.TabIndex = 14;
            lblAdress.Text = "Adress";
            // 
            // labellblAvsandre
            // 
            labellblAvsandre.AutoSize = true;
            labellblAvsandre.Location = new Point(46, 220);
            labellblAvsandre.Name = "labellblAvsandre";
            labellblAvsandre.Size = new Size(62, 15);
            labellblAvsandre.TabIndex = 15;
            labellblAvsandre.Text = "Avsändare";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 252);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 16;
            label4.Text = "Mottagre";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(46, 290);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(68, 15);
            lblBeskrivning.TabIndex = 17;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // txtAvsandare
            // 
            txtAvsandare.Location = new Point(142, 215);
            txtAvsandare.Margin = new Padding(3, 2, 3, 2);
            txtAvsandare.Name = "txtAvsandare";
            txtAvsandare.Size = new Size(239, 23);
            txtAvsandare.TabIndex = 18;
            // 
            // txtMottagare
            // 
            txtMottagare.Location = new Point(142, 247);
            txtMottagare.Margin = new Padding(3, 2, 3, 2);
            txtMottagare.Name = "txtMottagare";
            txtMottagare.Size = new Size(239, 23);
            txtMottagare.TabIndex = 19;
            // 
            // rchtxtBeskrivning
            // 
            rchtxtBeskrivning.Location = new Point(142, 287);
            rchtxtBeskrivning.Margin = new Padding(3, 2, 3, 2);
            rchtxtBeskrivning.Name = "rchtxtBeskrivning";
            rchtxtBeskrivning.Size = new Size(239, 91);
            rchtxtBeskrivning.TabIndex = 20;
            rchtxtBeskrivning.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1020, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { tillbakaToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1020, 24);
            menuStrip2.TabIndex = 22;
            menuStrip2.Text = "menuStrip2";
            // 
            // tillbakaToolStripMenuItem
            // 
            tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            tillbakaToolStripMenuItem.Size = new Size(59, 20);
            tillbakaToolStripMenuItem.Text = "Tillbaka";
            tillbakaToolStripMenuItem.Click += tillbakaToolStripMenuItem_Click;
            // 
            // SkapaFraktsedelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 473);
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
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SkapaFraktsedelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SkapaFraktsedelForm";
            Load += SkapaFraktsedelForm_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
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
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem tillbakaToolStripMenuItem;
    }
}