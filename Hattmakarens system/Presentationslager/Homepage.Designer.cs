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
            seAlltMaterialToolStripMenuItem = new ToolStripMenuItem();
            marialbeställningToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1135, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { beställningarToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(4, 1, 0, 1);
            menuStrip2.Size = new Size(1135, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // beställningarToolStripMenuItem
            // 
            beställningarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beställningarToolStripMenuItem1, marealLagerToolStripMenuItem, statistikToolStripMenuItem1, minaSidorToolStripMenuItem1, hanteraMedarbetareToolStripMenuItem, loggaUtToolStripMenuItem1 });
            beställningarToolStripMenuItem.Name = "beställningarToolStripMenuItem";
            beställningarToolStripMenuItem.Size = new Size(30, 22);
            beställningarToolStripMenuItem.Text = "☰";
            beställningarToolStripMenuItem.Click += beställningarToolStripMenuItem_Click;
            // 
            // beställningarToolStripMenuItem1
            // 
            beställningarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { nyBeställningToolStripMenuItem, allaBeställningarToolStripMenuItem });
            beställningarToolStripMenuItem1.Name = "beställningarToolStripMenuItem1";
            beställningarToolStripMenuItem1.Size = new Size(186, 22);
            beställningarToolStripMenuItem1.Text = "Beställningar";
            // 
            // nyBeställningToolStripMenuItem
            // 
            nyBeställningToolStripMenuItem.Name = "nyBeställningToolStripMenuItem";
            nyBeställningToolStripMenuItem.Size = new Size(165, 22);
            nyBeställningToolStripMenuItem.Text = "Ny beställning";
            nyBeställningToolStripMenuItem.Click += nyBeställningToolStripMenuItem_Click;
            // 
            // allaBeställningarToolStripMenuItem
            // 
            allaBeställningarToolStripMenuItem.Name = "allaBeställningarToolStripMenuItem";
            allaBeställningarToolStripMenuItem.Size = new Size(165, 22);
            allaBeställningarToolStripMenuItem.Text = "Alla beställningar";
            // 
            // marealLagerToolStripMenuItem
            // 
            marealLagerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seAlltMaterialToolStripMenuItem, marialbeställningToolStripMenuItem });
            marealLagerToolStripMenuItem.Name = "marealLagerToolStripMenuItem";
            marealLagerToolStripMenuItem.Size = new Size(186, 22);
            marealLagerToolStripMenuItem.Text = "Material lager";
            // 
            // seAlltMaterialToolStripMenuItem
            // 
            seAlltMaterialToolStripMenuItem.Name = "seAlltMaterialToolStripMenuItem";
            seAlltMaterialToolStripMenuItem.Size = new Size(180, 22);
            seAlltMaterialToolStripMenuItem.Text = "Se allt material";
            seAlltMaterialToolStripMenuItem.Click += seAlltMaterialToolStripMenuItem_Click;
            // 
            // marialbeställningToolStripMenuItem
            // 
            marialbeställningToolStripMenuItem.Name = "marialbeställningToolStripMenuItem";
            marialbeställningToolStripMenuItem.Size = new Size(180, 22);
            marialbeställningToolStripMenuItem.Text = "Material beställning";
            // 
            // statistikToolStripMenuItem1
            // 
            statistikToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { hattStatistikToolStripMenuItem, kundStatistikToolStripMenuItem });
            statistikToolStripMenuItem1.Name = "statistikToolStripMenuItem1";
            statistikToolStripMenuItem1.Size = new Size(186, 22);
            statistikToolStripMenuItem1.Text = "Statistik";
            // 
            // hattStatistikToolStripMenuItem
            // 
            hattStatistikToolStripMenuItem.Name = "hattStatistikToolStripMenuItem";
            hattStatistikToolStripMenuItem.Size = new Size(145, 22);
            hattStatistikToolStripMenuItem.Text = "Hatt statistik";
            // 
            // kundStatistikToolStripMenuItem
            // 
            kundStatistikToolStripMenuItem.Name = "kundStatistikToolStripMenuItem";
            kundStatistikToolStripMenuItem.Size = new Size(145, 22);
            kundStatistikToolStripMenuItem.Text = "Kund statistik";
            // 
            // minaSidorToolStripMenuItem1
            // 
            minaSidorToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { minaUppgifterToolStripMenuItem, mittSchemaToolStripMenuItem });
            minaSidorToolStripMenuItem1.Name = "minaSidorToolStripMenuItem1";
            minaSidorToolStripMenuItem1.Size = new Size(186, 22);
            minaSidorToolStripMenuItem1.Text = "Mina sidor";
            // 
            // minaUppgifterToolStripMenuItem
            // 
            minaUppgifterToolStripMenuItem.Name = "minaUppgifterToolStripMenuItem";
            minaUppgifterToolStripMenuItem.Size = new Size(153, 22);
            minaUppgifterToolStripMenuItem.Text = "Mina uppgifter";
            // 
            // mittSchemaToolStripMenuItem
            // 
            mittSchemaToolStripMenuItem.Name = "mittSchemaToolStripMenuItem";
            mittSchemaToolStripMenuItem.Size = new Size(153, 22);
            mittSchemaToolStripMenuItem.Text = "Mitt schema";
            // 
            // hanteraMedarbetareToolStripMenuItem
            // 
            hanteraMedarbetareToolStripMenuItem.Name = "hanteraMedarbetareToolStripMenuItem";
            hanteraMedarbetareToolStripMenuItem.Size = new Size(186, 22);
            hanteraMedarbetareToolStripMenuItem.Text = "Hantera medarbetare";
            // 
            // loggaUtToolStripMenuItem1
            // 
            loggaUtToolStripMenuItem1.Name = "loggaUtToolStripMenuItem1";
            loggaUtToolStripMenuItem1.Size = new Size(186, 22);
            loggaUtToolStripMenuItem1.Text = "Logga ut";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(689, 86);
            monthCalendar1.Margin = new Padding(5, 4, 5, 4);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // listBoxDagens
            // 
            listBoxDagens.Location = new Point(931, 86);
            listBoxDagens.Margin = new Padding(2);
            listBoxDagens.Name = "listBoxDagens";
            listBoxDagens.Size = new Size(176, 280);
            listBoxDagens.TabIndex = 4;
            listBoxDagens.UseCompatibleStateImageBehavior = false;
            // 
            // richTextBoxVecka
            // 
            richTextBoxVecka.Location = new Point(120, 67);
            richTextBoxVecka.Margin = new Padding(2);
            richTextBoxVecka.Name = "richTextBoxVecka";
            richTextBoxVecka.Size = new Size(546, 299);
            richTextBoxVecka.TabIndex = 5;
            richTextBoxVecka.Text = "";
            richTextBoxVecka.TextChanged += richTextBoxVecka_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(689, 291);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 7;
            label1.Text = "Lägg till ny uppgift";
            // 
            // btnLäggTill
            // 
            btnLäggTill.Location = new Point(825, 342);
            btnLäggTill.Margin = new Padding(2);
            btnLäggTill.Name = "btnLäggTill";
            btnLäggTill.Size = new Size(80, 22);
            btnLäggTill.TabIndex = 8;
            btnLäggTill.Text = "Lägg till";
            btnLäggTill.UseVisualStyleBackColor = true;
            btnLäggTill.Click += btnLäggTill_Click;
            // 
            // textBoxUppgift
            // 
            textBoxUppgift.Location = new Point(689, 316);
            textBoxUppgift.Margin = new Padding(2);
            textBoxUppgift.Name = "textBoxUppgift";
            textBoxUppgift.Size = new Size(219, 23);
            textBoxUppgift.TabIndex = 9;
            textBoxUppgift.TextChanged += textBoxUppgift_TextChanged;
            // 
            // btnVeckoöversikt
            // 
            btnVeckoöversikt.Location = new Point(583, 366);
            btnVeckoöversikt.Margin = new Padding(2);
            btnVeckoöversikt.Name = "btnVeckoöversikt";
            btnVeckoöversikt.Size = new Size(80, 22);
            btnVeckoöversikt.TabIndex = 10;
            btnVeckoöversikt.Text = "Uppdatera";
            btnVeckoöversikt.UseVisualStyleBackColor = true;
            btnVeckoöversikt.Click += btnVeckoöversikt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 11;
            label2.Text = "Schema översikt";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(689, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "Välj dag";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(931, 67);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 13;
            label4.Text = "Se uppgifter på vald dag";
            label4.Click += label4_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1135, 414);
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
            Margin = new Padding(2);
            Name = "Homepage";
            Text = "Mitt schema";
            Load += Homepage_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem beställningarToolStripMenuItem;
        private ToolStripMenuItem beställningarToolStripMenuItem1;
        private ToolStripMenuItem nyBeställningToolStripMenuItem;
        private ToolStripMenuItem allaBeställningarToolStripMenuItem;
        private ToolStripMenuItem marealLagerToolStripMenuItem;
        private ToolStripMenuItem seAlltMaterialToolStripMenuItem;
        private ToolStripMenuItem statistikToolStripMenuItem1;
        private ToolStripMenuItem minaSidorToolStripMenuItem1;
        private ToolStripMenuItem loggaUtToolStripMenuItem1;
        private ToolStripMenuItem marialbeställningToolStripMenuItem;
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