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
    
    public partial class AlocareCuProprietar
    {
        public int id { get; set; }
        public Nullable<int> alocareId { get; set; }
        public Nullable<int> nrChitanta { get; set; }
        public Nullable<System.DateTime> dataEmitereChitanta { get; set; }
        public string cnpDetinator { get; set; }
        public Nullable<int> pozaId { get; set; }
    
        public virtual Persoana Persoana { get; set; }
        public virtual Poza Poza { get; set; }
        public virtual AlocareLoc AlocareLoc { get; set; }
    }
}
