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
    
    public partial class StudentConstraint
    {
        public int StudentConstraintId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public string Day { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public string StartMinute { get; set; }
        public string EndMinute { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
