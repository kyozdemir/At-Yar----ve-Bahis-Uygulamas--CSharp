using GiseUygulamasi.DAT;
using GiseUygulamasi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiseUygulamasi.MODELS
{
    class KuponModel
    {
        public int KuponID { get; set; }
        public string KuponNo { get; set; }
        public int HipodromID { get; set; }
        public System.DateTime Tarih { get; set; }
        public int BahisTipiID { get; set; }
        public Nullable<int> Tahmin { get; set; }

        public List<int> BirinciAyak = new List<int>();
        public List<int> IkinciAyak = new List<int>();
        public List<int> UcuncuAyak = new List<int>();
        public List<int> DorduncuAyak = new List<int>();
        public List<int> BesinciAyak = new List<int>();
        public List<int> AltinciAyak = new List<int>();
        public List<int> YedinciAyak = new List<int>();
        public double Ganyan { get; set; }
        public int Misli { get; set; }
        public double Tutar { get; set; }
        public Nullable<bool> KuponDurumu { get; set; }
        public int KosuID { get; set; }

        public static void AltiliGanyanKontrol()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                var kuponList = KuponHelper.KuponlariGetir();
                var AltiliKuponlari = kuponList.Where(x => x.BahisTipiID == 10).ToList();
                var AltiliGanyanSonuclari = SonucHelper.AltiliGanyanSonuclari(DateTime.Now);
                foreach (var item in AltiliKuponlari)
                {
                    Kupon k = new Kupon();
                    if (item.KosuID == 2)
                    {
                        if (item.Tahmin == AltiliGanyanSonuclari[0].atNo)
                        {
                            k.KuponID = item.KuponID;
                            k.KuponNo = item.KuponNo;
                            k.HipodromID = item.HipodromID;
                            k.KosuID = item.KosuID;
                            k.Misli = item.Misli;
                            k.Tutar = item.Tutar;
                            k.Tahmin = item.Tahmin;
                            k.Ganyan = item.Ganyan;
                            k.KuponDurumu = true;
                            k.BahisTipiID = item.BahisTipiID;
                            KuponHelper.KuponUpdate(k);

                        }
                    }
                    else if (item.KosuID == 3)
                    {
                        if (item.Tahmin == AltiliGanyanSonuclari[1].atNo)
                        {
                            k.KuponID = item.KuponID;
                            k.KuponNo = item.KuponNo;
                            k.HipodromID = item.HipodromID;
                            k.KosuID = item.KosuID;
                            k.Misli = item.Misli;
                            k.Tutar = item.Tutar;
                            k.Tahmin = item.Tahmin;
                            k.Ganyan = item.Ganyan;
                            k.KuponDurumu = true;
                            k.BahisTipiID = item.BahisTipiID;
                            KuponHelper.KuponUpdate(k);

                        }
                    }
                    else if (item.KosuID == 4)
                    {
                        if (item.Tahmin == AltiliGanyanSonuclari[2].atNo)
                        {
                            k.KuponID = item.KuponID;
                            k.KuponNo = item.KuponNo;
                            k.HipodromID = item.HipodromID;
                            k.KosuID = item.KosuID;
                            k.Misli = item.Misli;
                            k.Tutar = item.Tutar;
                            k.Tahmin = item.Tahmin;
                            k.Ganyan = item.Ganyan;
                            k.KuponDurumu = true;
                            k.BahisTipiID = item.BahisTipiID;
                            KuponHelper.KuponUpdate(k);

                        }
                    }
                    else if (item.KosuID == 5)
                    {
                        if (item.Tahmin == AltiliGanyanSonuclari[3].atNo)
                        {
                            k.KuponID = item.KuponID;
                            k.KuponNo = item.KuponNo;
                            k.HipodromID = item.HipodromID;
                            k.KosuID = item.KosuID;
                            k.Misli = item.Misli;
                            k.Tutar = item.Tutar;
                            k.Tahmin = item.Tahmin;
                            k.Ganyan = item.Ganyan;
                            k.KuponDurumu = true;
                            k.BahisTipiID = item.BahisTipiID;
                            KuponHelper.KuponUpdate(k);

                        }
                    }
                    else if (item.KosuID == 6)
                    {
                        if (item.Tahmin == AltiliGanyanSonuclari[4].atNo)
                        {
                            k.KuponID = item.KuponID;
                            k.KuponNo = item.KuponNo;
                            k.HipodromID = item.HipodromID;
                            k.KosuID = item.KosuID;
                            k.Misli = item.Misli;
                            k.Tutar = item.Tutar;
                            k.Tahmin = item.Tahmin;
                            k.Ganyan = item.Ganyan;
                            k.KuponDurumu = true;
                            k.BahisTipiID = item.BahisTipiID;
                            KuponHelper.KuponUpdate(k);

                        }
                    }
                    else if (item.KosuID == 7)
                    {
                        if (item.Tahmin == AltiliGanyanSonuclari[5].atNo)
                        {
                            k.KuponID = item.KuponID;
                            k.KuponNo = item.KuponNo;
                            k.HipodromID = item.HipodromID;
                            k.KosuID = item.KosuID;
                            k.Misli = item.Misli;
                            k.Tutar = item.Tutar;
                            k.Tahmin = item.Tahmin;
                            k.Ganyan = item.Ganyan;
                            k.KuponDurumu = true;
                            k.BahisTipiID = item.BahisTipiID;
                            KuponHelper.KuponUpdate(k);

                        }
                    }
                }
            }
        }
    }
}
