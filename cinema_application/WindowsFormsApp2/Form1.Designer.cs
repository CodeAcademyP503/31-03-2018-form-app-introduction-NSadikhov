namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnseans12 = new System.Windows.Forms.Button();
            this.btnseans20 = new System.Windows.Forms.Button();
            this.btnrezerv = new System.Windows.Forms.Button();
            this.zal1 = new System.Windows.Forms.Label();
            this.btnexit1 = new System.Windows.Forms.Button();
            this.btnexit3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnseans12
            // 
            this.btnseans12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnseans12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseans12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseans12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnseans12.Location = new System.Drawing.Point(29, 343);
            this.btnseans12.Name = "btnseans12";
            this.btnseans12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnseans12.Size = new System.Drawing.Size(125, 24);
            this.btnseans12.TabIndex = 3;
            this.btnseans12.Text = "SEANS: 12:00";
            this.btnseans12.UseVisualStyleBackColor = false;
            // 
            // btnseans20
            // 
            this.btnseans20.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnseans20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseans20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseans20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnseans20.Location = new System.Drawing.Point(179, 343);
            this.btnseans20.Name = "btnseans20";
            this.btnseans20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnseans20.Size = new System.Drawing.Size(125, 24);
            this.btnseans20.TabIndex = 4;
            this.btnseans20.Text = "SEANS: 20:00";
            this.btnseans20.UseVisualStyleBackColor = false;
            // 
            // btnrezerv
            // 
            this.btnrezerv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrezerv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrezerv.Location = new System.Drawing.Point(574, 344);
            this.btnrezerv.Name = "btnrezerv";
            this.btnrezerv.Size = new System.Drawing.Size(198, 23);
            this.btnrezerv.TabIndex = 5;
            this.btnrezerv.Text = "REZERV ET";
            this.btnrezerv.UseVisualStyleBackColor = true;
            // 
            // zal1
            // 
            this.zal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zal1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zal1.Location = new System.Drawing.Point(242, -1);
            this.zal1.Name = "zal1";
            this.zal1.Size = new System.Drawing.Size(333, 40);
            this.zal1.TabIndex = 6;
            this.zal1.Text = "ZAL1";
            this.zal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnexit1
            // 
            this.btnexit1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnexit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit1.Location = new System.Drawing.Point(-4, 68);
            this.btnexit1.Name = "btnexit1";
            this.btnexit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnexit1.Size = new System.Drawing.Size(22, 65);
            this.btnexit1.TabIndex = 8;
            this.btnexit1.Text = "EXIT";
            this.btnexit1.UseVisualStyleBackColor = false;
            // 
            // btnexit3
            // 
            this.btnexit3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnexit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit3.Location = new System.Drawing.Point(783, 68);
            this.btnexit3.Name = "btnexit3";
            this.btnexit3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnexit3.Size = new System.Drawing.Size(22, 65);
            this.btnexit3.TabIndex = 8;
            this.btnexit3.Text = "EXIT";
            this.btnexit3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(801, 386);
            this.Controls.Add(this.btnexit3);
            this.Controls.Add(this.btnexit1);
            this.Controls.Add(this.zal1);
            this.Controls.Add(this.btnrezerv);
            this.Controls.Add(this.btnseans20);
            this.Controls.Add(this.btnseans12);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnseans12;
        private System.Windows.Forms.Button btnseans20;
        private System.Windows.Forms.Button btnrezerv;
        private System.Windows.Forms.Label zal1;
        private System.Windows.Forms.Button btnexit1;
        private System.Windows.Forms.Button btnexit3;
    }
}

