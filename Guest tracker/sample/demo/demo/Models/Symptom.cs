//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Symptom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Symptom()
        {
            this.GuestSymptoms = new HashSet<GuestSymptom>();
        }
    
        public int SymptomId { get; set; }
        public string SymptomName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuestSymptom> GuestSymptoms { get; set; }
    }
}