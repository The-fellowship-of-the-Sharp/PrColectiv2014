
using System;
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

            var modelCetatean = new ModelCetatean.ModelCetatean(_entities);

            var cetatean = modelCetatean.CautaCetatean(cnpCetatean);

            var rawContracte =
                _entities.ContractConcesiune.Where(c => c.Persoana.FirstOrDefault(p => p.cnp == cnpCetatean) != null);

            foreach (var contractConcesiune in rawContracte)
            {
                contracte.Add(new ContractDto
                {
                    Numar = contractConcesiune.numar,
                    CnpCetatean = cetatean.Cnp,
                    PrenumeCetatean = cetatean.Prenume,
                    NumeCetatean = cetatean.Nume,
                    DomiciliuCetatean = string.Format("{0}, Strada {1}, Numarul {2}, {3}",
                        cetatean.Localitate, cetatean.Strada, cetatean.Numar, cetatean.AlteInformatii),
                    DataEliberare = (contractConcesiune.dataEliberare.HasValue) ? contractConcesiune.dataEliberare.Value : DateTime.MinValue,
                    DataExpirare = (contractConcesiune.dataExpirare.HasValue) ? contractConcesiune.dataExpirare.Value : DateTime.MaxValue
                });
            }

            return contracte;
        }
    }
}
