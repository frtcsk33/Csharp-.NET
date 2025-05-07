namespace ProdecureUygulama
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            txtAdi = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtTanim = new System.Windows.Forms.TextBox();
            btnEkle = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(77, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "KategoriAdı:";
            // 
            // txtAdi
            // 
            txtAdi.Location = new System.Drawing.Point(77, 67);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new System.Drawing.Size(125, 27);
            txtAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(281, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Tanımı";
            // 
            // txtTanim
            // 
            txtTanim.Location = new System.Drawing.Point(281, 67);
            txtTanim.Name = "txtTanim";
            txtTanim.Size = new System.Drawing.Size(125, 27);
            txtTanim.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new System.Drawing.Point(423, 65);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(94, 29);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new System.Drawing.Point(77, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(586, 294);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { silToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(93, 28);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            silToolStripMenuItem.Text = "sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // KategoriForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(txtTanim);
            Controls.Add(label2);
            Controls.Add(txtAdi);
            Controls.Add(label1);
            Name = "KategoriForm";
            Text = "KategoriForm";
            Load += KategoriForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTanim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}