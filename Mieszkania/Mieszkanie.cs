//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mieszkania
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mieszkanie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mieszkanie()
        {
            this.Remonty = new HashSet<Remonty>();
            this.Umowa = new HashSet<Umowa>();
        }
    
        public int IdMieszkania { get; set; }
        public string Miasto { get; set; }
        public string Kod_Pocztowy { get; set; }
        public string Ulica { get; set; }
        public string Nr_Domu { get; set; }
        public string Nr_Mieszkania { get; set; }
        public string Status_Mieszkania { get; set; }
        public bool Posiadane { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remonty> Remonty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Umowa> Umowa { get; set; }
    }
}
