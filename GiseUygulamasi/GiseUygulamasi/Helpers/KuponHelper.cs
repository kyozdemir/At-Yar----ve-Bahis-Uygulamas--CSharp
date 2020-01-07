using GiseUygulamasi.DAT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiseUygulamasi.Helpers
{
    class KuponHelper
    {
        static Random r = new Random();
        public static (Kupon,bool) CUD(Kupon k, EntityState state)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                db.Entry(k).State = state;
                if (db.SaveChanges() > 0)
                {
                    return (k, true);
                }
                else
                {
                    return (k, false);
                }
            }
        }
        public static List<Kupon> KuponlariGetir()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                return db.Kupon.ToList();
            }
        }
        public static bool KuponUpdate(Kupon k)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                db.Entry(k).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }
        public static void AyakOyna(int bahisTipiID, string[] ayak, int misli,int kosuID, string kuponNo)
        {
            int[] oynananAtlar = new int[ayak.Length];
            for (int i = 0; i < ayak.Length; i++)
            {
                oynananAtlar[i] = Convert.ToInt32(ayak[i]);
            }

            using (AtBahisEntities db = new AtBahisEntities())
            {
                foreach (var item in oynananAtlar)
                {
                    Kupon k = new Kupon();
                    k.BahisTipiID = bahisTipiID;
                    k.Tahmin = item;
                    k.Tarih = DateTime.Now;
                    k.KosuID = kosuID;
                    k.KuponNo = kuponNo;
                    k.HipodromID = 1;
                    k.Misli = misli;
                    k.Ganyan = BultenHelper.AtGanyaniBul(kosuID,item);
                    k.Tutar = k.Ganyan * k.Misli;
                    db.Kupon.Add(k);
                    db.SaveChanges();
                }


            }
        }
        public static void AltiliGanyanOyna(string[] birinciAyak, string[] ikinciAyak, string[] ucuncuAyak, string[] dorduncuAyak, string[] besinciAyak, string[] altinciAyak, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(10, birinciAyak, misli, 2,kuponNo);
            AyakOyna(10, ikinciAyak, misli, 3,kuponNo);
            AyakOyna(10, ucuncuAyak, misli, 4,kuponNo);
            AyakOyna(10, dorduncuAyak, misli, 5,kuponNo);
            AyakOyna(10, besinciAyak, misli, 6,kuponNo);
            AyakOyna(10, altinciAyak, misli, 7,kuponNo);
        }
        public static void BesliGanyanOyna(string[] birinciAyak, string[] ikinciAyak, string[] ucuncuAyak, string[] dorduncuAyak, string[] besinciAyak, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(11, birinciAyak, misli, 3,kuponNo);
            AyakOyna(11, ikinciAyak, misli, 4,kuponNo);
            AyakOyna(11, ucuncuAyak, misli, 5,kuponNo);
            AyakOyna(11, dorduncuAyak, misli, 6,kuponNo);
            AyakOyna(11, besinciAyak, misli, 7,kuponNo);
        }
        public static void DortluGanyanOyna(string[] birinciAyak, string[] ikinciAyak, string[] ucuncuAyak, string[] dorduncuAyak, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(12, birinciAyak, misli, 4,kuponNo);
            AyakOyna(12, ikinciAyak, misli, 5,kuponNo);
            AyakOyna(12, ucuncuAyak, misli, 6,kuponNo);
            AyakOyna(12, dorduncuAyak, misli, 7,kuponNo);
        }
        public static void UcluGanyanOyna(string[] birinciAyak, string[] ikinciAyak, string[] ucuncuAyak, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(12, birinciAyak, misli, 5,kuponNo);
            AyakOyna(12, ikinciAyak, misli, 6,kuponNo);
            AyakOyna(12, ucuncuAyak, misli, 7,kuponNo);
        }
        public static void PlaseOyna(string[] birinciAyak,int kosuID, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(2, birinciAyak, misli,kosuID,kuponNo);
        }
        public static void YediliPlaseOyna(string[] birinciAyak, string[] ikinciAyak, string[] ucuncuAyak, string[] dorduncuAyak, string[] besinciAyak, string[] altinciAyak, string[] yedinciAyak, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(3, birinciAyak, misli, 1,kuponNo);
            AyakOyna(3, ikinciAyak, misli, 2,kuponNo);
            AyakOyna(3, ucuncuAyak, misli, 3,kuponNo);
            AyakOyna(3, dorduncuAyak, misli, 4,kuponNo);
            AyakOyna(3, besinciAyak, misli, 5,kuponNo);
            AyakOyna(3, altinciAyak, misli, 6,kuponNo);
            AyakOyna(3, yedinciAyak, misli, 7,kuponNo);
        }
        public static void IkiliBahisOyna(string[] birinciAyak, int kosuID, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(4, birinciAyak, misli, kosuID,kuponNo);
        }
        public static void SiraliIkiliBahisOyna(string[] birinciAyak, int kosuID, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(5, birinciAyak, misli, kosuID,kuponNo);
        }
        public static void PlaseIkiliOyna(string[] birinciAyak, int kosuID, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(6, birinciAyak, misli, kosuID,kuponNo);
        }
        public static void CifteBahisOyna(string[] birinciAyak, string[] ikinciAyak, int kosuID, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(7, birinciAyak, misli, kosuID,kuponNo);
            AyakOyna(7, ikinciAyak, misli, kosuID+1,kuponNo);
        }
        public static void TabelaBahisOyna(string[] birinciAyak, string[] ikinciAyak, string[] ucuncuAyak, string[] dorduncuAyak,int kosuID, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(8, birinciAyak, misli, kosuID,kuponNo);
            AyakOyna(8, ikinciAyak, misli, kosuID,kuponNo);
            AyakOyna(8, ucuncuAyak, misli, kosuID,kuponNo);
            AyakOyna(8, dorduncuAyak, misli, kosuID,kuponNo);
        }
        public static void SiraliUcluBahisOyna(string[] birinciAyak ,int kosuID, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(9, birinciAyak, misli, kosuID,kuponNo);
        }
        public static void GanyanOyna(string[] birinciAyak, int kosuID, int misli)
        {
            string kuponNo = KuponKoduUret();
            AyakOyna(1, birinciAyak, misli, kosuID, kuponNo);
        }

        private static string KuponKoduUret()
        {
            
            int kuponNo;
            using (AtBahisEntities db = new AtBahisEntities())
            {

                do
                {
                    kuponNo = r.Next(1000000);
                } while (db.Kupon.Any(q => q.KuponNo == kuponNo.ToString()));
                
            }
            return kuponNo.ToString();
            
            
        }

    }
}
