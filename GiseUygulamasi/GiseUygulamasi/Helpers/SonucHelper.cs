using GiseUygulamasi.DAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiseUygulamasi.Helpers
{
    class SonucHelper
    {
        public static List<Sonuc> AltiliGanyanSonuclari(DateTime tarih)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                return db.Sonuc.Where(x => x.KosuID >= 2 && x.Tarih == tarih.Date && x.Siralama == 1).ToList();
            }
        }
        public static List<Sonuc> SonuclariGetir(DateTime tarih)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                return db.Sonuc.Where(x => x.Tarih == tarih.Date).ToList();
            }
        }
    }
}
