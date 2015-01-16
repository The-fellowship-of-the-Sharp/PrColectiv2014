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
    
    public partial class Persoana
    {
        public Persoana()
        {
            this.AlocareLoc = new HashSet<AlocareLoc>();
            this.CerereLoc = new HashSet<CerereLoc>();
            this.ProgramareInmormantare = new HashSet<ProgramareInmormantare>();
            this.Reclamatie = new HashSet<Reclamatie>();
            this.ContractConcesiune = new HashSet<ContractConcesiune>();
        }
    
        public string cnp { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public Nullable<int> domiciliuId { get; set; }
    
        public virtual ICollection<AlocareLoc> AlocareLoc { get; set; }
        public virtual ICollection<CerereLoc> CerereLoc { get; set; }
        public virtual Domiciliu Domiciliu { get; set; }
        public virtual ICollection<ProgramareInmormantare> ProgramareInmormantare { get; set; }
        public virtual ICollection<Reclamatie> Reclamatie { get; set; }
        public virtual ICollection<ContractConcesiune> ContractConcesiune { get; set; }
    }
}
