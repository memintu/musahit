//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace musahit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostType()
        {
            this.Posts = new HashSet<Posts>();
        }
    
        public int PostTypeId { get; set; }
        public string name { get; set; }
        public Nullable<int> master_post_typeID { get; set; }
        public Nullable<int> order_number { get; set; }
        public string description { get; set; }
        public string detail { get; set; }
        public string post_type_url { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Posts> Posts { get; set; }
    }
}
