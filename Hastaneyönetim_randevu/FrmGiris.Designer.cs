namespace Hastaneyönetim_randevu
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.btn_hastagirisi = new System.Windows.Forms.Button();
            this.btn_doktorgirisi = new System.Windows.Forms.Button();
            this.btn_sekretergirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hastagirisi
            // 
            this.btn_hastagirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hastagirisi.BackgroundImage")));
            this.btn_hastagirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hastagirisi.Location = new System.Drawing.Point(12, 104);
            this.btn_hastagirisi.Name = "btn_hastagirisi";
            this.btn_hastagirisi.Size = new System.Drawing.Size(150, 102);
            this.btn_hastagirisi.TabIndex = 0;
            this.btn_hastagirisi.UseVisualStyleBackColor = true;
            this.btn_hastagirisi.Click += new System.EventHandler(this.btn_hastagirisi_Click);
            // 
            // btn_doktorgirisi
            // 
            this.btn_doktorgirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktorgirisi.BackgroundImage")));
            this.btn_doktorgirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktorgirisi.Location = new System.Drawing.Point(168, 104);
            this.btn_doktorgirisi.Name = "btn_doktorgirisi";
            this.btn_doktorgirisi.Size = new System.Drawing.Size(150, 102);
            this.btn_doktorgirisi.TabIndex = 1;
            this.btn_doktorgirisi.UseVisualStyleBackColor = true;
            this.btn_doktorgirisi.Click += new System.EventHandler(this.btn_doktorgirisi_Click);
            // 
            // btn_sekretergirisi
            // 
            this.btn_sekretergirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sekretergirisi.BackgroundImage")));
            this.btn_sekretergirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sekretergirisi.Location = new System.Drawing.Point(322, 104);
            this.btn_sekretergirisi.Name = "btn_sekretergirisi";
            this.btn_sekretergirisi.Size = new System.Drawing.Size(150, 102);
            this.btn_sekretergirisi.TabIndex = 2;
            this.btn_sekretergirisi.UseVisualStyleBackColor = true;
            this.btn_sekretergirisi.Click += new System.EventHandler(this.btn_sekretergirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA GİRİŞİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR GİRİŞİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER GİRİŞİ";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sekretergirisi);
            this.Controls.Add(this.btn_doktorgirisi);
            this.Controls.Add(this.btn_hastagirisi);
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.Text = "Giriş Şekli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hastagirisi;
        private System.Windows.Forms.Button btn_doktorgirisi;
        private System.Windows.Forms.Button btn_sekretergirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

