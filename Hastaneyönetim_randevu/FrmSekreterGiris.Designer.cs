namespace Hastaneyönetim_randevu
{
    partial class FrmSekreterGiris
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
            this.hgiris = new System.Windows.Forms.Button();
            this.txthsifre = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.hkayıt = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hgiris
            // 
            this.hgiris.Location = new System.Drawing.Point(163, 185);
            this.hgiris.Name = "hgiris";
            this.hgiris.Size = new System.Drawing.Size(75, 23);
            this.hgiris.TabIndex = 14;
            this.hgiris.Text = "Giriş Yap";
            this.hgiris.UseVisualStyleBackColor = true;
            this.hgiris.Click += new System.EventHandler(this.hgiris_Click);
            // 
            // txthsifre
            // 
            this.txthsifre.Location = new System.Drawing.Point(150, 156);
            this.txthsifre.Name = "txthsifre";
            this.txthsifre.Size = new System.Drawing.Size(100, 20);
            this.txthsifre.TabIndex = 13;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(150, 123);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(100, 20);
            this.msktc.TabIndex = 12;
            // 
            // hkayıt
            // 
            this.hkayıt.AutoSize = true;
            this.hkayıt.Location = new System.Drawing.Point(272, 159);
            this.hkayıt.Name = "hkayıt";
            this.hkayıt.Size = new System.Drawing.Size(46, 13);
            this.hkayıt.TabIndex = 11;
            this.hkayıt.TabStop = true;
            this.hkayıt.Text = "Kayıt Ol!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC Kimlik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sekreter Giriş Paneli";
            // 
            // FrmSekreterGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 253);
            this.Controls.Add(this.hgiris);
            this.Controls.Add(this.txthsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.hkayıt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSekreterGiris";
            this.Text = "FrmSekreterGiris";
            this.Load += new System.EventHandler(this.FrmSekreterGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hgiris;
        private System.Windows.Forms.TextBox txthsifre;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.LinkLabel hkayıt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}