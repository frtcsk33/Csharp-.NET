namespace DisconnectedMimari
{
    partial class KategoriForm
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            txtKategoriAdi = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtTanimi = new System.Windows.Forms.TextBox();
            btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(664, 309);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Kategori Adı:";
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new System.Drawing.Point(31, 31);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new System.Drawing.Size(125, 27);
            txtKategoriAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(207, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "tanımı:";
            // 
            // txtTanimi
            // 
            txtTanimi.Location = new System.Drawing.Point(207, 29);
            txtTanimi.Name = "txtTanimi";
            txtTanimi.Size = new System.Drawing.Size(125, 27);
            txtTanimi.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new System.Drawing.Point(371, 28);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(94, 29);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // KategoriForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnEkle);
            Controls.Add(txtTanimi);
            Controls.Add(label2);
            Controls.Add(txtKategoriAdi);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "KategoriForm";
            Text = "KategoriForm";
            Load += KategoriForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTanimi;
        private System.Windows.Forms.Button btnEkle;
    }
}