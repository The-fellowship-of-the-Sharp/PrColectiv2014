
using System;

namespace GraveyardManagement.Model.Contract
{
    public class ContractDto
    {
        public int Numar { get; set; }
        public string CnpCetatean { get; set; }
        public string PrenumeCetatean { get; set; }
        public string NumeCetatean { get; set; }
        public string DomiciliuCetatean { get; set; }
        public DateTime DataEliberare { get; set; }
        public DateTime DataExpirare { get; set; }
    }
}
