using GiseUygulamasi.DAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiseUygulamasi.Helpers
{
    class AtBilgisiHelper
    {
        static Random r = new Random();
        public static AtBilgisi RandomAtSec(int irk)
        {
            var atListesi = AtListesi();

            using (AtBahisEntities db = new AtBahisEntities())
            {
                AtBilgisi at;
                for(; ; )
                {
                    var atID = r.Next(1, 52);
                    if (atID == 35)
                    {
                        continue;
                    }
                    at = db.AtBilgisi.Find(atID);
                    if (at.Irk == irk && at.AktifMi == true)
                    {
                        at.AktifMi = false;
                        db.SaveChanges();
                        break; 
                    }
                }
                return at;
            }
        }
        public static void AtlariYenile()
        {
            var atListesi = AtListesi();
            using (AtBahisEntities db = new AtBahisEntities())
            {
                AtBilgisi at;
                for (int i = 1; i <= atListesi.Count+1; i++)
                {
                    if (i == 35)
                    {

                        continue;
                    }
                    else
                    {
                        at = db.AtBilgisi.Find(i);
                        at.AktifMi = true;
                        db.SaveChanges();
                    }
                }
            }
        }
        private static List<AtBilgisi> AtListesi()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                return db.AtBilgisi.ToList();
            }
        }
    }
}
