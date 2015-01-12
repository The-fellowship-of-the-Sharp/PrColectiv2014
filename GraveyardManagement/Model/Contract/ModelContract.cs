
using System;
using System.Collections.Generic;
using System.Linq;
using GraveyardManagement.Global;
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

        public ContractDto CautaContract(int id)
        {
            var contact = _entities.ContractConcesiune.FirstOrDefault(c => c.numar == id);

            if (contact == null)
            {
                throw new Exception("Contractul cu id primit nu exista in baza de date.");
            }
            var modelCetatean = new ModelCetatean.ModelCetatean(_entities);
            var persona = contact.Persoana.ToList()[0];
            var cetacean = modelCetatean.CautaCetatean(persona.cnp);
            ContractDto return_contract = new ContractDto
            {
                Numar = contact.numar,
                CnpCetatean = cetacean.Cnp,
                PrenumeCetatean = cetacean.Prenume,
                NumeCetatean = cetacean.Nume,
                DomiciliuCetatean = string.Format("{0}, Strada {1}, Numarul {2}, {3}",
                    cetacean.Localitate, cetacean.Strada, cetacean.Numar, cetacean.AlteInformatii),
                DataEliberare = (contact.dataEliberare.HasValue) ? contact.dataEliberare.Value : DateTime.MinValue,
                DataExpirare = (contact.dataExpirare.HasValue) ? contact.dataExpirare.Value : DateTime.MaxValue
            };
            return return_contract;
        }

        public void StergeContract(int numar)
        {
            var contract = _entities.ContractConcesiune.FirstOrDefault(c => c.numar == numar);
            if (contract == null)
                return;

            var conrcarcNrContract = contract.nrContract;

            _entities.ContractConcesiune.Remove(contract);
            _entities.Istoric.Add(new Istoric
            {
                numeUtilizator = GlobalVariables.CurrentUser.AccountName,
                data = DateTime.Now,
                numarDocument = conrcarcNrContract,
                detalii = "CONTRACT;STERGERE"
            });

            _entities.SaveChanges();
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

        public List<ContractDto> GetAllContracte()
        {
            var contracte = new List<ContractDto>();

            var modelCetatean = new ModelCetatean.ModelCetatean(_entities);


            var rawContracte =
                _entities.ContractConcesiune.Where(c => c.alocareId > 0);

            foreach (var contractConcesiune in rawContracte)
            {
                var persoana = contractConcesiune.Persoana.ToList()[0] ;
                var cetatean = modelCetatean.CautaCetatean(persoana.cnp);
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

        public int findLocAlocat(string cnpDecedat)
        {
            var locAlocat = _entities.AlocareLoc.FirstOrDefault(l => l.cnpDecedat == cnpDecedat);

            if (locAlocat == null)
            {
                throw new Exception("Decedatul nu are loc alocat.");
            }

            return locAlocat.id;
        }
        
        public Boolean ChechExistaContract(int idloc)
        {
            var contr = _entities.ContractConcesiune.FirstOrDefault(c => c.alocareId == idloc);
            if (contr != null)
            {
                return true;
            }
            return false;
        }
        
        public void AdaugaPropContract(int nrContract, DateTime dataEmit, DateTime dateExp, int idLoc)
        {


            var existaloc = _entities.AlocareLoc.FirstOrDefault(l => l.id == idLoc);

            if (existaloc == null)
            {
                throw new Exception("Decedatul nu are loc atribuit. Va rugam sa atribiti loc decedatului.");
            }

            _entities.ContractConcesiune.Add(new ContractConcesiune
            {
                nrContract = nrContract,
                dataEliberare = dataEmit,
                dataExpirare = dateExp,
                alocareId = idLoc
                
            });


            _entities.Istoric.Add(new Istoric
            {
                numeUtilizator = GlobalVariables.CurrentUser.AccountName,
                data = DateTime.Now,
                numarDocument = nrContract,
                detalii = string.Format("CONTRACT;ADAUGARE;{0}", idLoc)
            });

            _entities.SaveChanges();
        }

        public void AdaugaDetinator(int nrContract, string CNP)
        {
            var cetatean = _entities.Persoana.FirstOrDefault(c => c.cnp == CNP && c.domiciliuId.HasValue);

            if (cetatean == null)
            {
                throw new Exception("Acest persona nu exista in baza de date.");
            }

            var contact = _entities.ContractConcesiune.FirstOrDefault(c => c.nrContract == nrContract);

            if (contact == null)
            {
                throw new Exception("Acest contract nu exista in baza de date. Va rugam contactati IT suport.");
            }

            contact.Persoana.Add( cetatean);
            cetatean.ContractConcesiune.Add(contact);
        }

        public void AdaugaAlocareFaraProprietar(int alocaid, int solicitare, int adeverinta)
        {
            var alocare = _entities.AlocareLoc.FirstOrDefault(l => l.id == alocaid);

            if (alocare == null)
            {
                throw new Exception("Id alocari este incorect. Va rugam contactati IT suport.");
            }

            _entities.AlocareFaraProprietar.Add(new AlocareFaraProprietar
            {
                alocareId = alocaid,
                solicitareAsistentaSociala = solicitare,
                nrAdeverintaInhumare =  adeverinta
            });
            _entities.Istoric.Add(new Istoric
            {
                numeUtilizator = GlobalVariables.CurrentUser.AccountName,
                data = DateTime.Now,
                numarDocument = alocaid,
                detalii = string.Format("ALOCAREFARAPROPRIETAR;ADAUGARE;{0}", alocaid)
            });

            _entities.SaveChanges();
        }
        public void AdaugareAlocareProprietar(int alocareId, int nrChitanta, DateTime data)
        {
            var loc = _entities.AlocareLoc.FirstOrDefault(l => l.id == alocareId);

            if (loc == null)
            {
                throw new Exception("Id alocari este incorect. Va rugam contactati IT suport.");
            }

            _entities.AlocareCuProprietar.Add(new AlocareCuProprietar
            {
                alocareId = alocareId,
                nrChitanta =  nrChitanta,
                dataEmitereChitanta = data
            });

            _entities.Istoric.Add(new Istoric
            {
                numeUtilizator = GlobalVariables.CurrentUser.AccountName,
                data = DateTime.Now,
                numarDocument = alocareId,
                detalii = string.Format("ALOCARECUPROPRIETAR;ADAUGARE;{0}", alocareId)
            });

            _entities.SaveChanges();
        }

        public void ActualizeazaCerere(int numarContract,int nrChitanta, DateTime dateContr, DateTime dateChitanta)
        {
            var contract = _entities.ContractConcesiune.FirstOrDefault(c => c.numar == numarContract);
            if (contract == null)
            {
                throw new Exception(string.Format("Contractul cu numarul {0} nu a fost gasita!", numarContract));
            }
            var dataContractVeche = contract.dataExpirare;
            contract.dataExpirare = dateContr;
            var alocid = contract.alocareId;
            var alocareprop = _entities.AlocareCuProprietar.FirstOrDefault(a => a.alocareId == alocid);

            if (alocareprop == null)
            {
                throw new Exception(string.Format("Alocare loc cu proprietar pe alocareid {0} nu a fost gasita!", alocid));
            }

            var nrchitantavechi = alocareprop.nrChitanta;
            alocareprop.nrChitanta = nrChitanta;
            var datachitantaveche = alocareprop.dataEmitereChitanta;
            alocareprop.dataEmitereChitanta = dateChitanta;

            _entities.Istoric.Add(new Istoric
            {
                numeUtilizator = GlobalVariables.CurrentUser.AccountName,
                data = DateTime.Now,
                numarDocument = contract.nrContract,
                detalii = string.Format("Contract;ACTUALIZARE;{0};{1}", dataContractVeche, dateContr)
            });

            _entities.Istoric.Add(new Istoric
            {
                numeUtilizator = GlobalVariables.CurrentUser.AccountName,
                data = DateTime.Now,
                numarDocument = alocareprop.alocareId,
                detalii = string.Format("ALOCARECUPROPRIETAR;ACTUALIZARE;{0};{1};{2},{3}", nrchitantavechi, nrChitanta,datachitantaveche,dateChitanta)
            });

            _entities.SaveChanges();
        }
    }
}
