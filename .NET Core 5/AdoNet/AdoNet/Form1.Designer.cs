﻿namespace AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListUrunler = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ListUrunler
            // 
            ListUrunler.FormattingEnabled = true;
            ListUrunler.ItemHeight = 20;
            ListUrunler.Location = new System.Drawing.Point(35, 65);
            ListUrunler.Name = "ListUrunler";
            ListUrunler.Size = new System.Drawing.Size(386, 284);
            ListUrunler.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(390, 17);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "kategoriler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ListUrunler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox ListUrunler;
        private System.Windows.Forms.Button button1;
    }
}
