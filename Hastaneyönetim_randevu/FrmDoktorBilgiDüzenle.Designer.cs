namespace Hastaneyönetim_randevu
{
    partial class FrmDoktorBilgiDüzenle
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
            this.txthksoyad = new System.Windows.Forms.TextBox();
            this.txthksifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskhktc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txthkad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txthksoyad
            // 
            this.txthksoyad.Location = new System.Drawing.Point(92, 60);
            this.txthksoyad.Name = "txthksoyad";
            this.txthksoyad.Size = new System.Drawing.Size(100, 20);
            this.txthksoyad.TabIndex = 49;
            this.txthksoyad.TextChanged += new System.EventHandler(this.txthksoyad_TextChanged);
            // 
            // txthksifre
            // 
            this.txthksifre.Location = new System.Drawing.Point(92, 138);
            this.txthksifre.Name = "txthksifre";
            this.txthksifre.Size = new System.Drawing.Size(100, 20);
            this.txthksifre.TabIndex = 48;
            this.txthksifre.UseSystemPasswordChar = true;
            this.txthksifre.TextChanged += new System.EventHandler(this.txthksifre_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Soyad:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // mskhktc
            // 
            this.mskhktc.Location = new System.Drawing.Point(92, 86);
            this.mskhktc.Mask = "00000000000";
            this.mskhktc.Name = "mskhktc";
            this.mskhktc.Size = new System.Drawing.Size(100, 20);
            this.mskhktc.TabIndex = 46;
            this.mskhktc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskhktc_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Branş:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Şifre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "TC Kimlik:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txthkad
            // 
            this.txthkad.Location = new System.Drawing.Point(92, 34);
            this.txthkad.Name = "txthkad";
            this.txthkad.Size = new System.Drawing.Size(100, 20);
            this.txthkad.TabIndex = 41;
            this.txthkad.TextChanged += new System.EventHandler(this.txthkad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 51;
            this.button1.Text = "Bilgi Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txthksoyad);
            this.Controls.Add(this.txthksifre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskhktc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthkad);
            this.Controls.Add(this.label3);
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "FrmDoktorBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthksoyad;
        private System.Windows.Forms.TextBox txthksifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskhktc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthkad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}