//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deposit
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public int CompanyId { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
