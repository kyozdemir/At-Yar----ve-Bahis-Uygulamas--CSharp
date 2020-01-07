using AtYarisi_OzgurBIKMAZ.DAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AtYarisi_OzgurBIKMAZ.Helper
{
    class SonucHelper
    {
        public static void SonuclariKaydet(Sonuc s)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                db.Sonuc.Add(s);
                db.SaveChanges();
            }
        }
        public static Sonuc SonucAl(int hipodromID, int kosuID, int siralama, int atNo)
        {
            Sonuc s = new Sonuc();

            s.atNo = atNo;
            s.KosuID = kosuID;
            s.AtID = AtBilgisiHelper.AtIDBul(s.atNo, s.KosuID);
            s.Siralama = siralama;
            s.Tarih = DateTime.Now;
            s.HipodromID = hipodromID;

            return s;
            
        }
        public static List<Sonuc> SonuclariGetir(DateTime tarih)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                return db.Sonuc.Where(x => x.Tarih == tarih.Date).ToList();
            }
        }
        public static List<Sonuc> AltiliGanyanSonuclari(DateTime tarih)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                return db.Sonuc.Where(x => x.KosuID >= 2 && x.Tarih == tarih.Date && x.Siralama == 1).ToList();
            }
        }



    }
}
