
using System.Collections.Generic;
using System.Linq;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model.Contract
{
    public class ModelContract
    {
        private readonly NecropolisEntities _entities;

        public ModelContract(NecropolisEntities entities)
        {
            _entities = entities;
        }

        public List<ContractDto> CautaContracte(string cnpCetatean)
        {
            var contracte = new List<ContractDto>();

            var rawContracte =
                _entities.ContractConcesiune.Where(c => c.Persoana.FirstOrDefault(p => p.cnp == cnpCetatean) != null);

            return contracte;
        }
    }
}
