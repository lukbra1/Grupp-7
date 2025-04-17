namespace Hattmakarens_system.Presentationslager
{
    partial class AllaBeställningar
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
            btnSkapaFraktSedel = new Button();
            btnRedigera = new Button();
            lvAlla = new ListView();
            OrderId = new ColumnHeader();
            Skapad = new ColumnHeader();
            Status = new ColumnHeader();
            Express = new ColumnHeader();
            Pris = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            tiibakaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSkapaFraktSedel
            // 
            btnSkapaFraktSedel.Location = new Point(521, 280);
            btnSkapaFraktSedel.Margin = new Padding(3, 2, 3, 2);
            btnSkapaFraktSedel.Name = "btnSkapaFraktSedel";
            btnSkapaFraktSedel.Size = new Size(152, 22);
            btnSkapaFraktSedel.TabIndex = 1;
            btnSkapaFraktSedel.Text = "Skapa Fraktsedel";
            btnSkapaFraktSedel.UseVisualStyleBackColor = true;
            btnSkapaFraktSedel.Click += btnSkapaFraktSedel_Click;
            // 
            // btnRedigera
            // 
            btnRedigera.Location = new Point(521, 244);
            btnRedigera.Margin = new Padding(3, 2, 3, 2);
            btnRedigera.Name = "btnRedigera";
            btnRedigera.Size = new Size(152, 22);
            btnRedigera.TabIndex = 2;
            btnRedigera.Text = "Redigera Beställning";
            btnRedigera.UseVisualStyleBackColor = true;
            btnRedigera.Click += btnRedigera_Click;
            // 
            // lvAlla
            // 
            lvAlla.Columns.AddRange(new ColumnHeader[] { OrderId, Skapad, Status, Express, Pris });
            lvAlla.FullRowSelect = true;
            lvAlla.Location = new Point(32, 36);
            lvAlla.Margin = new Padding(2);
            lvAlla.Name = "lvAlla";
            lvAlla.Size = new Size(477, 268);
            lvAlla.TabIndex = 3;
            lvAlla.UseCompatibleStateImageBehavior = false;
            lvAlla.View = View.Details;
            lvAlla.SelectedIndexChanged += lvAlla_SelectedIndexChanged;
            // 
            // OrderId
            // 
            OrderId.Text = "OrderId";
            OrderId.Width = 100;
            // 
            // Skapad
            // 
            Skapad.Text = "Skapad";
            Skapad.Width = 150;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 100;
            // 
            // Express
            // 
            Express.Text = "Express";
            Express.Width = 100;
            // 
            // Pris
            // 
            Pris.Text = "Pris";
            Pris.Width = 100;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiibakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1020, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiibakaToolStripMenuItem
            // 
            tiibakaToolStripMenuItem.Name = "tiibakaToolStripMenuItem";
            tiibakaToolStripMenuItem.Size = new Size(59, 20);
            tiibakaToolStripMenuItem.Text = "Tillbaka";
            tiibakaToolStripMenuItem.Click += tiibakaToolStripMenuItem_Click;
            // 
            // AllaBeställningar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 473);
            Controls.Add(lvAlla);
            Controls.Add(btnRedigera);
            Controls.Add(btnSkapaFraktSedel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AllaBeställningar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllaBeställningar";
            Load += AllaBeställningar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lblAllaBeställningar;
        private Button btnSkapaFraktSedel;
        private Button btnRedigera;
        private ListBox lblAlla;
        private ListView lvAlla;
        private ColumnHeader OrderId;
        private ColumnHeader Skapad;
        private ColumnHeader Status;
        private ColumnHeader Express;
        private ColumnHeader Pris;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiibakaToolStripMenuItem;
    }
}