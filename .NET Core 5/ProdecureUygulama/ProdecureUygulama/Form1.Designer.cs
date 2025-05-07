namespace ProdecureUygulama
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            txtUrunadi = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nudFiyat = new System.Windows.Forms.NumericUpDown();
            nudStok = new System.Windows.Forms.NumericUpDown();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnEkle = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "ÜrünAdı";
            // 
            // txtUrunadi
            // 
            txtUrunadi.Location = new System.Drawing.Point(25, 51);
            txtUrunadi.Name = "txtUrunadi";
            txtUrunadi.Size = new System.Drawing.Size(125, 27);
            txtUrunadi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(168, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Fiyat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(344, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 20);
            label3.TabIndex = 0;
            label3.Text = "Stok";
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new System.Drawing.Point(168, 52);
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new System.Drawing.Size(150, 27);
            nudFiyat.TabIndex = 3;
            // 
            // nudStok
            // 
            nudStok.Location = new System.Drawing.Point(344, 52);
            nudStok.Name = "nudStok";
            nudStok.Size = new System.Drawing.Size(150, 27);
            nudStok.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new System.Drawing.Point(-5, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(597, 344);
            dataGridView1.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new System.Drawing.Point(528, 49);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(94, 29);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { silToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(nudStok);
            Controls.Add(nudFiyat);
            Controls.Add(label2);
            Controls.Add(txtUrunadi);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}
