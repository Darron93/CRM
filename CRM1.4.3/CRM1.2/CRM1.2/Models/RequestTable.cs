//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM1._2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestTable()
        {
            this.RequestDetails = new HashSet<RequestDetail>();
        }
    
        public int RequestID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public string RequestDateString { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public Nullable<int> RequestTime { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> TypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestDetail> RequestDetails { get; set; }
    }
}