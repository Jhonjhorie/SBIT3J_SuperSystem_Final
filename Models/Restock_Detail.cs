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
    
    public partial class Restock_Detail
    {
        public int RestockDetail_ID { get; set; }
        public Nullable<int> Restock_ID { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public Nullable<int> Quantity_Added { get; set; }
        public Nullable<decimal> Total_Amount { get; set; }
        public virtual Product_Info Product_Info { get; set; }
        public virtual Restock Restock { get; set; }
    }
}
