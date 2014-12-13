using System;
using System.Drawing;

namespace GraveyardManagement.Model.Statistica
{
    public class StatisticaDTO
    {
        public string Cimitir { get; set; }
        public string Parcela { get; set; }
        public int? NumarMormant { get; set; }
        public DateTime? DataExpirare { get; set; }
        public decimal? Suprafata { get; set; }
        public string CNPDecedat { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Image Poza { get; set; }
        public DateTime? DataEmitere { get; set; }
    }
}
