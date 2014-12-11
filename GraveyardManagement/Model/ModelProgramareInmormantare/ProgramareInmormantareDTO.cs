using System;

namespace GraveyardManagement.Model.ModelProgramareInmormantare
{
    public class ProgramareInmormantareDTO
    {
        public int Id { get; set; }
        public string CnpDecedat { get; set; }
        public string NumeDecedat { get; set; }
        public string PrenumeDecedat { get; set; }
        public string Religie { get; set; }
        public string Cimitir { get; set; }
        public string Parcela { get; set; }
        public int? NumarMormant { get; set; }
        public DateTime? Data { get; set; }
    }
}
