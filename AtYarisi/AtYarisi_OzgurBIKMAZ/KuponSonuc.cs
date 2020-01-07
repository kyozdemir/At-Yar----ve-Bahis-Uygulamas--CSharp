using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class KuponSonuc : Form
    {
        List<List<string>> kuponlar = new List<List<string>>();
        List<List<string>> kisiKazanan = new List<List<string>>();
        List<List<string>> kisiKaybeden = new List<List<string>>();
        List<string[]> sonucYaris = new List<string[]>();
        int sayacKaybeden = 0;
        int sayacKazanan = 0;
        int paraYatirilan = 0;
        int paraVerilen = 0;

        string kuponKazanan;
        public KuponSonuc(List<string[]> sonucYaris, List<List<string>> kuponlar, string kuponKazanan)
        {
            InitializeComponent();
            this.kuponlar = kuponlar;
            this.sonucYaris = sonucYaris;
            this.kuponKazanan = kuponKazanan;
        }

        private void KuponOyna_Load(object sender, EventArgs e)
        {
            YarisAyaklariYukle();
            SonuclariYukle();
        }

        private void btnHasilat_Click(object sender, EventArgs e)
        {
            lblKupon.Text = kuponlar.Count.ToString();
            lblYatirilan.Text = paraYatirilan.ToString("N1", CultureInfo.InvariantCulture);
            lblKazanan.Text = $"({sayacKazanan})";
            lblVerilen.Text = (paraVerilen).ToString("N1", CultureInfo.InvariantCulture);
            lblHasilat.Text = (paraYatirilan - paraVerilen).ToString("N1", CultureInfo.InvariantCulture);
        }

        private void YarisAyaklariYukle()
        {
            lblAyak1.Text = sonucYaris[0][0];
            lblAyak2.Text = sonucYaris[1][0];
            lblAyak3.Text = sonucYaris[2][0];
            lblAyak4.Text = sonucYaris[3][0];
            lblAyak5.Text = sonucYaris[4][0];
            lblAyak6.Text = sonucYaris[5][0];
        }

        private void SonuclariYukle()
        {
            foreach (List<string> item in kuponlar)
            {
                if (item[8].Equals(kuponKazanan))
                {
                    dataKazanan.Rows.Add(item.ToArray());
                    kisiKazanan.Add(item);
                    paraVerilen += (int.Parse(item[7])*5);
                    sayacKazanan++;
                }
                else
                {
                    dataKaybeden.Rows.Add(item.ToArray());
                    kisiKaybeden.Add(item);
                    sayacKaybeden++;
                }
                paraYatirilan += int.Parse(item[7]);

            }
        }


    }

    enum Atlar
    {
        Küheylan = 1,
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

}
