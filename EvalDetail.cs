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
        public int EvalMasterId { get; set; }
        public Nullable<int> EvalStandardId { get; set; }
        public string EvalStandardName { get; set; }
        public int EvalCriteriaId { get; set; }
        public string EvalCriteriaName { get; set; }
        public string EvalResultCode { get; set; }
        public string EvalResultPrincipal { get; set; }
        public string Sample { get; set; }
        public string Attachment { get; set; }
    
        public virtual EvalCriteria EvalCriteria { get; set; }
        public virtual EvalMaster EvalMaster { get; set; }
    }
}
