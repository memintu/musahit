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
    
    public partial class Faq
    {
        public int FaqId { get; set; }
        public Nullable<int> SubjectId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string ExternalLink { get; set; }
        public string SpecialValue1 { get; set; }
        public string SpecialValue2 { get; set; }
        public string SpecialValue3 { get; set; }
        public Nullable<int> OrderNumber { get; set; }
    }
}