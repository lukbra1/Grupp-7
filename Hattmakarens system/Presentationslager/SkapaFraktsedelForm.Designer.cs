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
            SuspendLayout();
            // 
            // txtVikt
            // 
            txtVikt.Location = new Point(53, 56);
            txtVikt.Name = "txtVikt";
            txtVikt.Size = new Size(125, 27);
            txtVikt.TabIndex = 0;
            // 
            // txtExportkod
            // 
            txtExportkod.Location = new Point(53, 153);
            txtExportkod.Name = "txtExportkod";
            txtExportkod.Size = new Size(125, 27);
            txtExportkod.TabIndex = 1;
            // 
            // txtKostnad
            // 
            txtKostnad.Location = new Point(53, 252);
            txtKostnad.Name = "txtKostnad";
            txtKostnad.Size = new Size(125, 27);
            txtKostnad.TabIndex = 2;
            // 
            // txtMoms
            // 
            txtMoms.Location = new Point(53, 360);
            txtMoms.Name = "txtMoms";
            txtMoms.Size = new Size(125, 27);
            txtMoms.TabIndex = 3;
            // 
            // btnSkapa
            // 
            btnSkapa.Location = new Point(489, 358);
            btnSkapa.Name = "btnSkapa";
            btnSkapa.Size = new Size(145, 29);
            btnSkapa.TabIndex = 4;
            btnSkapa.Text = "Skapa Fraktsedel";
            btnSkapa.UseVisualStyleBackColor = true;
            btnSkapa.Click += btnSkapa_Click;
            // 
            // btnSkrivUt
            // 
            btnSkrivUt.Location = new Point(653, 359);
            btnSkrivUt.Name = "btnSkrivUt";
            btnSkrivUt.Size = new Size(94, 29);
            btnSkrivUt.TabIndex = 5;
            btnSkrivUt.Text = "Skriv ut";
            btnSkrivUt.UseVisualStyleBackColor = true;
            // 
            // SkapaFraktsedelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSkrivUt);
            Controls.Add(btnSkapa);
            Controls.Add(txtMoms);
            Controls.Add(txtKostnad);
            Controls.Add(txtExportkod);
            Controls.Add(txtVikt);
            Name = "SkapaFraktsedelForm";
            Text = "SkapaFraktsedelForm";
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
    }
}