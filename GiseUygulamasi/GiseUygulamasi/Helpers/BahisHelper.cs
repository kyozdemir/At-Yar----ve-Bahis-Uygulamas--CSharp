using GiseUygulamasi.DAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiseUygulamasi.Helpers
{
    static class BahisHelper
    {
        public static List<string> BahisIsimleriniAl()
        {
            List<string> bahisisimleri = new List<string>();
            var bahisList = BahisleriAl();
            using (AtBahisEntities db = new AtBahisEntities())
            {
                foreach (BahisTipleri item in bahisList)
                {
                    bahisisimleri.Add(item.BahisAdi);
                }
                return bahisisimleri;
            }
        }
        public static List<BahisTipleri> BahisleriAl()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                return db.BahisTipleri.ToList();
            }
        }
        public static int BahisTipiIDBul(string bahisAdi)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                var bahis = (from x in db.BahisTipleri where x.BahisAdi == bahisAdi select x).FirstOrDefault<BahisTipleri>();
                return bahis.BahisTipiID;
            }
        }

    }
}
