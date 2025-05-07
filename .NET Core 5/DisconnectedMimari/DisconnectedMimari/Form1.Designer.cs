namespace DisconnectedMimari
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            txtUrunAdi = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            nudFiyat = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            nudStok = new System.Windows.Forms.NumericUpDown();
            btnEkle = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            btnKategoriler = new System.Windows.Forms.Button();
            btnKaydet = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(9, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(725, 363);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı:";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new System.Drawing.Point(22, 42);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new System.Drawing.Size(125, 27);
            txtUrunAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(167, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiyat:";
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new System.Drawing.Point(167, 42);
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new System.Drawing.Size(150, 27);
            nudFiyat.TabIndex = 3;
            nudFiyat.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(332, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 20);
            label3.TabIndex = 1;
            label3.Text = "Stok";
            // 
            // nudStok
            // 
            nudStok.Location = new System.Drawing.Point(332, 42);
            nudStok.Name = "nudStok";
            nudStok.Size = new System.Drawing.Size(150, 27);
            nudStok.TabIndex = 3;
            nudStok.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new System.Drawing.Point(593, 42);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnKategoriler
            // 
            btnKategoriler.Location = new System.Drawing.Point(693, 47);
            btnKategoriler.Name = "btnKategoriler";
            btnKategoriler.Size = new System.Drawing.Size(94, 22);
            btnKategoriler.TabIndex = 5;
            btnKategoriler.Text = "Kategoriler";
            btnKategoriler.UseVisualStyleBackColor = true;
            btnKategoriler.Click += btnKategoriler_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new System.Drawing.Point(593, 7);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(94, 29);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
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
            silToolStripMenuItem.Text = "sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnKaydet);
            Controls.Add(btnKategoriler);
            Controls.Add(btnEkle);
            Controls.Add(nudStok);
            Controls.Add(nudFiyat);
            Controls.Add(txtUrunAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}
