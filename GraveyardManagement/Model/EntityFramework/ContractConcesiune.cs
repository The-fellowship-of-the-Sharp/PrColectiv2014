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
    
    public partial class ContractConcesiune
    {
        public ContractConcesiune()
        {
            this.Persoana = new HashSet<Persoana>();
        }
    
        public int numar { get; set; }
        public Nullable<System.DateTime> dataEliberare { get; set; }
        public Nullable<System.DateTime> dataExpirare { get; set; }
        public Nullable<int> alocareId { get; set; }
        public Nullable<int> nrContract { get; set; }
    
        public virtual AlocareLoc AlocareLoc { get; set; }
        public virtual ICollection<Persoana> Persoana { get; set; }
    }
}
