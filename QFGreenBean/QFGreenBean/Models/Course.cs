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
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.Sections = new HashSet<Section>();
        }
    
        public int CourseId { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Term { get; set; }
        public string Prerequisite { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
    
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Section> Sections { get; set; }

        public int DeleteCourse(int courseID)
        {
            // TO DO
            return 1;
        }
    }
}
