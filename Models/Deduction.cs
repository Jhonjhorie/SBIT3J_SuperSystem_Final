//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBIT3J_SuperSystem_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deduction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Deduction()
        {
            this.Payrolls = new HashSet<Payroll>();
        }
    
        public int Deduction_ID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public string Deduction_Type { get; set; }
        public Nullable<decimal> Amount_Deducted { get; set; }
        public Nullable<System.DateTime> Date_Of_Deduction { get; set; }
    
        public virtual EmployeeInformation EmployeeInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payroll> Payrolls { get; set; }
    }
}
