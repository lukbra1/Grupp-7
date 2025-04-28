
namespace Hattmakarens_system
{
    partial class Homepage
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            beställningarToolStripMenuItem = new ToolStripMenuItem();
            beställningarToolStripMenuItem1 = new ToolStripMenuItem();
            nyBeställningToolStripMenuItem = new ToolStripMenuItem();
            allaBeställningarToolStripMenuItem = new ToolStripMenuItem();
            marealLagerToolStripMenuItem = new ToolStripMenuItem();
            statistikToolStripMenuItem1 = new ToolStripMenuItem();
            hattStatistikToolStripMenuItem = new ToolStripMenuItem();
            kundStatistikToolStripMenuItem = new ToolStripMenuItem();
            hanteraKunderToolStripMenuItem = new ToolStripMenuItem();
            hanteraMedarbetareToolStripMenuItem = new ToolStripMenuItem();
            loggaUtToolStripMenuItem1 = new ToolStripMenuItem();
            monthCalendar1 = new MonthCalendar();
            listBoxMinaUppgifter = new ListView();
            RadOrderId = new ColumnHeader();
            KundNamn = new ColumnHeader();
            HattTyp = new ColumnHeader();
            SkapadDatum = new ColumnHeader();
            TilldelningsDatum = new ColumnHeader();
            richTextBoxVecka = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ordrarList = new ListView();
            OrderId = new ColumnHeader();
            Kund = new ColumnHeader();
            Datum = new ColumnHeader();
            label5 = new Label();
            lvOrderRadLista = new ListView();
            OrderRadId = new ColumnHeader();
            Typ = new ColumnHeader();
            Storlek = new ColumnHeader();
            Status = new ColumnHeader();
            Tilldelad = new ColumnHeader();
            Pris = new ColumnHeader();
            label1 = new Label();
            btnTaBortTilldelning = new Button();
            btnForraVeckan = new Button();
            btnNastaVeckan = new Button();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 42);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1781, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { beställningarToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(8, 3, 0, 3);
            menuStrip2.Size = new Size(1781, 42);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // beställningarToolStripMenuItem
            // 
            beställningarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beställningarToolStripMenuItem1, marealLagerToolStripMenuItem, statistikToolStripMenuItem1, hanteraKunderToolStripMenuItem, hanteraMedarbetareToolStripMenuItem, loggaUtToolStripMenuItem1 });
            beställningarToolStripMenuItem.Name = "beställningarToolStripMenuItem";
            beställningarToolStripMenuItem.Size = new Size(56, 36);
            beställningarToolStripMenuItem.Text = "☰";
            // 
            // beställningarToolStripMenuItem1
            // 
            beställningarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { nyBeställningToolStripMenuItem, allaBeställningarToolStripMenuItem });
            beställningarToolStripMenuItem1.Name = "beställningarToolStripMenuItem1";
            beställningarToolStripMenuItem1.Size = new Size(374, 44);
            beställningarToolStripMenuItem1.Text = "Beställningar";
            // 
            // nyBeställningToolStripMenuItem
            // 
            nyBeställningToolStripMenuItem.Name = "nyBeställningToolStripMenuItem";
            nyBeställningToolStripMenuItem.Size = new Size(330, 44);
            nyBeställningToolStripMenuItem.Text = "Ny beställning";
            nyBeställningToolStripMenuItem.Click += nyBeställningToolStripMenuItem_Click;
            // 
            // allaBeställningarToolStripMenuItem
            // 
            allaBeställningarToolStripMenuItem.Name = "allaBeställningarToolStripMenuItem";
            allaBeställningarToolStripMenuItem.Size = new Size(330, 44);
            allaBeställningarToolStripMenuItem.Text = "Alla beställningar";
            allaBeställningarToolStripMenuItem.Click += allaBeställningarToolStripMenuItem_Click_2;
            // 
            // marealLagerToolStripMenuItem
            // 
            marealLagerToolStripMenuItem.Name = "marealLagerToolStripMenuItem";
            marealLagerToolStripMenuItem.Size = new Size(374, 44);
            marealLagerToolStripMenuItem.Text = "Hantera material";
            marealLagerToolStripMenuItem.Click += marealLagerToolStripMenuItem_Click;
            // 
            // statistikToolStripMenuItem1
            // 
            statistikToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { hattStatistikToolStripMenuItem, kundStatistikToolStripMenuItem });
            statistikToolStripMenuItem1.Name = "statistikToolStripMenuItem1";
            statistikToolStripMenuItem1.Size = new Size(374, 44);
            statistikToolStripMenuItem1.Text = "Statistik";
            // 
            // hattStatistikToolStripMenuItem
            // 
            hattStatistikToolStripMenuItem.Name = "hattStatistikToolStripMenuItem";
            hattStatistikToolStripMenuItem.Size = new Size(290, 44);
            hattStatistikToolStripMenuItem.Text = "Hatt statistik";
            hattStatistikToolStripMenuItem.Click += hattStatistikToolStripMenuItem_Click;
            // 
            // kundStatistikToolStripMenuItem
            // 
            kundStatistikToolStripMenuItem.Name = "kundStatistikToolStripMenuItem";
            kundStatistikToolStripMenuItem.Size = new Size(290, 44);
            kundStatistikToolStripMenuItem.Text = "Kund statistik";
            kundStatistikToolStripMenuItem.Click += kundStatistikToolStripMenuItem_Click;
            // 
            // hanteraKunderToolStripMenuItem
            // 
            hanteraKunderToolStripMenuItem.Name = "hanteraKunderToolStripMenuItem";
            hanteraKunderToolStripMenuItem.Size = new Size(374, 44);
            hanteraKunderToolStripMenuItem.Text = "Hantera kunder";
            hanteraKunderToolStripMenuItem.Click += hanteraKunderToolStripMenuItem_Click;
            // 
            // hanteraMedarbetareToolStripMenuItem
            // 
            hanteraMedarbetareToolStripMenuItem.Name = "hanteraMedarbetareToolStripMenuItem";
            hanteraMedarbetareToolStripMenuItem.Size = new Size(374, 44);
            hanteraMedarbetareToolStripMenuItem.Text = "Hantera medarbetare";
            hanteraMedarbetareToolStripMenuItem.Click += hanteraMedarbetareToolStripMenuItem_Click;
            // 
            // loggaUtToolStripMenuItem1
            // 
            loggaUtToolStripMenuItem1.Name = "loggaUtToolStripMenuItem1";
            loggaUtToolStripMenuItem1.Size = new Size(374, 44);
            loggaUtToolStripMenuItem1.Text = "Logga ut";
            loggaUtToolStripMenuItem1.Click += loggaUtToolStripMenuItem1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(563, 954);
            monthCalendar1.Margin = new Padding(10, 8, 10, 8);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // listBoxMinaUppgifter
            // 
            listBoxMinaUppgifter.Columns.AddRange(new ColumnHeader[] { RadOrderId, KundNamn, HattTyp, SkapadDatum, TilldelningsDatum });
            listBoxMinaUppgifter.Location = new Point(1239, 142);
            listBoxMinaUppgifter.Margin = new Padding(3, 5, 3, 5);
            listBoxMinaUppgifter.Name = "listBoxMinaUppgifter";
            listBoxMinaUppgifter.Size = new Size(477, 626);
            listBoxMinaUppgifter.TabIndex = 4;
            listBoxMinaUppgifter.UseCompatibleStateImageBehavior = false;
            listBoxMinaUppgifter.View = View.Details;
            // 
            // RadOrderId
            // 
            RadOrderId.Text = "OrderRadId";
            RadOrderId.Width = 100;
            // 
            // KundNamn
            // 
            KundNamn.Text = "KundNamn";
            KundNamn.Width = 100;
            // 
            // HattTyp
            // 
            HattTyp.Text = "HattTyp";
            HattTyp.Width = 100;
            // 
            // SkapadDatum
            // 
            SkapadDatum.Text = "SkapadDatum";
            SkapadDatum.Width = 100;
            // 
            // TilldelningsDatum
            // 
            TilldelningsDatum.Text = "TilldelningsDatum";
            TilldelningsDatum.Width = 100;
            // 
            // richTextBoxVecka
            // 
            richTextBoxVecka.Location = new Point(13, 855);
            richTextBoxVecka.Margin = new Padding(3, 5, 3, 5);
            richTextBoxVecka.Name = "richTextBoxVecka";
            richTextBoxVecka.Size = new Size(504, 537);
            richTextBoxVecka.TabIndex = 5;
            richTextBoxVecka.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 818);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 11;
            label2.Text = "Schema översikt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(563, 914);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 12;
            label3.Text = "Välj dag";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1239, 106);
            label4.Name = "label4";
            label4.Size = new Size(256, 32);
            label4.TabIndex = 13;
            label4.Text = "Mina uppgiter att göra";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ordrarList
            // 
            ordrarList.Columns.AddRange(new ColumnHeader[] { OrderId, Kund, Datum });
            ordrarList.Location = new Point(13, 142);
            ordrarList.Margin = new Padding(4);
            ordrarList.Name = "ordrarList";
            ordrarList.Size = new Size(504, 627);
            ordrarList.TabIndex = 14;
            ordrarList.UseCompatibleStateImageBehavior = false;
            ordrarList.View = View.Details;
            // 
            // OrderId
            // 
            OrderId.Text = "OrderId";
            OrderId.Width = 100;
            // 
            // Kund
            // 
            Kund.Text = "Kund";
            Kund.Width = 100;
            // 
            // Datum
            // 
            Datum.Text = "Datum";
            Datum.Width = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 106);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 15;
            label5.Text = "Ordrar";
            // 
            // lvOrderRadLista
            // 
            lvOrderRadLista.Columns.AddRange(new ColumnHeader[] { OrderRadId, Typ, Storlek, Status, Tilldelad, Pris });
            lvOrderRadLista.FullRowSelect = true;
            lvOrderRadLista.Location = new Point(560, 142);
            lvOrderRadLista.Name = "lvOrderRadLista";
            lvOrderRadLista.Size = new Size(598, 627);
            lvOrderRadLista.TabIndex = 16;
            lvOrderRadLista.UseCompatibleStateImageBehavior = false;
            lvOrderRadLista.View = View.Details;
            lvOrderRadLista.SelectedIndexChanged += lvOrderRadLista_SelectedIndexChanged;
            // 
            // OrderRadId
            // 
            OrderRadId.Text = "OrderRadId";
            OrderRadId.Width = 100;
            // 
            // Typ
            // 
            Typ.Text = "Typ";
            Typ.Width = 100;
            // 
            // Storlek
            // 
            Storlek.Text = "Storlek";
            Storlek.Width = 100;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 100;
            // 
            // Tilldelad
            // 
            Tilldelad.Text = "Tilldelad";
            Tilldelad.Width = 100;
            // 
            // Pris
            // 
            Pris.Text = "Pris";
            Pris.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 106);
            label1.Name = "label1";
            label1.Size = new Size(386, 32);
            label1.TabIndex = 17;
            label1.Text = "Lista över hattar i den valda ordern";
            // 
            // btnTaBortTilldelning
            // 
            btnTaBortTilldelning.Location = new Point(928, 788);
            btnTaBortTilldelning.Name = "btnTaBortTilldelning";
            btnTaBortTilldelning.Size = new Size(230, 46);
            btnTaBortTilldelning.TabIndex = 18;
            btnTaBortTilldelning.Text = "Ta bort tilldelning";
            btnTaBortTilldelning.UseVisualStyleBackColor = true;
            btnTaBortTilldelning.Click += btnTaBortTilldelning_Click;
            // 
            // btnForraVeckan
            // 
            btnForraVeckan.Location = new Point(13, 1400);
            btnForraVeckan.Name = "btnForraVeckan";
            btnForraVeckan.Size = new Size(248, 45);
            btnForraVeckan.TabIndex = 19;
            btnForraVeckan.Text = "← Föregående vecka";
            btnForraVeckan.UseVisualStyleBackColor = true;
            btnForraVeckan.Click += btnForraVeckan_Click;
            // 
            // btnNastaVeckan
            // 
            btnNastaVeckan.Location = new Point(299, 1400);
            btnNastaVeckan.Name = "btnNastaVeckan";
            btnNastaVeckan.Size = new Size(218, 45);
            btnNastaVeckan.TabIndex = 20;
            btnNastaVeckan.Text = "Nästa vecka →";
            btnNastaVeckan.UseVisualStyleBackColor = true;
            btnNastaVeckan.Click += btnNastaVeckan_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1781, 1506);
            Controls.Add(btnNastaVeckan);
            Controls.Add(btnForraVeckan);
            Controls.Add(btnTaBortTilldelning);
            Controls.Add(label1);
            Controls.Add(lvOrderRadLista);
            Controls.Add(label5);
            Controls.Add(ordrarList);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBoxVecka);
            Controls.Add(listBoxMinaUppgifter);
            Controls.Add(monthCalendar1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitt schema";
            Activated += Homepage_Activated;
            Load += Homepage_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void allaBeställningarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem beställningarToolStripMenuItem;
        private ToolStripMenuItem beställningarToolStripMenuItem1;
        private ToolStripMenuItem nyBeställningToolStripMenuItem;
        private ToolStripMenuItem allaBeställningarToolStripMenuItem;
        private ToolStripMenuItem marealLagerToolStripMenuItem;
        private ToolStripMenuItem statistikToolStripMenuItem1;
        private ToolStripMenuItem loggaUtToolStripMenuItem1;
        private ToolStripMenuItem hattStatistikToolStripMenuItem;
        private ToolStripMenuItem kundStatistikToolStripMenuItem;
        private MonthCalendar monthCalendar1;
        private ListView listBoxMinaUppgifter;
        private RichTextBox richTextBoxVecka;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem hanteraMedarbetareToolStripMenuItem;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ListView ordrarList;
        private Label label5;
        private ToolStripMenuItem hanteraKunderToolStripMenuItem;
        private ListView lvOrderRadLista;
        private ColumnHeader OrderId;
        private ColumnHeader Kund;
        private ColumnHeader Datum;
        private ColumnHeader OrderRadId;
        private ColumnHeader Typ;
        private ColumnHeader Storlek;
        private ColumnHeader Status;
        private ColumnHeader Tilldelad;
        private ColumnHeader Pris;
        private Label label1;
        private Button btnTaBortTilldelning;
        private ColumnHeader KundNamn;
        private ColumnHeader HattTyp;
        private ColumnHeader SkapadDatum;
        private ColumnHeader TilldelningsDatum;
        private ColumnHeader RadOrderId;
        private Button btnForraVeckan;
        private Button btnNastaVeckan;
    }
}