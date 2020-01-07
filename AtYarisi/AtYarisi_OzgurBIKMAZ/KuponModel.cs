using AtYarisi_OzgurBIKMAZ.DAT;
using AtYarisi_OzgurBIKMAZ.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtYarisi_OzgurBIKMAZ
{
    class KuponModel
    {

        public string KuponNo { get; set; }
        public int HipodromID { get; set; }
        public System.DateTime Tarih { get; set; }
        public int BahisTipiID { get; set; }
        public int KosuID { get; set; }
        public int Tahmin { get; set; }
        public List<int> BirinciAyak { get; set; }
        public List<int> IkinciAyak { get; set; }
        public List<int> UcuncuAyak { get; set; }
        public List<int> DorduncuAyak { get; set; }
        public List<int> BesinciAyak { get; set; }
        public List<int> AltinciAyak { get; set; }
        public List<int> YedinciAyak { get; set; }
        public double Ganyan { get; set; }
        public int Misli { get; set; }
        public double Tutar { get; set; }
        public Nullable<bool> KuponDurumu { get; set; }


        //public List<KuponModel> KuponGetir()
        //{
        //    var kuponList = KuponHelper.KuponlariGetir();
        //    List<KuponModel> YeniKuponListesi = new List<KuponModel>();
        //    foreach (Kupon item in kuponList)
        //    {
        //        if (kuponList.Any(x => x.KuponNo == item.KuponNo))
        //        {
        //            if (item.KosuID == 1)
        //            {
        //                km.BirinciAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 2)
        //            {
        //                km.IkinciAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 3)
        //            {
        //                km.UcuncuAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 4)
        //            {
        //                km.DorduncuAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 5)
        //            {
        //                km.BesinciAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 6)
        //            {
        //                km.AltinciAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 7)
        //            {
        //                km.YedinciAyak.Add(item.Tahmin);
        //            }
        //        }
        //        else
        //        {
        //            KuponModel km = new KuponModel();
        //            km.KuponNo = item.KuponNo;
        //            km.HipodromID = item.HipodromID;
        //            km.Tarih = item.Tarih;
        //            km.BahisTipiID = item.BahisTipiID;
        //            if (item.KosuID == 1)
        //            {
        //                km.BirinciAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 2)
        //            {
        //                km.IkinciAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 3)
        //            {
        //                km.UcuncuAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 4)
        //            {
        //                km.DorduncuAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 5)
        //            {
        //                km.BesinciAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 6)
        //            {
        //                km.AltinciAyak.Add(item.Tahmin);
        //            }
        //            else if (item.KosuID == 7)
        //            {
        //                km.YedinciAyak.Add(item.Tahmin);
        //            }
        //        }
        //    }
        //}

        public static void AltiliGanyanKontrol()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                var kuponList = KuponHelper.KuponlariGetir();
                var AltiliKuponlari = kuponList.Where(x => x.BahisTipiID == 10).ToList();
                var AltiliGanyanSonuclari = SonucHelper.AltiliGanyanSonuclari(DateTime.Now.Date);
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
        public static List<Kupon> TutanKuponlar()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                return db.Kupon.Where(x => x.KuponDurumu == true).ToList();
            }
        }
    }
}
