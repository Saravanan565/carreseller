//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rentcar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class returncar
    {
        public int id { get; set; }
        public string carno { get; set; }
        public Nullable<int> custid { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> elsp { get; set; }
        public Nullable<int> fine { get; set; }
    }
}
