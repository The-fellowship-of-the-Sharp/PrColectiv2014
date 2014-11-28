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
    
    public partial class AlocareLoc
    {
        public AlocareLoc()
        {
            this.AlocareCuProprietar = new HashSet<AlocareCuProprietar>();
            this.AlocareFaraProprietar = new HashSet<AlocareFaraProprietar>();
            this.ContractConcesiune = new HashSet<ContractConcesiune>();
        }
    
        public int id { get; set; }
        public Nullable<decimal> suprafata { get; set; }
        public Nullable<System.DateTime> dataExpirare { get; set; }
        public Nullable<int> mormantId { get; set; }
        public string cnpDecedat { get; set; }
    
        public virtual ICollection<AlocareCuProprietar> AlocareCuProprietar { get; set; }
        public virtual ICollection<AlocareFaraProprietar> AlocareFaraProprietar { get; set; }
        public virtual Persoana Persoana { get; set; }
        public virtual Mormant Mormant { get; set; }
        public virtual ICollection<ContractConcesiune> ContractConcesiune { get; set; }
    }
}