//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiseUygulamasi.DAT
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bulten
    {
        public int BultenID { get; set; }
        public int HipodromID { get; set; }
        public System.DateTime Tarih { get; set; }
        public int KosuID { get; set; }
        public Nullable<int> KosuAdi { get; set; }
        public int Sira { get; set; }
        public int AtID { get; set; }
        public bool PistTipi { get; set; }
        public int YarisacakAtSayisi { get; set; }
        public Nullable<System.TimeSpan> BaslangicSaati { get; set; }
        public string AtAdi { get; set; }
    
        public virtual AtBilgisi AtBilgisi { get; set; }
        public virtual Hipodrom Hipodrom { get; set; }
    }
}