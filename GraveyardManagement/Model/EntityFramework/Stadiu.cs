//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraveyardManagement.Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stadiu
    {
        public Stadiu()
        {
            this.CerereLoc = new HashSet<CerereLoc>();
        }
    
        public int id { get; set; }
        public string nume { get; set; }
    
        public virtual ICollection<CerereLoc> CerereLoc { get; set; }
    }
}
