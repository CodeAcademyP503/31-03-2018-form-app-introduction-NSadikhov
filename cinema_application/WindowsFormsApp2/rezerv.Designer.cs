namespace WindowsFormsApp2
{
    partial class rezerv
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
            this.new_rezerv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seans = new System.Windows.Forms.TextBox();
            this.azn = new System.Windows.Forms.TextBox();
            this.yerler = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // new_rezerv
            // 
            this.new_rezerv.Location = new System.Drawing.Point(55, 175);
            this.new_rezerv.Name = "new_rezerv";
            this.new_rezerv.Size = new System.Drawing.Size(251, 23);
            this.new_rezerv.TabIndex = 20;
            this.new_rezerv.Text = "Yeni Rezervation";
            this.new_rezerv.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "- Seans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "- AZN odenilecek mebleg.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "- Nomreli yerler rezerv edildi.";
            // 
            // seans
            // 
            this.seans.Location = new System.Drawing.Point(55, 119);
            this.seans.Name = "seans";
            this.seans.Size = new System.Drawing.Size(100, 20);
            this.seans.TabIndex = 16;
            // 
            // azn
            // 
            this.azn.Location = new System.Drawing.Point(55, 82);
            this.azn.Name = "azn";
            this.azn.Size = new System.Drawing.Size(100, 20);
            this.azn.TabIndex = 15;
            // 
            // yerler
            // 
            this.yerler.Location = new System.Drawing.Point(55, 44);
            this.yerler.Name = "yerler";
            this.yerler.Size = new System.Drawing.Size(100, 20);
            this.yerler.TabIndex = 14;
            // 
            // rezerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(360, 242);
            this.Controls.Add(this.new_rezerv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seans);
            this.Controls.Add(this.azn);
            this.Controls.Add(this.yerler);
            this.Name = "rezerv";
            this.Text = "rezerv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_rezerv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seans;
        private System.Windows.Forms.TextBox azn;
        private System.Windows.Forms.TextBox yerler;
    }
}