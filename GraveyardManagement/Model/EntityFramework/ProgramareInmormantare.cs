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
    
    public partial class ProgramareInmormantare
    {
        public int id { get; set; }
        public string cnpDecedat { get; set; }
        public Nullable<int> religieId { get; set; }
        public Nullable<int> mormantId { get; set; }
        public Nullable<System.DateTime> dataInmormantarii { get; set; }
    
        public virtual Mormant Mormant { get; set; }
        public virtual Persoana Persoana { get; set; }
        public virtual Religie Religie { get; set; }
    }
}
