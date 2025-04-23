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
            buttonFoljesedel = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSkapaFraktSedel
            // 
            btnSkapaFraktSedel.Location = new Point(744, 467);
            btnSkapaFraktSedel.Margin = new Padding(4, 3, 4, 3);
            btnSkapaFraktSedel.Name = "btnSkapaFraktSedel";
            btnSkapaFraktSedel.Size = new Size(217, 37);
            btnSkapaFraktSedel.TabIndex = 1;
            btnSkapaFraktSedel.Text = "Skapa Fraktsedel";
            btnSkapaFraktSedel.UseVisualStyleBackColor = true;
            btnSkapaFraktSedel.Click += btnSkapaFraktSedel_Click;
            // 
            // btnRedigera
            // 
            btnRedigera.Location = new Point(744, 407);
            btnRedigera.Margin = new Padding(4, 3, 4, 3);
            btnRedigera.Name = "btnRedigera";
            btnRedigera.Size = new Size(217, 37);
            btnRedigera.TabIndex = 2;
            btnRedigera.Text = "Redigera Beställning";
            btnRedigera.UseVisualStyleBackColor = true;
            btnRedigera.Click += btnRedigera_Click;
            // 
            // lvAlla
            // 
            lvAlla.Columns.AddRange(new ColumnHeader[] { OrderId, Skapad, Status, Express, Pris });
            lvAlla.FullRowSelect = true;
            lvAlla.Location = new Point(46, 60);
            lvAlla.Name = "lvAlla";
            lvAlla.Size = new Size(680, 444);
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
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiibakaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1457, 35);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiibakaToolStripMenuItem
            // 
            tiibakaToolStripMenuItem.Name = "tiibakaToolStripMenuItem";
            tiibakaToolStripMenuItem.Size = new Size(87, 29);
            tiibakaToolStripMenuItem.Text = "Tillbaka";
            tiibakaToolStripMenuItem.Click += tiibakaToolStripMenuItem_Click;
            // 
            // buttonFoljesedel
            // 
            buttonFoljesedel.Location = new Point(744, 329);
            buttonFoljesedel.Margin = new Padding(4, 3, 4, 3);
            buttonFoljesedel.Name = "buttonFoljesedel";
            buttonFoljesedel.Size = new Size(217, 37);
            buttonFoljesedel.TabIndex = 5;
            buttonFoljesedel.Text = "Skapa Följesedel";
            buttonFoljesedel.UseVisualStyleBackColor = true;
            buttonFoljesedel.Click += buttonFoljesedel_Click;
            // 
            // AllaBeställningar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 788);
            Controls.Add(buttonFoljesedel);
            Controls.Add(lvAlla);
            Controls.Add(btnRedigera);
            Controls.Add(btnSkapaFraktSedel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
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
        private Button buttonFoljesedel;
    }
}