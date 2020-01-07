using AtYarisi_OzgurBIKMAZ.DAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtYarisi_OzgurBIKMAZ.Helper
{
    public static class BultenHelper
    {
        
        public static List<Bulten> KosuBilgisi(int kosuID)
        {
            List<Bulten> kosu = new List<Bulten>();
            using (AtBahisEntities db = new AtBahisEntities())
            {
                kosu = db.Bulten.Where(q => q.KosuID == kosuID).ToList();
                return kosu;
            }
        }
        public static string AtAdiBul(int atID, int kosuID)
        {
            var kosuListesi = KosuBilgisi(kosuID);
            string atAdi = "";
            foreach (Bulten item in kosuListesi)
            {
                if (atID == item.Sira)
                {
                    atAdi = item.AtAdi;
                }
            }
            return atAdi;
        }
        
    }
}
