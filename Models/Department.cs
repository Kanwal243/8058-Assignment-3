//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _8058_Assignment_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            this.Course_Offers = new HashSet<Course_Offers>();
            this.Works_For = new HashSet<Works_For>();
        }
    
        public int ID { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrganizationID { get; set; }
        public int ManageBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Offers> Course_Offers { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Works_For> Works_For { get; set; }
        public virtual Project Project { get; set; }
    }
}
