//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvp4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPhysio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserPhysio()
        {
            this.UserRoleMappings = new HashSet<UserRoleMapping>();
        }
    
        public int UserID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public bool IsEmailVerified { get; set; }
        public System.Guid ActivationCode { get; set; }
        public int Hprn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoleMapping> UserRoleMappings { get; set; }
    }
}
