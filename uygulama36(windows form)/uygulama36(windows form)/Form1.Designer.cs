
namespace uygulama36_windows_form_
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.btnFail1 = new System.Windows.Forms.Button();
            this.btnFail3 = new System.Windows.Forms.Button();
            this.btnFail2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.White;
            this.btnClick.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClick.Location = new System.Drawing.Point(175, 186);
            this.btnClick.Margin = new System.Windows.Forms.Padding(5);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(237, 94);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "OK";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            this.btnClick.MouseLeave += new System.EventHandler(this.btnClick_MouseLeave);
            this.btnClick.MouseHover += new System.EventHandler(this.btnClick_MouseHover);
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(22, 30);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(124, 41);
            this.btnSuccess.TabIndex = 1;
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.MouseEnter += new System.EventHandler(this.btnSuccess_MouseEnter);
            // 
            // btnFail1
            // 
            this.btnFail1.Location = new System.Drawing.Point(428, 30);
            this.btnFail1.Name = "btnFail1";
            this.btnFail1.Size = new System.Drawing.Size(111, 41);
            this.btnFail1.TabIndex = 1;
            this.btnFail1.UseVisualStyleBackColor = true;
            this.btnFail1.MouseEnter += new System.EventHandler(this.btnFail1_MouseEnter);
            // 
            // btnFail3
            // 
            this.btnFail3.Location = new System.Drawing.Point(428, 571);
            this.btnFail3.Name = "btnFail3";
            this.btnFail3.Size = new System.Drawing.Size(111, 41);
            this.btnFail3.TabIndex = 1;
            this.btnFail3.UseVisualStyleBackColor = true;
            this.btnFail3.MouseEnter += new System.EventHandler(this.btnFail3_MouseEnter);
            // 
            // btnFail2
            // 
            this.btnFail2.Location = new System.Drawing.Point(35, 571);
            this.btnFail2.Name = "btnFail2";
            this.btnFail2.Size = new System.Drawing.Size(111, 41);
            this.btnFail2.TabIndex = 1;
            this.btnFail2.UseVisualStyleBackColor = true;
            this.btnFail2.MouseEnter += new System.EventHandler(this.btnFail2_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1115, 963);
            this.Controls.Add(this.btnFail2);
            this.Controls.Add(this.btnFail3);
            this.Controls.Add(this.btnFail1);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.btnClick);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.Button btnFail1;
        private System.Windows.Forms.Button btnFail3;
        private System.Windows.Forms.Button btnFail2;
    }
}

