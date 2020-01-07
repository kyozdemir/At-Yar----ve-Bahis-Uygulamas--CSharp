using AtYarisi_OzgurBIKMAZ.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi_OzgurBIKMAZ
{
    public partial class YarisSonuc : Form
    {
        List<string[]> listSonuclar = new List<string[]>();
        public YarisSonuc(List<string[]>listSonuclar)
        {
            InitializeComponent();
            this.listSonuclar = listSonuclar;
        }

        private void YarisSonuc_Load(object sender, EventArgs e)
        {
            if (listSonuclar.Count==7)
            {
                listAyak1.Items.AddRange(listSonuclar[0]);
                listAyak2.Items.AddRange(listSonuclar[1]);
                listAyak3.Items.AddRange(listSonuclar[2]);
                listAyak4.Items.AddRange(listSonuclar[3]);
                listAyak5.Items.AddRange(listSonuclar[4]);
                listAyak6.Items.AddRange(listSonuclar[5]);
                listAyak7.Items.AddRange(listSonuclar[6]);
                YarisSonuclariniGonder();
                KuponModel.AltiliGanyanKontrol();
            }
            else
            {
                MessageBox.Show("Tüm Yarışlar Oynanmadı.","Yarış Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        private void YarisSonuclariniGonder()
        {
            for (int i = 1; i <= 6; i++)
            {
                string[] a = (listAyak1.Items[i-1].ToString()).Split(',');
                int atNo = Convert.ToInt32(a[1]);
                SonucHelper.SonuclariKaydet(SonucHelper.SonucAl(1, 1, i, atNo));
            }
            for (int i = 1; i <= 6; i++)
            {
                string[] a = (listAyak2.Items[i-1].ToString()).Split(',');
                int atNo = Convert.ToInt32(a[1]);
                SonucHelper.SonuclariKaydet(SonucHelper.SonucAl(1, 2, i, atNo));
            }
            for (int i = 1; i <= 6; i++)
            {
                string[] a = (listAyak3.Items[i-1].ToString()).Split(',');
                int atNo = Convert.ToInt32(a[1]);
                SonucHelper.SonuclariKaydet(SonucHelper.SonucAl(1, 3, i, atNo));
            }
            for (int i = 1; i <= 6; i++)
            {
                string[] a = (listAyak4.Items[i-1].ToString()).Split(',');
                int atNo = Convert.ToInt32(a[1]);
                SonucHelper.SonuclariKaydet(SonucHelper.SonucAl(1, 4, i, atNo));
            }
            for (int i = 1; i <= 6; i++)
            {
                string[] a = (listAyak5.Items[i-1].ToString()).Split(',');
                int atNo = Convert.ToInt32(a[1]);
                SonucHelper.SonuclariKaydet(SonucHelper.SonucAl(1, 5, i, atNo));
            }
            for (int i = 1; i <= 6; i++)
            {
                string[] a = (listAyak6.Items[i-1].ToString()).Split(',');
                int atNo = Convert.ToInt32(a[1]);
                SonucHelper.SonuclariKaydet(SonucHelper.SonucAl(1, 6, i, atNo));
            }
            for (int i = 1; i <= 6; i++)
            {
                string[] a = (listAyak7.Items[i-1].ToString()).Split(',');
                int atNo = Convert.ToInt32(a[1]);
                SonucHelper.SonuclariKaydet(SonucHelper.SonucAl(1, 7, i, atNo));
            }
        }
    }
}
