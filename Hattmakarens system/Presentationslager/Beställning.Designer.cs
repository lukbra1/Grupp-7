﻿namespace Hattmakarens_system.Presentationslager
{
    partial class Beställning
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 23);
            button1.Name = "button1";
            button1.Size = new Size(311, 46);
            button1.TabIndex = 0;
            button1.Text = "Lägg till ny hatt";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1907, 841);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Slutför Beställning";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(867, 23);
            label1.Name = "label1";
            label1.Size = new Size(348, 32);
            label1.TabIndex = 2;
            label1.Text = "Denna sida visar din \"varukorg\"";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(254, 125);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1724, 676);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Beställning
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2202, 955);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Beställning";
            Text = "Beställning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private ListBox listBox1;
    }
}