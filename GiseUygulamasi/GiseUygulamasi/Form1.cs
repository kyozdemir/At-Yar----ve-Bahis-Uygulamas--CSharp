using GiseUygulamasi.DAT;
using GiseUygulamasi.Helpers;
using GiseUygulamasi.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiseUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBahisTipi.DataSource = BahisHelper.BahisIsimleriniAl();
            
        }

        private void btnBulteniGoruntule_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            
            foreach (Bulten item in BultenHelper.KosuBilgisi(1,dateTimePicker1.Value.Date))
            {
                listBox1.Items.Add(item.AtAdi);
            }
            foreach (Bulten item in BultenHelper.KosuBilgisi(2,dateTimePicker1.Value.Date))
            {
                listBox2.Items.Add(item.AtAdi);
            }
            foreach (Bulten item in BultenHelper.KosuBilgisi(3,dateTimePicker1.Value.Date))
            {
                listBox3.Items.Add(item.AtAdi);
            }
            foreach (Bulten item in BultenHelper.KosuBilgisi(4,dateTimePicker1.Value.Date))
            {
                listBox4.Items.Add(item.AtAdi);
            }
            foreach (Bulten item in BultenHelper.KosuBilgisi(5,dateTimePicker1.Value.Date))
            {
                listBox5.Items.Add(item.AtAdi);
            }
            foreach (Bulten item in BultenHelper.KosuBilgisi(6,dateTimePicker1.Value.Date))
            {
                listBox6.Items.Add(item.AtAdi);
            }
            foreach (Bulten item in BultenHelper.KosuBilgisi(7,dateTimePicker1.Value.Date))
            {
                listBox7.Items.Add(item.AtAdi);
            }

        }

        private void bntBultenOlustur_Click(object sender, EventArgs e)
        {
            
            if (BultenHelper.BultenTarihKontrolu(dateTimePicker1.Value.Date))
            {
                BultenHelper.BultenOlustur();
                MessageBox.Show("Yeni Yarış Bülteni Oluşturuldu!");
            }
            else
            {
                MessageBox.Show("Bu Tarihte oluşturulmuş bir bülten mevcut!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtBilgisiHelper.AtlariYenile();
        }

        private void cmbBahisTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAyak1.Clear();
            txtAyak2.Clear();
            txtAyak3.Clear();
            txtAyak4.Clear();
            txtAyak5.Clear();
            txtAyak6.Clear();
            txtAyak7.Clear();
            if (cmbBahisTipi.SelectedItem.ToString() == "Ganyan")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = false;
                txtAyak3.Enabled = false;
                txtAyak4.Enabled = false;
                txtAyak5.Enabled = false;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "Plase")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = true;
                txtAyak4.Enabled = true;
                txtAyak5.Enabled = true;
                txtAyak6.Enabled = true;
                txtAyak7.Enabled = true;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "7'li Plase")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = true;
                txtAyak4.Enabled = true;
                txtAyak5.Enabled = true;
                txtAyak6.Enabled = true;
                txtAyak7.Enabled = true;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "İkili Bahis")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = false;
                txtAyak4.Enabled = false;
                txtAyak5.Enabled = false;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "Sıralı İkili Bahis")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = false;
                txtAyak4.Enabled = false;
                txtAyak5.Enabled = false;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "Plase İkili")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = false;
                txtAyak4.Enabled = false;
                txtAyak5.Enabled = false;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "Çifte Bahis")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = false;
                txtAyak4.Enabled = false;
                txtAyak5.Enabled = false;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "Tabela Bahis")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = true;
                txtAyak4.Enabled = true;
                txtAyak5.Enabled = false;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "Sıralı Üçlü Bahis")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = true;
                txtAyak4.Enabled = false;
                txtAyak5.Enabled = false;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "6'lı Ganyan")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = true;
                txtAyak4.Enabled = true;
                txtAyak5.Enabled = true;
                txtAyak6.Enabled = true;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "5'li Ganyan")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = true;
                txtAyak4.Enabled = true;
                txtAyak5.Enabled = true;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "4'lü Ganyan\r\n")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = true;
                txtAyak4.Enabled = true;
                txtAyak5.Enabled = false;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
            else if (cmbBahisTipi.SelectedItem.ToString() == "3'lü Ganyan")
            {
                txtAyak1.Enabled = true;
                txtAyak2.Enabled = true;
                txtAyak3.Enabled = true;
                txtAyak4.Enabled = false;
                txtAyak5.Enabled = false;
                txtAyak6.Enabled = false;
                txtAyak7.Enabled = false;
            }
        }

        private void bntBahisOnay_Click(object sender, EventArgs e)
        {

            var bahisTipi = cmbBahisTipi.SelectedItem.ToString();
            var bahisTipiID = BahisHelper.BahisTipiIDBul(bahisTipi);
            int misli = Convert.ToInt32(txtMisli.Text);
            int kosuID;  
            switch (bahisTipiID)
            {
                case 1:
                    string[] GanyanTahmin = txtAyak1.Text.Split(',');
                    kosuID = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    KuponHelper.GanyanOyna(GanyanTahmin, kosuID, misli);
                    break;
                case 2:
                    string[] PlaseTahmin = txtAyak1.Text.Split(',');
                    kosuID = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    KuponHelper.PlaseOyna(PlaseTahmin, kosuID, misli);
                    break;
                case 3:
                    string[] birinciAyak = txtAyak1.Text.Split(',');
                    string[] ikinciAyak = txtAyak2.Text.Split(',');
                    string[] ucuncuAyak = txtAyak3.Text.Split(',');
                    string[] dorduncuAyak = txtAyak4.Text.Split(',');
                    string[] besinciAyak = txtAyak5.Text.Split(',');
                    string[] altinciAyak = txtAyak6.Text.Split(',');
                    string[] yedinciAyak = txtAyak7.Text.Split();
                    KuponHelper.YediliPlaseOyna(birinciAyak, ikinciAyak, ucuncuAyak, dorduncuAyak, besinciAyak, altinciAyak, yedinciAyak, misli);
                    break;
                case 4:
                    string[] ikiliBahisTahmin = txtAyak1.Text.Split(',');
                    kosuID = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    KuponHelper.IkiliBahisOyna(ikiliBahisTahmin, kosuID, misli);
                    break;
                case 5:
                    string[] siraliIkiliBahisTahmini = txtAyak1.Text.Split(',');
                    kosuID = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    KuponHelper.SiraliIkiliBahisOyna(siraliIkiliBahisTahmini, kosuID, misli);
                    break;
                case 6:
                    string[] PlaseIkıliTahmin = txtAyak1.Text.Split(',');
                    kosuID = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    KuponHelper.PlaseIkiliOyna(PlaseIkıliTahmin, kosuID, misli);
                    break;
                case 7:
                    string[] CifteBahisBirinciKosu = txtAyak1.Text.Split(',');
                    string[] CifteBahisIkinciKosu = txtAyak2.Text.Split(',');
                    kosuID = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    KuponHelper.CifteBahisOyna(CifteBahisBirinciKosu, CifteBahisIkinciKosu, kosuID, misli);
                    break;
                case 8:
                    string[] TabelaBirinci = txtAyak1.Text.Split(',');
                    string[] TabelaIkinci = txtAyak2.Text.Split(',');
                    string[] TabelaUcuncu = txtAyak3.Text.Split(',');
                    string[] TabelaDorduncu = txtAyak4.Text.Split(',');
                    kosuID = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    KuponHelper.TabelaBahisOyna(TabelaBirinci, TabelaIkinci, TabelaUcuncu, TabelaDorduncu, kosuID, misli);
                    break;
                case 9:
                    string[] SiraliUcluBahisTahmini = txtAyak1.Text.Split(',');
                    kosuID = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    KuponHelper.SiraliUcluBahisOyna(SiraliUcluBahisTahmini, kosuID, misli);
                    break;
                case 10:
                    string[] AltiliGanyanBirinciAyakTahmin = txtAyak1.Text.Split(',');
                    string[] AltiliGanyanIkinciAyakTahmin = txtAyak2.Text.Split(',');
                    string[] AltiliGanyanUcuncuAyakTahmin = txtAyak3.Text.Split(',');
                    string[] AltiliGanyanDorduncuAyakTahmin = txtAyak4.Text.Split(',');
                    string[] AltiliGanyanBesinciAyakTahmim = txtAyak5.Text.Split(',');
                    string[] AltiliGanyanAltinciAyakTahmin = txtAyak6.Text.Split(',');
                    KuponHelper.AltiliGanyanOyna(AltiliGanyanBirinciAyakTahmin, AltiliGanyanIkinciAyakTahmin, AltiliGanyanUcuncuAyakTahmin, AltiliGanyanDorduncuAyakTahmin, AltiliGanyanBesinciAyakTahmim, AltiliGanyanAltinciAyakTahmin, misli);
                    break;
                case 11:
                    string[] BesliGanyanBirinciAyakTahmin = txtAyak1.Text.Split(',');
                    string[] BesliGanyanIkinciAyakTahmin = txtAyak2.Text.Split(',');
                    string[] BesliGanyanUcuncuAyakTahmin = txtAyak3.Text.Split(',');
                    string[] BesliGanyanDorduncuAyakTahmin = txtAyak4.Text.Split(',');
                    string[] BesliGanyanBesinciAyakTahmin = txtAyak5.Text.Split(',');
                    KuponHelper.BesliGanyanOyna(BesliGanyanBirinciAyakTahmin, BesliGanyanIkinciAyakTahmin, BesliGanyanUcuncuAyakTahmin, BesliGanyanDorduncuAyakTahmin, BesliGanyanBesinciAyakTahmin, misli);
                    break;
                case 12:
                    string[] DortluGanyanBirinciAyakTahmin = txtAyak1.Text.Split(',');
                    string[] DortluGanyanIkinciAyakTahmin = txtAyak2.Text.Split(',');
                    string[] DortluGanyanUcuncuAyakTahmin = txtAyak3.Text.Split(',');
                    string[] DortluGanyanDorduncuAyakTahmin = txtAyak4.Text.Split(',');
                    KuponHelper.DortluGanyanOyna(DortluGanyanBirinciAyakTahmin, DortluGanyanIkinciAyakTahmin, DortluGanyanUcuncuAyakTahmin, DortluGanyanDorduncuAyakTahmin, misli);
                    break;
                case 13:
                    string[] UcluGanyanBirinciAyakTahmin = txtAyak1.Text.Split(',');
                    string[] UcluGanyanIkinciAyakTahmin = txtAyak2.Text.Split(',');
                    string[] UcluGanyanUcuncuAyakTahmin = txtAyak3.Text.Split(',');
                    KuponHelper.UcluGanyanOyna(UcluGanyanBirinciAyakTahmin, UcluGanyanIkinciAyakTahmin, UcluGanyanUcuncuAyakTahmin, misli);
                    break;
                default:
                    break;
            }
            MessageBox.Show("Kupon Kaydı Başarılı");
        }

        private void btnKuponSorgula_Click(object sender, EventArgs e)
        {

            var kuponList = KuponHelper.KuponlariGetir();
            if (kuponList.Any(x => x.KuponNo.TrimEnd() == txtKuponSorgu.Text))
            {
                MessageBox.Show("Kupon Bilgileri Getirildi");
                dataGridView1.DataSource = kuponList.Where(x => x.KuponNo.TrimEnd() == txtKuponSorgu.Text && x.KuponDurumu == true).ToList();
                this.dataGridView1.Columns["BahisTipleri"].Visible = false;
                this.dataGridView1.Columns["Hipodrom"].Visible = false;
                if (dataGridView1.Rows.Count == 6)
                {
                    int tutar = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        tutar += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                    }
                    lblKuponDurum.Text = "KAZANDI";
                    lblTutar.Text = tutar.ToString();

                }
                else
                {
                    lblKuponDurum.Text = "Kazanmayan Kupon";
                    lblTutar.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Böyle Bir Kupon Bulunamadı");
            }
           
        }
    }
}
