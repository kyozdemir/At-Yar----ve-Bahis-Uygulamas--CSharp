using GiseUygulamasi.DAT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiseUygulamasi.Helpers
{
    static class BultenHelper
    {
        public static (Bulten,bool) CUD(Bulten b, EntityState state)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                db.Entry(b).State = state;
                if (db.SaveChanges() > 0)
                {
                    return (b, true);
                }
                else
                {
                    return (b, false);
                }
            }
        }
        public static double AtGanyaniBul(int kosuID, int sira)
        {
            int atID = 0;
            var kosuList = KosuBilgisi(kosuID,DateTime.Now.Date);
            double ganyan;
            foreach (var item in kosuList)
            {
                if (item.Sira == sira)
                {
                    atID = item.AtID;
                }
            }
            using (AtBahisEntities db = new AtBahisEntities())
            {
                ganyan = db.AtBilgisi.Find(atID).Ganyan;
            }
            return ganyan;
        }
        public static List<Bulten> BultenGetir(DateTime tarih)
        {
            List<Bulten> bulten = new List<Bulten>();
            using (AtBahisEntities db = new AtBahisEntities())
            {
                bulten = db.Bulten.Where(q => q.Tarih == tarih.Date).ToList();
                return bulten;
            }
        }
        public static List<Bulten> BultenGetir()
        {
            List<Bulten> bulten = new List<Bulten>();
            using (AtBahisEntities db = new AtBahisEntities())
            {
                bulten = db.Bulten.ToList();
                return bulten;
            }
        }
        public static bool BultenTarihKontrolu(DateTime date)
        {
            var a = BultenHelper.BultenGetir().Any(x=>x.Tarih == date.Date);
            if (a)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public static List<Bulten> KosuBilgisi(int kosuID, DateTime tarih)
        {
            List<Bulten> kosu = new List<Bulten>();
            using (AtBahisEntities db = new AtBahisEntities())
            {
                kosu = db.Bulten.Where(q => q.KosuID == kosuID && q.Tarih == tarih.Date).ToList();
                return kosu;
            }
        }

        public static void BultenOlustur()
        {
            BirinciKosuOlustur();
            IkinciKosuOlustur();
            UcuncuKosuOlustur();
            DorduncuKosuOlustur();
            BesinciKosuOlustur();
            AltinciKosuOlustur();
            YedinciKosuOlustur();
        }
        private static void BirinciKosuOlustur()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                for (int i = 1; i <= 6; i++)
                {
                    
                    Bulten b = new Bulten();
                    var at = AtBilgisiHelper.RandomAtSec(0);
                    b.HipodromID = 1;
                    b.KosuID = 1;
                    b.YarisacakAtSayisi = 6;
                    b.AtID = at.AtID;
                    b.AtAdi = at.AtAdi;
                    b.Tarih = DateTime.Now;
                    b.Sira = i;
                    b.PistTipi = false;
                    db.Bulten.Add(b);
                    db.SaveChanges();
                }
            }
        }
        private static void IkinciKosuOlustur()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                for (int i = 1; i <= 6; i++)
                {

                    Bulten b = new Bulten();
                    var at = AtBilgisiHelper.RandomAtSec(1);
                    b.HipodromID = 1;
                    b.KosuID = 2;
                    b.YarisacakAtSayisi = 6;
                    b.AtID = at.AtID;
                    b.AtAdi = at.AtAdi;
                    b.Tarih = DateTime.Now;
                    b.Sira = i;
                    b.PistTipi = false;
                    db.Bulten.Add(b);
                    db.SaveChanges();
                }
            }
        }
        private static void UcuncuKosuOlustur()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                for (int i = 1; i <= 6; i++)
                {

                    Bulten b = new Bulten();
                    var at = AtBilgisiHelper.RandomAtSec(0);
                    b.HipodromID = 1;
                    b.KosuID = 3;
                    b.YarisacakAtSayisi = 6;
                    b.AtID = at.AtID;
                    b.AtAdi = at.AtAdi;
                    b.Tarih = DateTime.Now;
                    b.Sira = i;
                    b.PistTipi = false;
                    db.Bulten.Add(b);
                    db.SaveChanges();
                }
            }
        }
        private static void DorduncuKosuOlustur()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                for (int i = 1; i <= 6; i++)
                {

                    Bulten b = new Bulten();
                    var at = AtBilgisiHelper.RandomAtSec(1);
                    b.HipodromID = 1;
                    b.KosuID = 4;
                    b.YarisacakAtSayisi = 6;
                    b.AtID = at.AtID;
                    b.AtAdi = at.AtAdi;
                    b.Tarih = DateTime.Now;
                    b.Sira = i;
                    b.PistTipi = false;
                    db.Bulten.Add(b);
                    db.SaveChanges();
                }
            }
        }
        private static void BesinciKosuOlustur()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                for (int i = 1; i <= 6; i++)
                {

                    Bulten b = new Bulten();
                    var at = AtBilgisiHelper.RandomAtSec(0);
                    b.HipodromID = 1;
                    b.KosuID = 5;
                    b.YarisacakAtSayisi = 6;
                    b.AtID = at.AtID;
                    b.AtAdi = at.AtAdi;
                    b.Tarih = DateTime.Now;
                    b.Sira = i;
                    b.PistTipi = false;
                    db.Bulten.Add(b);
                    db.SaveChanges();
                }
            }
        }
        private static void AltinciKosuOlustur()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                for (int i = 1; i <= 6; i++)
                {

                    Bulten b = new Bulten();
                    var at = AtBilgisiHelper.RandomAtSec(1);
                    b.HipodromID = 1;
                    b.KosuID = 6;
                    b.YarisacakAtSayisi = 6;
                    b.AtID = at.AtID;
                    b.AtAdi = at.AtAdi;
                    b.Tarih = DateTime.Now;
                    b.Sira = i;
                    b.PistTipi = false;
                    db.Bulten.Add(b);
                    db.SaveChanges();
                }
            }
        }
        private static void YedinciKosuOlustur()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                for (int i = 1; i <= 6; i++)
                {

                    Bulten b = new Bulten();
                    var at = AtBilgisiHelper.RandomAtSec(0);
                    b.HipodromID = 1;
                    b.KosuID = 7;
                    b.YarisacakAtSayisi = 6;
                    b.AtID = at.AtID;
                    b.AtAdi = at.AtAdi;
                    b.Tarih = DateTime.Now;
                    b.Sira = i;
                    b.PistTipi = false;
                    db.Bulten.Add(b);
                    db.SaveChanges();
                }
            }
        }
    }
}
