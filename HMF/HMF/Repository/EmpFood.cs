//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMF.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpFood
    {
        public int Id { get; set; }
        public Nullable<int> employee_Id { get; set; }
        public Nullable<int> food_Id { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Food Food { get; set; }
    }
}