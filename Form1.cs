using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json;

namespace OdevTakip
{
    public partial class Form1 : Form
    {
        BindingList<Ogrenci> liste = new();//personel için liste tanımladık
        Ogrenci gosterilenOgrenci;//ilerisi içinekranda görünen personeli saklar
        object[] sınıflar = new object[] { "10-A", "10-C", "10-F", "10-H", "10-G" };

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("bilgiler.txt"))
            {
                string metin = File.ReadAllText("bilgiler.txt");
                var okunanliste = JsonSerializer.Deserialize<List<Ogrenci>>(metin);

            }
            //listBox ile bağlantı Yaptık
            lbOgrenci.DataSource = liste;
            lbOgrenci.DisplayMember = "FullName";
            cbSınıf.Items.AddRange(sınıflar);

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (gosterilenOgrenci == null)
            {
                YeniEkle();
            }
            else
            {
                Guncelle();
            }
        }
        void Guncelle()
        {

            gosterilenOgrenci.Ad = txtAd.Text;
            gosterilenOgrenci.Soyad = txtSoyad.Text;
        }
        void YeniEkle()
        {
            Ogrenci yeniOgr = new()//Yeni bir ogrenci oluşturduk
                //Verilern formda kontrollerden aldık
           cbSınıf.Items.AddRange(sınıflar);
            Ogr yeniPers = new();
            yeniPers.Ad = txtAd.Text;
            yeniPers.Soyad = txtSoyad.Text;
            yeniPers.Sınıf = cbSınıf.SelectedIndex;
            yeniPers.Konu = txtOdevkonu.Text;
            yeniPers.Numara = txtNo.Text;


            liste.Add(yeniPers);

            txtAd.Clear();
            txtSoyad.Clear();

            txtAd.Focus();
        }
        private void lbOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listedeki Seçili öğrenciyi Personel olarakversin
            Ogrenci pers = lbOgrenci.SelectedItem as Ogrenci;

            if (pers != null)
            {

                txtSoyad.Text = pers.Soyad;

                txtSoyad.Text = pers.Ad;


                gosterilenOgrenci = pers;

            }
            else
            {
                gosterilenOgrenci = null;

            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            //Seçili personeli kaldırır, yrni personeli ekler
            lbOgrenci.SelectedIndex = -1;
            //alanlarý temizle
            txtAd.Clear();
            txtSoyad.Clear();
            txtNo.Clear();
            txtOdevPuan.Clear();
            txtOdevkonu.Clear();
            cbSınıf.SelectedIndex = -1;
            //ilk kontrole TtxtAd'a  odaklanır
            txtAd.Focus();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lbOgrenci.SelectedItem != null)
            {
                // Seçili personeli kaldır
                liste.Remove((Ogrenci)lbOgrenci.SelectedItem);
                gosterilenOgrenci = null;

                // Alanları temizle
                txtAd.Clear();
                txtSoyad.Clear();
                txtNo.Clear();
                txtOdevkonu.Clear();
                txtOdevPuan.Clear();

                // Kullanıcıya bilgi mesajı göster
                MessageBox.Show("Seçili personel silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir personel seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string metin = JsonSerializer.Serialize(liste);

            File.WriteAllText("bilgiler.txt", metin);
            MessageBox.Show("Kaydedildi");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbSınıf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
