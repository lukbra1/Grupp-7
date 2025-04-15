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
            SuspendLayout();
            // 
            // btnSkapaFraktSedel
            // 
            btnSkapaFraktSedel.Location = new Point(967, 598);
            btnSkapaFraktSedel.Margin = new Padding(5);
            btnSkapaFraktSedel.Name = "btnSkapaFraktSedel";
            btnSkapaFraktSedel.Size = new Size(283, 46);
            btnSkapaFraktSedel.TabIndex = 1;
            btnSkapaFraktSedel.Text = "Skapa Fraktsedel";
            btnSkapaFraktSedel.UseVisualStyleBackColor = true;
            btnSkapaFraktSedel.Click += btnSkapaFraktSedel_Click;
            // 
            // btnRedigera
            // 
            btnRedigera.Location = new Point(967, 522);
            btnRedigera.Margin = new Padding(5);
            btnRedigera.Name = "btnRedigera";
            btnRedigera.Size = new Size(283, 46);
            btnRedigera.TabIndex = 2;
            btnRedigera.Text = "Redigera Beställning";
            btnRedigera.UseVisualStyleBackColor = true;
            btnRedigera.Click += btnRedigera_Click;
            // 
            // lvAlla
            // 
            lvAlla.Columns.AddRange(new ColumnHeader[] { OrderId, Skapad, Status, Express, Pris });
            lvAlla.FullRowSelect = true;
            lvAlla.Location = new Point(59, 77);
            lvAlla.Name = "lvAlla";
            lvAlla.Size = new Size(883, 567);
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
            // AllaBeställningar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(lvAlla);
            Controls.Add(btnRedigera);
            Controls.Add(btnSkapaFraktSedel);
            Margin = new Padding(5);
            Name = "AllaBeställningar";
            Text = "AllaBeställningar";
            Load += AllaBeställningar_Load;
            ResumeLayout(false);
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
    }
}