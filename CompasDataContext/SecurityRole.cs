//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compas.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SecurityRole
    {
        public SecurityRole()
        {
            this.SecurityRoleActions = new HashSet<SecurityRoleAction>();
            this.SecurityUserRoles = new HashSet<SecurityUserRole>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<SecurityRoleAction> SecurityRoleActions { get; set; }
        public virtual ICollection<SecurityUserRole> SecurityUserRoles { get; set; }
    }
}
