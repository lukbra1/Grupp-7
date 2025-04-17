
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
            minaSidorToolStripMenuItem1 = new ToolStripMenuItem();
            minaUppgifterToolStripMenuItem = new ToolStripMenuItem();
            mittSchemaToolStripMenuItem = new ToolStripMenuItem();
            hanteraMedarbetareToolStripMenuItem = new ToolStripMenuItem();
            loggaUtToolStripMenuItem1 = new ToolStripMenuItem();
            monthCalendar1 = new MonthCalendar();
            listBoxDagens = new ListView();
            richTextBoxVecka = new RichTextBox();
            label1 = new Label();
            btnLäggTill = new Button();
            textBoxUppgift = new TextBox();
            btnVeckoöversikt = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 42);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(2108, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { beställningarToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(8, 2, 0, 2);
            menuStrip2.Size = new Size(2108, 42);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // beställningarToolStripMenuItem
            // 
            beställningarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beställningarToolStripMenuItem1, marealLagerToolStripMenuItem, statistikToolStripMenuItem1, minaSidorToolStripMenuItem1, hanteraMedarbetareToolStripMenuItem, loggaUtToolStripMenuItem1 });
            beställningarToolStripMenuItem.Name = "beställningarToolStripMenuItem";
            beställningarToolStripMenuItem.Size = new Size(56, 38);
            beställningarToolStripMenuItem.Text = "☰";
            beställningarToolStripMenuItem.Click += beställningarToolStripMenuItem_Click;
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
            // 
            // kundStatistikToolStripMenuItem
            // 
            kundStatistikToolStripMenuItem.Name = "kundStatistikToolStripMenuItem";
            kundStatistikToolStripMenuItem.Size = new Size(290, 44);
            kundStatistikToolStripMenuItem.Text = "Kund statistik";
            // 
            // minaSidorToolStripMenuItem1
            // 
            minaSidorToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { minaUppgifterToolStripMenuItem, mittSchemaToolStripMenuItem });
            minaSidorToolStripMenuItem1.Name = "minaSidorToolStripMenuItem1";
            minaSidorToolStripMenuItem1.Size = new Size(374, 44);
            minaSidorToolStripMenuItem1.Text = "Mina sidor";
            // 
            // minaUppgifterToolStripMenuItem
            // 
            minaUppgifterToolStripMenuItem.Name = "minaUppgifterToolStripMenuItem";
            minaUppgifterToolStripMenuItem.Size = new Size(307, 44);
            minaUppgifterToolStripMenuItem.Text = "Mina uppgifter";
            // 
            // mittSchemaToolStripMenuItem
            // 
            mittSchemaToolStripMenuItem.Name = "mittSchemaToolStripMenuItem";
            mittSchemaToolStripMenuItem.Size = new Size(307, 44);
            mittSchemaToolStripMenuItem.Text = "Mitt schema";
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
            monthCalendar1.Location = new Point(1279, 184);
            monthCalendar1.Margin = new Padding(10, 8, 10, 8);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // listBoxDagens
            // 
            listBoxDagens.Location = new Point(1729, 184);
            listBoxDagens.Margin = new Padding(3, 5, 3, 5);
            listBoxDagens.Name = "listBoxDagens";
            listBoxDagens.Size = new Size(324, 593);
            listBoxDagens.TabIndex = 4;
            listBoxDagens.UseCompatibleStateImageBehavior = false;
            // 
            // richTextBoxVecka
            // 
            richTextBoxVecka.Location = new Point(223, 142);
            richTextBoxVecka.Margin = new Padding(3, 5, 3, 5);
            richTextBoxVecka.Name = "richTextBoxVecka";
            richTextBoxVecka.Size = new Size(1010, 633);
            richTextBoxVecka.TabIndex = 5;
            richTextBoxVecka.Text = "";
            richTextBoxVecka.TextChanged += richTextBoxVecka_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1279, 621);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 7;
            label1.Text = "Lägg till ny uppgift";
            // 
            // btnLäggTill
            // 
            btnLäggTill.Location = new Point(1532, 730);
            btnLäggTill.Margin = new Padding(3, 5, 3, 5);
            btnLäggTill.Name = "btnLäggTill";
            btnLäggTill.Size = new Size(148, 46);
            btnLäggTill.TabIndex = 8;
            btnLäggTill.Text = "Lägg till";
            btnLäggTill.UseVisualStyleBackColor = true;
            btnLäggTill.Click += btnLäggTill_Click;
            // 
            // textBoxUppgift
            // 
            textBoxUppgift.Location = new Point(1279, 674);
            textBoxUppgift.Margin = new Padding(3, 5, 3, 5);
            textBoxUppgift.Name = "textBoxUppgift";
            textBoxUppgift.Size = new Size(404, 39);
            textBoxUppgift.TabIndex = 9;
            textBoxUppgift.TextChanged += textBoxUppgift_TextChanged;
            // 
            // btnVeckoöversikt
            // 
            btnVeckoöversikt.Location = new Point(1082, 781);
            btnVeckoöversikt.Margin = new Padding(3, 5, 3, 5);
            btnVeckoöversikt.Name = "btnVeckoöversikt";
            btnVeckoöversikt.Size = new Size(148, 46);
            btnVeckoöversikt.TabIndex = 10;
            btnVeckoöversikt.Text = "Uppdatera";
            btnVeckoöversikt.UseVisualStyleBackColor = true;
            btnVeckoöversikt.Click += btnVeckoöversikt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 94);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 11;
            label2.Text = "Schema översikt";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1279, 142);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 12;
            label3.Text = "Välj dag";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1729, 142);
            label4.Name = "label4";
            label4.Size = new Size(277, 32);
            label4.TabIndex = 13;
            label4.Text = "Se uppgifter på vald dag";
            label4.Click += label4_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2108, 883);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVeckoöversikt);
            Controls.Add(textBoxUppgift);
            Controls.Add(btnLäggTill);
            Controls.Add(label1);
            Controls.Add(richTextBoxVecka);
            Controls.Add(listBoxDagens);
            Controls.Add(monthCalendar1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitt schema";
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
        private ToolStripMenuItem minaSidorToolStripMenuItem1;
        private ToolStripMenuItem loggaUtToolStripMenuItem1;
        private ToolStripMenuItem hattStatistikToolStripMenuItem;
        private ToolStripMenuItem kundStatistikToolStripMenuItem;
        private ToolStripMenuItem minaUppgifterToolStripMenuItem;
        private ToolStripMenuItem mittSchemaToolStripMenuItem;
        private MonthCalendar monthCalendar1;
        private ListView listBoxDagens;
        private RichTextBox richTextBoxVecka;
        private Label label1;
        private Button btnLäggTill;
        private TextBox textBoxUppgift;
        private Button btnVeckoöversikt;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem hanteraMedarbetareToolStripMenuItem;
    }
}