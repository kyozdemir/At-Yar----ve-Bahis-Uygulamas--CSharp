using AtYarisi_OzgurBIKMAZ.DAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtYarisi_OzgurBIKMAZ
{
    static class KuponHelper
    {
        public static bool KuponUpdate(Kupon k)
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                db.Entry(k).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }
        public static List<Kupon> KuponlariGetir()
        {
            using (AtBahisEntities db = new AtBahisEntities())
            {
                return db.Kupon.ToList();
            }
        }
    }
}
