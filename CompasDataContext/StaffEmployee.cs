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
    
    public partial class StaffEmployee
    {
        public StaffEmployee()
        {
            this.StaffDepartmentEmployees = new HashSet<StaffDepartmentEmployee>();
            this.StaffEmployeeWorkPlaces = new HashSet<StaffEmployeeWorkPlace>();
            this.StaffSalaries = new HashSet<StaffSalary>();
            this.StaffTeamEmployees = new HashSet<StaffTeamEmployee>();
            this.WareDocumentStaffDetails = new HashSet<WareDocumentStaffDetail>();
            this.WareOrders = new HashSet<WareOrder>();
        }
    
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Flat { get; set; }
        public string Phone { get; set; }
        public string MobPhone { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
    
        public virtual SecurityUser SecurityUser { get; set; }
        public virtual ICollection<StaffDepartmentEmployee> StaffDepartmentEmployees { get; set; }
        public virtual ICollection<StaffEmployeeWorkPlace> StaffEmployeeWorkPlaces { get; set; }
        public virtual ICollection<StaffSalary> StaffSalaries { get; set; }
        public virtual ICollection<StaffTeamEmployee> StaffTeamEmployees { get; set; }
        public virtual ICollection<WareDocumentStaffDetail> WareDocumentStaffDetails { get; set; }
        public virtual ICollection<WareOrder> WareOrders { get; set; }
    }
}
