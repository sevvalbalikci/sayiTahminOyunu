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
            rastgeleSayi = rnd.Next(1, 100); // 1 ile 100 aras�nda rastgele say� olu�tur
            kalanHak = 5;
            lblHak.Text = "5";
            lblSonuc.Text = "";
            txtSayi.Text = "";
            btnTahmin.Enabled = true;
            MessageBox.Show("Oyun ba�lad�! 1 ile 100 aras�nda bir say� tahmin edin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSayi.Text, out int tahmin))
            {
                kalanHak--;
                lblHak.Text = kalanHak.ToString();

                if (tahmin == rastgeleSayi)
                {
                    lblSonuc.Text = "Tebrikler, do�ru tahmin!";
                    btnTahmin.Enabled = false;
                }
                else if (tahmin < rastgeleSayi)
                {
                    lblSonuc.Text = "Daha b�y�k bir say� girin!";
                }
                else
                {
                    lblSonuc.Text = "Daha k���k bir say� girin!";
                }

                if (kalanHak == 0 && tahmin != rastgeleSayi)
                {
                    lblSonuc.Text = "�zg�n�m, hakk�n�z bitti! Do�ru say�: " + rastgeleSayi;
                    btnTahmin.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
