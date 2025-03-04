using System;
using System.Windows.Forms;

namespace sayiTahminOyunu
{
    public partial class Form1 : Form
    {
        private int rastgeleSayi;
        private int kalanHak = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rastgeleSayi = rnd.Next(1, 100); // 1 ile 100 arasýnda rastgele sayý oluþtur
            kalanHak = 5;
            lblHak.Text = "5";
            lblSonuc.Text = "";
            txtSayi.Text = "";
            btnTahmin.Enabled = true;
            MessageBox.Show("Oyun baþladý! 1 ile 100 arasýnda bir sayý tahmin edin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSayi.Text, out int tahmin))
            {
                kalanHak--;
                lblHak.Text = kalanHak.ToString();

                if (tahmin == rastgeleSayi)
                {
                    lblSonuc.Text = "Tebrikler, doðru tahmin!";
                    btnTahmin.Enabled = false;
                }
                else if (tahmin < rastgeleSayi)
                {
                    lblSonuc.Text = "Daha büyük bir sayý girin!";
                }
                else
                {
                    lblSonuc.Text = "Daha küçük bir sayý girin!";
                }

                if (kalanHak == 0 && tahmin != rastgeleSayi)
                {
                    lblSonuc.Text = "Üzgünüm, hakkýnýz bitti! Doðru sayý: " + rastgeleSayi;
                    btnTahmin.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
