//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QFGreenBean.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentRecord()
        {
            this.IsEnrolledIns = new HashSet<IsEnrolledIn>();
            this.IsEnrollingIns = new HashSet<IsEnrollingIn>();
        }
    
        public Nullable<int> StudentId { get; set; }
        public int StudentRecordId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsEnrolledIn> IsEnrolledIns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsEnrollingIn> IsEnrollingIns { get; set; }
        public virtual Student Student { get; set; }
    }
}
