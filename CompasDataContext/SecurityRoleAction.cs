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
    
    public partial class SecurityRoleAction
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int ActionID { get; set; }
        public bool Allow { get; set; }
    
        public virtual SecurityAction SecurityAction { get; set; }
        public virtual SecurityRole SecurityRole { get; set; }
    }
}
