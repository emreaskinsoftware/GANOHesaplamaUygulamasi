namespace Universite_GANO_Hesaplama
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblDersler = new System.Windows.Forms.Label();
            this.textDersAdı = new System.Windows.Forms.TextBox();
            this.textKredi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHarfNotu = new System.Windows.Forms.ComboBox();
            this.DataDersler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(632, 392);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDersler
            // 
            this.lblDersler.AutoSize = true;
            this.lblDersler.Location = new System.Drawing.Point(12, 37);
            this.lblDersler.Name = "lblDersler";
            this.lblDersler.Size = new System.Drawing.Size(58, 13);
            this.lblDersler.TabIndex = 2;
            this.lblDersler.Text = "Dersin Adı:";
            // 
            // textDersAdı
            // 
            this.textDersAdı.Location = new System.Drawing.Point(76, 33);
            this.textDersAdı.Name = "textDersAdı";
            this.textDersAdı.Size = new System.Drawing.Size(223, 20);
            this.textDersAdı.TabIndex = 3;
            // 
            // textKredi
            // 
            this.textKredi.Location = new System.Drawing.Point(385, 33);
            this.textKredi.Name = "textKredi";
            this.textKredi.Size = new System.Drawing.Size(91, 20);
            this.textKredi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dersin Kredisi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(685, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(713, 392);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Harf Notu: ";
            // 
            // comboBoxHarfNotu
            // 
            this.comboBoxHarfNotu.FormattingEnabled = true;
            this.comboBoxHarfNotu.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC",
            "FF"});
            this.comboBoxHarfNotu.Location = new System.Drawing.Point(547, 30);
            this.comboBoxHarfNotu.Name = "comboBoxHarfNotu";
            this.comboBoxHarfNotu.Size = new System.Drawing.Size(119, 21);
            this.comboBoxHarfNotu.TabIndex = 10;
            // 
            // DataDersler
            // 
            this.DataDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDersler.Location = new System.Drawing.Point(15, 69);
            this.DataDersler.Name = "DataDersler";
            this.DataDersler.Size = new System.Drawing.Size(773, 317);
            this.DataDersler.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataDersler);
            this.Controls.Add(this.comboBoxHarfNotu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKredi);
            this.Controls.Add(this.textDersAdı);
            this.Controls.Add(this.lblDersler);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblDersler;
        private System.Windows.Forms.TextBox textDersAdı;
        private System.Windows.Forms.TextBox textKredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHarfNotu;
        private System.Windows.Forms.DataGridView DataDersler;
    }
}

