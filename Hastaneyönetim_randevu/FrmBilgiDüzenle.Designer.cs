namespace Hastaneyönetim_randevu
{
    partial class FrmBilgiDüzenle
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
            this.cmbhkcinsiyet = new System.Windows.Forms.ComboBox();
            this.txthksoyad = new System.Windows.Forms.TextBox();
            this.txthksifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskhktc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskhktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_bilgiguncelle = new System.Windows.Forms.Button();
            this.txthkad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbhkcinsiyet
            // 
            this.cmbhkcinsiyet.FormattingEnabled = true;
            this.cmbhkcinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan",
            "Belirtmek İstemiyorum"});
            this.cmbhkcinsiyet.Location = new System.Drawing.Point(123, 179);
            this.cmbhkcinsiyet.Name = "cmbhkcinsiyet";
            this.cmbhkcinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmbhkcinsiyet.TabIndex = 6;
            // 
            // txthksoyad
            // 
            this.txthksoyad.Location = new System.Drawing.Point(123, 75);
            this.txthksoyad.Name = "txthksoyad";
            this.txthksoyad.Size = new System.Drawing.Size(100, 20);
            this.txthksoyad.TabIndex = 2;
            // 
            // txthksifre
            // 
            this.txthksifre.Location = new System.Drawing.Point(123, 153);
            this.txthksifre.Name = "txthksifre";
            this.txthksifre.Size = new System.Drawing.Size(100, 20);
            this.txthksifre.TabIndex = 5;
            this.txthksifre.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Cinsiyet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Soyad:";
            // 
            // mskhktc
            // 
            this.mskhktc.Location = new System.Drawing.Point(123, 101);
            this.mskhktc.Mask = "00000000000";
            this.mskhktc.Name = "mskhktc";
            this.mskhktc.Size = new System.Drawing.Size(100, 20);
            this.mskhktc.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Telefon:";
            // 
            // mskhktelefon
            // 
            this.mskhktelefon.Location = new System.Drawing.Point(123, 127);
            this.mskhktelefon.Mask = "(999) 000-0000";
            this.mskhktelefon.Name = "mskhktelefon";
            this.mskhktelefon.Size = new System.Drawing.Size(100, 20);
            this.mskhktelefon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "TC Kimlik:";
            // 
            // btn_bilgiguncelle
            // 
            this.btn_bilgiguncelle.Location = new System.Drawing.Point(123, 215);
            this.btn_bilgiguncelle.Name = "btn_bilgiguncelle";
            this.btn_bilgiguncelle.Size = new System.Drawing.Size(100, 30);
            this.btn_bilgiguncelle.TabIndex = 7;
            this.btn_bilgiguncelle.Text = "Güncelle";
            this.btn_bilgiguncelle.UseVisualStyleBackColor = true;
            this.btn_bilgiguncelle.Click += new System.EventHandler(this.btn_bilgiguncelle_Click);
            // 
            // txthkad
            // 
            this.txthkad.Location = new System.Drawing.Point(123, 49);
            this.txthkad.Name = "txthkad";
            this.txthkad.Size = new System.Drawing.Size(100, 20);
            this.txthkad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ad:";
            // 
            // FrmBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 286);
            this.Controls.Add(this.cmbhkcinsiyet);
            this.Controls.Add(this.txthksoyad);
            this.Controls.Add(this.txthksifre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskhktc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskhktelefon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_bilgiguncelle);
            this.Controls.Add(this.txthkad);
            this.Controls.Add(this.label3);
            this.Name = "FrmBilgiDüzenle";
            this.Text = "FrmBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbhkcinsiyet;
        private System.Windows.Forms.TextBox txthksoyad;
        private System.Windows.Forms.TextBox txthksifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskhktc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskhktelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_bilgiguncelle;
        private System.Windows.Forms.TextBox txthkad;
        private System.Windows.Forms.Label label3;
    }
}