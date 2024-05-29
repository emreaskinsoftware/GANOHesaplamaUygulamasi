using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universite_GANO_Hesaplama
{
    public partial class Form1 : Form
    {

        int ToplamKredi;
        double not;

        public Form1()
        {
            InitializeComponent();
            // DataGridView sütunlarını oluşturma
            DataDersler.Columns.Add("DersAdı", "Ders Adı");
            DataDersler.Columns.Add("Kredi", "Kredi");
            DataDersler.Columns.Add("HarfNotu", "Harf Notu");
            // Sütunların boyutunu otomatik olarak ayarla
            DataDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplamNot = 0;
            int toplamKredi = 0;

            // "Ders Kredileri" sütununun index'ini alın
            int krediSutunuIndex = DataDersler.Columns["Kredi"].Index;
            // "Harf notu sütununun index'ini alın
            int harfNotuSutunuIndex = DataDersler.Columns["HarfNotu"].Index;

            // Her satırdaki "Ders Kredileri" sütunundaki değerleri topla
            foreach (DataGridViewRow row in DataDersler.Rows)
            {
                // Hücrenin değerini alın
                if (row.Cells[krediSutunuIndex].Value != null && row.Cells[harfNotuSutunuIndex].Value != null)
                {
                    int kredi;
                    // Değeri int olarak dönüştür
                    if (int.TryParse(row.Cells[krediSutunuIndex].Value.ToString(), out kredi))
                    {
                        String harfNotu = row.Cells[harfNotuSutunuIndex].Value.ToString();

                        // Harf notunu dönüştür ve notu hesapla
                        switch (harfNotu)
                        {
                            case "AA":
                                toplamNot += kredi * 4.0;
                                break;
                            case "BA":
                                toplamNot += kredi * 3.5;
                                break;
                            case "BB":
                                toplamNot += kredi * 3.0;
                                break;
                            case "CB":
                                toplamNot += kredi * 2.5;
                                break;
                            case "CC":
                                toplamNot += kredi * 2.0;
                                break;
                            case "FF":
                                // FF notu durumunda krediye işlem yapmayız, toplam krediyi artırmalıyız
                                break;
                            default:
                                MessageBox.Show("Geçerli bir harf notu giriniz");
                                break;
                        }

                        // Değeri toplama ekle
                        toplamKredi += kredi;
                    }
                }
            }

            // Ortalama notu hesapla
            double ortalamaNot = toplamNot / toplamKredi;

            // Sonucu mesaj kutusunda göster
            MessageBox.Show("Toplam Kredi: " + toplamKredi + "\nOrtalama Not: " + ortalamaNot.ToString("0.00"));
        }








        private void btnEkle_Click(object sender, EventArgs e)
        {
            // TextBox'lardan değerleri al
            string dersAdı = textDersAdı.Text;
            int kredi;
            


            // Yaşı integer olarak doğrula
            if (int.TryParse(textKredi.Text, out kredi)) {
                String harfNotu = comboBoxHarfNotu.Text;
                harfNotu.ToUpper();

                if (harfNotu == "AA" || harfNotu == "BA" || harfNotu == "BB" || harfNotu == "CB" || harfNotu == "CC" || harfNotu == "FF")
                {


                    // DataGridView'e yeni satır ekle
                    DataDersler.Rows.Add(dersAdı, kredi, harfNotu);

                    // TextBox'ları temizle
                    textDersAdı.Clear();
                    textKredi.Clear();
                }
                else {
                    MessageBox.Show("Lütfen geçerli bir harf notu giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                // Yaş geçerli bir sayı değilse hata mesajı göster
                MessageBox.Show("Lütfen geçerli bir kredi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Tüm satırları temizle
            DataDersler.Rows.Clear();
        }
    }
}
