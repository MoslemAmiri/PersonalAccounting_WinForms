//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting.DataLayer.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class CostOrIncomeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CostOrIncomeType()
        {
            this.CostOrIncomes = new HashSet<CostOrIncome>();
        }
    
        public long Id { get; set; }
        public string Title { get; set; }
        public byte Type { get; set; }
        public string CreationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostOrIncome> CostOrIncomes { get; set; }
    }
}