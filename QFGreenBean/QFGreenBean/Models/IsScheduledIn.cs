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
    
    public partial class IsScheduledIn
    {
        public int IsScheduledInId { get; set; }
        public Nullable<int> StudentScheduleId { get; set; }
        public Nullable<int> SectionId { get; set; }
    
        public virtual StudentSchedule StudentSchedule { get; set; }
        public virtual Section Section { get; set; }
    }
}
