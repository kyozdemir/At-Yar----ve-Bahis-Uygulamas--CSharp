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
    
    public partial class Kupon
    {
        public int KuponID { get; set; }
        public string KuponNo { get; set; }
        public int HipodromID { get; set; }
        public System.DateTime Tarih { get; set; }
        public int BahisTipiID { get; set; }
        public int Tahmin { get; set; }
        public double Ganyan { get; set; }
        public int Misli { get; set; }
        public double Tutar { get; set; }
        public Nullable<bool> KuponDurumu { get; set; }
        public int KosuID { get; set; }
    
        public virtual BahisTipleri BahisTipleri { get; set; }
        public virtual Hipodrom Hipodrom { get; set; }
    }
}