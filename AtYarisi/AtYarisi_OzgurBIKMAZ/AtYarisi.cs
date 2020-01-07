using AtYarisi_OzgurBIKMAZ;
using AtYarisi_OzgurBIKMAZ.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class AtYarisi : Form
    {
        static Random r = new Random();
        List<List<string>> listeKuponlar = new List<List<string>>();
        List<string[]> listeAnlik = new List<string[]>();
        List<string[]> listeYarisSonuc = new List<string[]>();
        List<int[]> listeAtlar = new List<int[]>();
        List<string> listeAyakSonuc = new List<string>();
        int secimPist = 0;
        int sayac = 10;
        int anlikSayac = 0;
        int yarisAyak = 1;

        public AtYarisi()
        {
            InitializeComponent();
        }

        private void AtYarisi_Load(object sender, EventArgs e)
        {
            AtIsimBelirle(out listeAtlar);
            MenuDiger.Visible = false;
            lblAyak.Visible = false;
            MenuBaslangic(false);
        }

        private void secCim_Click(object sender, EventArgs e)
        {
            secimPist = PistYukle(true);
            PistRenkAyarla(secimPist);
        }

        private void secKum_Click(object sender, EventArgs e)
        {
            secimPist = PistYukle(false);
            PistRenkAyarla(secimPist);
        }
 
        private void Basla_Click(object sender, EventArgs e)
        {
            MenuBasla.Visible = false;
            MenuDiger.Visible = true;
            lblAyak.Visible = true;
            AtIsimYukle(1);
            timerSayac.Start();
            pnlStart.Visible = true;
            pnlTekli.Visible = false;
            pnlCoklu.Visible = false;
            MenuPist.Visible = false;
            MenuBasla.CheckOnClick = true;
            TabMenuKullan(false);
        }

        private void MenuDiger_Click(object sender, EventArgs e)
        {
            yarisAyak++;
            if (yarisAyak == 8)
            {
                MessageBox.Show("Tüm Ayaklar Sonlandı. Kuponlarınızı kontrol edebilirsiniz...",
                    "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MenuGiris.Enabled = false;
                MenuBahis.Enabled = false;
                MenuAyarlar.Enabled = false;
                MenuKuponlarim.Enabled = false;
            }
            else
            {
                lblAyak.Text = $"{yarisAyak}.Ayak Koşuluyor...";
                YarisReset();
                AtIsimYukle(yarisAyak);
            }
        }

        private void timerSayac_Tick(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = @"D:\C#Projects\AtYarisi_OzgurBIKMAZ\AtYarisi_OzgurBIKMAZ\gong.wav";
            timerSayac.Interval = 700;
            sayac -= 1;
            lblCount.Text = sayac.ToString();
            lblNokta.Text += ".";

            if (sayac == 7)
            {
                lblInfo.Text = "Jokeyler Hazırlanıyor...";
                AtIsimGoster(true);
            }
            else if (sayac== 3)
            {
                lblInfo.Text = "Yarış Başlıyor...";

            }
            else if (sayac == 0)
            {
                timerSayac.Stop();
                //ses.Play();
                Thread.Sleep(800);
                //ses.Stop();

                AtIsimGoster(false);
                AtKostur(true);
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
                timer6.Start();
                timer7.Start();
                pnlStart.Visible = false;               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtBelirle(picAt1, timer1, secimPist, yarisAyak, listeAyakSonuc);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            AtBelirle(picAt2, timer2, secimPist, yarisAyak, listeAyakSonuc);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            AtBelirle(picAt3, timer3, secimPist, yarisAyak, listeAyakSonuc);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            AtBelirle(picAt4, timer4, secimPist, yarisAyak, listeAyakSonuc);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            AtBelirle(picAt5, timer5, secimPist, yarisAyak, listeAyakSonuc);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            AtBelirle(picAt6, timer6, secimPist, yarisAyak, listeAyakSonuc);
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            anlikSayac++;
            if (anlikSayac % 5 == 0)
            {
                listeAnlik.Clear();
                listeAnlik.Add(new string[] { picAt1.Left.ToString(), picAt1.Tag.ToString(), lbl1.Text });
                listeAnlik.Add(new string[] { picAt2.Left.ToString(), picAt2.Tag.ToString(), lbl2.Text });
                listeAnlik.Add(new string[] { picAt3.Left.ToString(), picAt3.Tag.ToString(), lbl3.Text });
                listeAnlik.Add(new string[] { picAt4.Left.ToString(), picAt4.Tag.ToString(), lbl4.Text });
                listeAnlik.Add(new string[] { picAt5.Left.ToString(), picAt5.Tag.ToString(), lbl5.Text });
                listeAnlik.Add(new string[] { picAt6.Left.ToString(), picAt6.Tag.ToString(), lbl6.Text });
            }

            switch (anlikSayac)
            {
                case 6:
                    AnlikDurum(true);
                    listeAnlik = listeAnlik.OrderBy(x => x[0]).ToList();
                    lblSira1.Text = listeAnlik[5][1];
                    lblSira2.Text = listeAnlik[4][1];
                    lblSira3.Text = listeAnlik[3][1];
                    lblDurum.Text = $"{listeAnlik[5][2]} " +
                                    $"({listeAnlik[5][1]}) " +
                                    $"Yarışa Önde Başladı.";
                    break;

                case 16:
                case 36:
                    listeAnlik = listeAnlik.OrderBy(x => x[0]).ToList();
                    Console.WriteLine(listeAnlik[5][0]);
                    lblSira1.Text = listeAnlik[5][1];
                    lblSira2.Text = listeAnlik[4][1];
                    lblSira3.Text = listeAnlik[3][1];
                    lblDurum.Text = $"{listeAnlik[5][2]} " +
                                    $"({listeAnlik[5][1]}) " +
                                    $"Yarışı Önde Sürdürüyor.";
                    break;

                case 26:
                    listeAnlik = listeAnlik.OrderBy(x => x[0]).ToList();
                    lblSira1.Text = listeAnlik[5][1];
                    lblSira2.Text = listeAnlik[4][1];
                    lblSira3.Text = listeAnlik[3][1];
                    lblDurum.Text = $"{listeAnlik[5][2]} " +
                                    $"({listeAnlik[5][1]}) " +
                                    $"Atak Yaparak Öne Geçti.";
                    break;

                case 46:
                case 51:
                    listeAnlik = listeAnlik.OrderBy(x => x[0]).ToList();
                    lblSira1.Text = listeAnlik[5][1];
                    lblSira2.Text = listeAnlik[4][1];
                    lblSira3.Text = listeAnlik[3][1];
                    lblDurum.Text = $"{listeAnlik[5][2]} " +
                                    $"({listeAnlik[5][1]}) " +
                                    $"Son Düzlükte Öne Geçti.";
                    break;
            }

        }
        
        private void btnKapat_Click(object sender, EventArgs e)
        {
            pnlSonuc.Visible = false;
        }

        private void MenuTekli_Click(object sender, EventArgs e)
        {
            if (listeYarisSonuc.Count == 0)
            {
                pnlTekli.Visible = true;
                ComboBoxYükle(listeAtlar, 0, cmbAyak1);
                ComboBoxYükle(listeAtlar, 1, cmbAyak2);
                ComboBoxYükle(listeAtlar, 2, cmbAyak3);
                ComboBoxYükle(listeAtlar, 3, cmbAyak4);
                ComboBoxYükle(listeAtlar, 4, cmbAyak5);
                ComboBoxYükle(listeAtlar, 5, cmbAyak6);
            }
            else
            {
                MessageBox.Show("Yarışlar Başladıktan Sonra Bahisler Kapanır.","Bahis Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnTekliKapat_Click(object sender, EventArgs e)
        {
            pnlTekli.Visible = false;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            bool kontrol = string.IsNullOrEmpty(txtAd.Text) ||
                           string.IsNullOrEmpty(txtGanyan.Text) ||
                           cmbAyak1.SelectedIndex == -1 ||
                           cmbAyak2.SelectedIndex == -1 ||
                           cmbAyak3.SelectedIndex == -1 ||
                           cmbAyak4.SelectedIndex == -1 ||
                           cmbAyak5.SelectedIndex == -1 ||
                           cmbAyak6.SelectedIndex == -1;

            if (kontrol)
            {
                MessageBox.Show("Tüm Boşlukları Doldurun!!!", "Hata!! Boş Girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ad = txtAd.Text;
                string ganyan = txtGanyan.Text;
                string ayak1 = cmbAyak1.SelectedItem.ToString();
                string ayak2 = cmbAyak2.SelectedItem.ToString();
                string ayak3 = cmbAyak3.SelectedItem.ToString();
                string ayak4 = cmbAyak4.SelectedItem.ToString();
                string ayak5 = cmbAyak5.SelectedItem.ToString();
                string ayak6 = cmbAyak6.SelectedItem.ToString();

                DialogResult secim = MessageBox.Show($"Oynayan : {ad}\n" +
                                                     $"Ganyan : {ganyan}\n" +
                                                     $"1.Ayak : {ayak1}\n" +
                                                     $"2.Ayak : {ayak2}\n" +
                                                     $"3.Ayak : {ayak3}\n" +
                                                     $"4.Ayak : {ayak4}\n" +
                                                     $"5.Ayak : {ayak5}\n" +
                                                     $"6.Ayak : {ayak6}\n",
                                                     "Kupon Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secim == DialogResult.Yes)
                {
                    listeKuponlar.Add(KuponOyna(ad, ayak1, ayak2, ayak3, ayak4, ayak5, ayak6, ganyan));
                }
            }

        }

        private void MenuCoklu_Click(object sender, EventArgs e)
        {
            if (listeYarisSonuc.Count == 0)
            {
                pnlCoklu.Visible = true;
            }
            else
            {
                MessageBox.Show("Yarışlar Başladıktan Sonra Bahisler Kapanır.", "Bahis Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCokluKapat_Click(object sender, EventArgs e)
        {
            pnlCoklu.Visible = false;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            bool kontrol = string.IsNullOrEmpty(txtAdet.Text) ||
                           string.IsNullOrEmpty(txtMin.Text) ||
                           string.IsNullOrEmpty(txtMax.Text);

            if (kontrol)
            {
                MessageBox.Show("Tüm Boşlukları Doldurun!!!", "Hata!! Boş Girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int adet = int.Parse(txtAdet.Text);
                int min = int.Parse(txtMin.Text);
                int max = int.Parse(txtMax.Text);

                DialogResult secim = MessageBox.Show($"{min} - {max} aralığında {adet} rastgele kupon oynanacak",
                   "Random Kupon", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secim == DialogResult.Yes)
                {
                    for (int i = 0; i < adet; i++)
                    {
                        string ad = ((Kisi)r.Next(0, 14) + "_" + i).ToString();
                        string ganyan = r.Next(min, max).ToString();

                        string ayak1 = ((AtIsim)listeAtlar[0][r.Next(0, 6)]).ToString();
                        string ayak2 = ((AtIsim)listeAtlar[1][r.Next(0, 6)]).ToString();
                        string ayak3 = ((AtIsim)listeAtlar[2][r.Next(0, 6)]).ToString();
                        string ayak4 = ((AtIsim)listeAtlar[3][r.Next(0, 6)]).ToString();
                        string ayak5 = ((AtIsim)listeAtlar[4][r.Next(0, 6)]).ToString();
                        string ayak6 = ((AtIsim)listeAtlar[5][r.Next(0, 6)]).ToString();

                        listeKuponlar.Add(KuponOyna(ad, ayak1, ayak2, ayak3, ayak4, ayak5, ayak6, ganyan));
                    }
                }
            }
        }

        private void KuponlarıGor_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listeKuponlar.Count);
            Kupon k = new Kupon(listeKuponlar);
            k.Show();
        }

        private void MenuSonuc_Click(object sender, EventArgs e)
        {
            if (listeYarisSonuc.Count == 0)
            {
                MessageBox.Show("Yarış Sonuçları Bulunamadı..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listeYarisSonuc.Count == 7)
            {
                YarisSonuc y = new YarisSonuc(listeYarisSonuc);
                y.Show();
            }
            else
            {
                MessageBox.Show("Tüm Yarışlar Oynanmadı.", "Yarış Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Kazanan_Click(object sender, EventArgs e)
        {
            if (listeYarisSonuc.Count == 0)
            {
                MessageBox.Show("Yarış Sonuçları Bulunamadı..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listeYarisSonuc.Count == 7)
            {
                string kazan = KazananKuponBul(listeYarisSonuc);
                KuponSonuc son = new KuponSonuc(listeYarisSonuc, listeKuponlar, kazan);
                son.Show();
            }
            else
            {
                MessageBox.Show("Tüm Yarışlar Oynanmadı.", "Yarış Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtBelirle(PictureBox picAt, System.Windows.Forms.Timer tim,
                               int zorlukPist, int yarisAyak, List<string> sonucListesi)
        {
            int atID = Convert.ToInt32(picAt.Tag);
            var KosuListesi = BultenHelper.KosuBilgisi(yarisAyak);
            string atIsim = BultenHelper.AtAdiBul(atID, yarisAyak);
            picAt.Left += r.Next(2, 15) * zorlukPist;

            if (picAt.Left > 940)
            {
                tim.Stop();
                timer7.Stop();
                listSonuc.Items.Add($"{atIsim} ({atID})");
                sonucListesi.Add(atIsim+","+atID);
                
                pnlSonuc.Visible = true;
                picAt.Enabled = false;
                TabMenuKullan(true);
                MenuBasla.CheckOnClick = false;
                AnlikDurum(false);


                if (listeAyakSonuc.Count == 6)
                {
                    listeYarisSonuc.Add(listeAyakSonuc.ToArray());
                }
            }
        }

        private void MenuKapat(object sender, EventArgs e)
        {
            if (MenuBasla.CheckOnClick)
            {
                MessageBox.Show("Yarış Hala Devam Ediyor!!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int PistYukle(bool durum)
        {
            int pist;
            secCim.Checked = durum;
            secKum.Checked = !durum;

            if (durum)
            {
                //pnlPist.BackgroundImage = Image.FromFile(@"D:\C#Projects\AtYarisi_OzgurBIKMAZ\AtYarisi_OzgurBIKMAZ\img\cim.png");
                pist = (int)(Pist.Cim);

            }
            else
            {
                //pnlPist.BackgroundImage = Image.FromFile(@"D:\C#Projects\AtYarisi_OzgurBIKMAZ\AtYarisi_OzgurBIKMAZ\img\kum.png");
                pist = (int)(Pist.Kum);
            }
            return pist;
        }

        private void PistRenkAyarla(int secim)
        {
            Color secimRenk;
            if (secim == 2)
            {
                secimRenk = Color.White;
            }
            else
            {
                secimRenk = Color.Black;
            }

            lbl1.ForeColor = secimRenk;
            lbl2.ForeColor = secimRenk;
            lbl3.ForeColor = secimRenk;
            lbl4.ForeColor = secimRenk;
            lbl5.ForeColor = secimRenk;
            lbl6.ForeColor = secimRenk;
            label1.BackColor = secimRenk;
            label2.BackColor = secimRenk;
            label3.BackColor = secimRenk;
            label4.BackColor = secimRenk;
            label5.BackColor = secimRenk;
            lblCount.ForeColor = secimRenk;
            lblInfo.ForeColor = secimRenk;
            lblNokta.ForeColor = secimRenk;
        }

        private void AtIsimBelirle(out List<int[]> gecici)
        {
            gecici = new List<int[]>();
            List<int> numara = new List<int>();

            int sayacNumara = 36;
            int atID;

            while (sayacNumara != 0)
            {
                while (true)
                {
                    atID = r.Next(1, 37);
                    if (!numara.Contains(atID))
                    {
                        numara.Add(atID);
                        sayacNumara--;
                        break;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                int[] ayak = new int[6];
                for (int j = 0; j < 6; j++)
                {
                    ayak[j] = numara[0];
                    numara.RemoveAt(0);
                }
                gecici.Add(ayak);
            }
        }

        private void AtIsimYukle(int ayak)
        {
            var KosuListesi = BultenHelper.KosuBilgisi(ayak);
            lbl1.Text = KosuListesi[0].AtAdi;
            lbl2.Text = KosuListesi[1].AtAdi;
            lbl3.Text = KosuListesi[2].AtAdi;
            lbl4.Text = KosuListesi[3].AtAdi;
            lbl5.Text = KosuListesi[4].AtAdi;
            lbl6.Text = KosuListesi[5].AtAdi;

            
        }

        private string KazananKuponBul(List<string[]> isim)
        {
            string kupon = "";
            foreach (string[] item in isim)
            {
                kupon += item[0];
            }
            return kupon;
        }

        private List<string> KuponOyna(string ad, string ayak1, string ayak2,
            string ayak3, string ayak4, string ayak5, string ayak6, string ganyan)
        {
            List<string> listKupon = new List<string>();
            string kupon = ayak1 + ayak2 + ayak3 + ayak4 + ayak5 + ayak6;

            listKupon.Add(ad);
            listKupon.Add(ayak1);
            listKupon.Add(ayak2);
            listKupon.Add(ayak3);
            listKupon.Add(ayak4);
            listKupon.Add(ayak5);
            listKupon.Add(ayak6);
            listKupon.Add(ganyan);
            listKupon.Add(kupon);

            return listKupon;
        }

        private void ComboBoxYükle(List<int []> isim, int ayak, ComboBox cmb)
        {
            string[] atlar = new string[isim.Count];
            for (int i = 0; i < isim.Count; i++)
            {
                atlar[i] = ((AtIsim)isim[ayak][i]).ToString();
            }
            cmb.Items.AddRange(atlar);
        }

        private void MenuBaslangic(bool durum)
        {
            AnlikDurum(durum);
            secimPist = PistYukle(!durum);
            PistRenkAyarla(secimPist);
            AtKostur(durum);
            AtIsimGoster(durum);
            pnlStart.Visible = durum;
            pnlSonuc.Visible = durum;
            pnlTekli.Visible = durum;
            pnlCoklu.Visible = durum;
        }

        private void TabMenuKullan(bool durum)
        {
            MenuPist.Visible = durum;
            MenuTekli.Visible = durum;
            MenuCoklu.Visible = durum;
            MenuKazanan.Visible = durum;
            MenuSonuc.Visible = durum;
        }

        private void AtKostur(bool durum)
        {
            picAt1.Enabled = durum;
            picAt2.Enabled = durum;
            picAt3.Enabled = durum;
            picAt4.Enabled = durum;
            picAt5.Enabled = durum;
            picAt6.Enabled = durum;
        }

        private void AtIsimGoster(bool durum)
        {
            lbl1.Visible = durum;
            lbl2.Visible = durum;
            lbl3.Visible = durum;
            lbl4.Visible = durum;
            lbl5.Visible = durum;
            lbl6.Visible = durum;
        }

        private void AnlikDurum(bool durum)
        {
            picAnlik.Visible = durum;
            lblDurum.Visible = durum;
            pic1.Visible = durum;
            lblSira1.Visible = durum;
            pic2.Visible = durum;
            lblSira2.Visible = durum;
            pic3.Visible = durum;
            lblSira3.Visible = durum;
        }

        private void SadeceRakamGirisi(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void YarisReset()
        {
            anlikSayac = 0;
            sayac = 10;
            lblNokta.Text = "";
            lblDurum.Visible = false;
            picAnlik.Visible = false;
            picAt1.Left = 0;
            picAt2.Left = 0;
            picAt3.Left = 0;
            picAt4.Left = 0;
            picAt5.Left = 0;
            picAt6.Left = 0;

            listSonuc.Items.Clear();

            MenuBaslangic(false);
            timerSayac.Start();
            pnlStart.Visible = true;
            MenuPist.Visible = false;
            MenuBasla.CheckOnClick = true;
            TabMenuKullan(false);
            listeAyakSonuc.Clear();

        }

        private void pnlPist_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    enum Pist{
        Kum=1,
        Cim=2
    }

    enum AtIsim
    {
        Küheylan=1,
        Oymapınar,
        Subat,
        Mihrat,
        Albeyinoğlu,
        Sevalim,
        AsilBey,
        Rüzgar,
        Atılgan, 
        Kasırga, 
        Fırtına,
        Sakarya,
        Şahbatur,
        Bilgin,
        Venüs,
        Yuna,
        Destan,
        Alyıldız,
        Çiçek,
        GürhanBey,
        Canbaz,
        Obradovic,
        ÇakırBey,
        Güldiken,
        Avşar,
        Dilovan,
        Masalcı,
        Beşirhan,
        Cengo,
        Avatar,
        Nadire,
        Matiz,
        Hasanşah,
        Sultan,
        Adora,
        Luxor
    }

    enum Kisi
    {
        İlker,
        Oğuzhan,
        Ayberk,
        Eda,
        Emre,
        Emirhan,
        Büşra,
        Tayfun,
        Yiğit,
        Özgür,
        Nurullah,
        Harun,
        Butkan,
        Kadir
    }


}