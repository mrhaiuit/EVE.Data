//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVE.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class EvalDetail
    {
        public int EvalDetailId { get; set; }
        public Nullable<int> EvalMasterId { get; set; }
        public Nullable<int> EvalCriteriaId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string EvalResultCode { get; set; }
        public string Sample { get; set; }
        public string Attachment { get; set; }
        public Nullable<int> EvalForEmployee { get; set; }
    
        public virtual EvalMaster EvalMaster { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
