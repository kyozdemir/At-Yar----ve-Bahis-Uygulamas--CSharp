using AtYarisi_OzgurBIKMAZ.DAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AtYarisi_OzgurBIKMAZ.Helper
{
    class AtBilgisiHelper
    {
        public static int AtIDBul(int sira, int kosuID)
        {
            var kosuListesi = BultenHelper.KosuBilgisi(kosuID);
            int atid = 0;
            foreach (Bulten item in kosuListesi)
            {
                if (sira == item.Sira)
                {
                    atid = item.AtID;
                }
            }
            return atid;
        }

        
    }
}
