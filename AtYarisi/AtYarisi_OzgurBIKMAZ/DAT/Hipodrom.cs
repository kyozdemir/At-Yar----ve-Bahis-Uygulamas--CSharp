//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AtYarisi_OzgurBIKMAZ.DAT
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hipodrom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hipodrom()
        {
            this.Bulten = new HashSet<Bulten>();
            this.Kupon = new HashSet<Kupon>();
        }
    
        public int HipodromID { get; set; }
        public string HipodromAdi { get; set; }
        public int SehirID { get; set; }
        public int IlceID { get; set; }
        public Nullable<int> CimPistSayisi { get; set; }
        public Nullable<int> KumPistSayisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bulten> Bulten { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kupon> Kupon { get; set; }
    }
}
