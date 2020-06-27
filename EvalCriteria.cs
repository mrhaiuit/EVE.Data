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
    
    public partial class EvalCriteria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EvalCriteria()
        {
            this.EvalGuides = new HashSet<EvalGuide>();
            this.SubPrincipalCriterias = new HashSet<SubPrincipalCriteria>();
            this.EvalDetails = new HashSet<EvalDetail>();
        }
    
        public int EvalCriteriaId { get; set; }
        public Nullable<int> EvalStandardId { get; set; }
        public string EvalCriteriaCode { get; set; }
        public string EvalCriteriaName { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> Idx { get; set; }
    
        public virtual EvalStandard EvalStandard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvalGuide> EvalGuides { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubPrincipalCriteria> SubPrincipalCriterias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvalDetail> EvalDetails { get; set; }
    }
}
