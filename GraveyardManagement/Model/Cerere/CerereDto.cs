
using System;

namespace GraveyardManagement.Model.Cerere
{
    public class CerereDto
    {
        public int Numar { get; set; }
        public string CnpCetatean { get; set; }
        public string NumeCetatean { get; set; }
        public string PrenumeCetatean { get; set; }
        public string DomiciliuCetatean { get; set; }
        public int NumarInfocet { get; set; }
        public DateTime DataInregistrare { get; set; }
        public string Stadiu { get; set; }
    }
}
