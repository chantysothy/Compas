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
    
    public partial class WareOrderState
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int StateID { get; set; }
        public int CreatedUserID { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual OrderState OrderState { get; set; }
        public virtual SecurityUser SecurityUser { get; set; }
        public virtual WareOrder WareOrder { get; set; }
    }
}
