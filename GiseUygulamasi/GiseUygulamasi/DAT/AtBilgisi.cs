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
    
    public partial class AtBilgisi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AtBilgisi()
        {
            this.Sonuc = new HashSet<Sonuc>();
            this.Bulten = new HashSet<Bulten>();
        }
    
        public int AtID { get; set; }
        public string AtAdi { get; set; }
        public string AnaAdi { get; set; }
        public string BabaAdi { get; set; }
        public double Ganyan { get; set; }
        public int Irk { get; set; }
        public bool AktifMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sonuc> Sonuc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bulten> Bulten { get; set; }
    }
}
