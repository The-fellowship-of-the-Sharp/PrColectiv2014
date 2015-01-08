
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using GraveyardManagement.Global;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model.Cerere
{
    public class ModelCerere
    {
        private readonly NecropolisEntities _entities;

        public ModelCerere(NecropolisEntities entities)
        {
            _entities = entities;
        }

        public void AdaugaCerere(string cnpCetatean, int nrInfocet, DateTime dataInregistrare)
        {
            //ceva verificari: daca nrInfocet exista deja?

            //gasire stadiu Intern
            var stadiuIntern = _entities.Stadiu.FirstOrDefault(s => s.nume == "Intern");

            if (stadiuIntern == null)
            {
                throw new Exception("Cererea nu a putut fi adaugata. Va rugam contactati IT suport.");
            }

            _entities.CerereLoc.Add(new CerereLoc
            {
                cnpPersoana = cnpCetatean,
                nrInfocet = nrInfocet,
                dataInregistrare = dataInregistrare,
                stadiuId = stadiuIntern.id
            });

            _entities.Istoric.Add(new Istoric
            {
                numeUtilizator = GlobalVariables.CurrentUser.Name,
                data = DateTime.Now,
                numarDocument = nrInfocet,
                detalii = string.Format("CERERE;ADAUGARE;{{}}")
            });

            _entities.SaveChanges();
        }

        public CerereDto CautaCerere(int nrInfocet, DateTime dataInregistrare)
        {
            var cerere = _entities.CerereLoc.FirstOrDefault(c => c.nrInfocet == nrInfocet && 
                EntityFunctions.TruncateTime(c.dataInregistrare) == dataInregistrare.Date);

            if (cerere == null)
            {
                throw new Exception(string.Format("Cererea cu numarul Infocet: {0} si inregistrata pe data de: {1} nu a fost gasita!", nrInfocet,
                    dataInregistrare));
            }
            var modelCetatean = new ModelCetatean.ModelCetatean(_entities);

            var cetatean = modelCetatean.CautaCetatean(cerere.cnpPersoana);

            var stadiu = _entities.Stadiu.FirstOrDefault(s => s.id == cerere.stadiuId);

            if (stadiu == null)
            {
                throw new Exception(string.Format("Stadiul: {0} atribuit cererii cu numarul Infocet {1} din data de {2}, nu exte valid!",
                    cerere.stadiuId, nrInfocet, dataInregistrare));
            }

            return new CerereDto
            {
                Numar = cerere.numar,
                NumarInfocet = cerere.nrInfocet.GetValueOrDefault(),
                DataInregistrare = cerere.dataInregistrare.GetValueOrDefault(),
                Stadiu = stadiu.nume,
                CnpCetatean = cetatean.Cnp,
                NumeCetatean = cetatean.Nume,
                PrenumeCetatean = cetatean.Prenume,
                DomiciliuCetatean = string.Format("{0}, Strada {1}, Numarul {2}, {3}",
                    cetatean.Localitate, cetatean.Strada, cetatean.Numar, cetatean.AlteInformatii)
            };
        }

        public CerereDto CautaCerere(int numar)
        {
            var cerere = _entities.CerereLoc.FirstOrDefault(c => c.numar == numar);

            if (cerere == null)
            {
                throw new Exception(string.Format("Cererea cu numarul {0} nu a fost gasita!", numar));
            }
            var modelCetatean = new ModelCetatean.ModelCetatean(_entities);

            var cetatean = modelCetatean.CautaCetatean(cerere.cnpPersoana);

            var stadiu = _entities.Stadiu.FirstOrDefault(s => s.id == cerere.stadiuId);

            if (stadiu == null)
            {
                throw new Exception(string.Format("Stadiul: {0} atribuit cererii cu numarul {1} nu exte valid!",
                    cerere.stadiuId, numar));
            }

            return new CerereDto
            {
                Numar = cerere.numar,
                NumarInfocet = cerere.nrInfocet.GetValueOrDefault(),
                DataInregistrare = cerere.dataInregistrare.GetValueOrDefault(),
                Stadiu = stadiu.nume,
                CnpCetatean = cetatean.Cnp,
                NumeCetatean = cetatean.Nume,
                PrenumeCetatean = cetatean.Prenume,
                DomiciliuCetatean = string.Format("{0}, Strada {1}, Numarul {2}, {3}",
                    cetatean.Localitate, cetatean.Strada, cetatean.Numar, cetatean.AlteInformatii)
            };
        }

        public void ActualizeazaCerere(int numar, string numeStadiuNou)
        {
            var cerere = _entities.CerereLoc.FirstOrDefault(c => c.numar == numar);

            if (cerere == null)
            {
                throw new Exception(string.Format("Cererea cu numarul {0} nu a fost gasita!", numar));
            }

            var stadiuVechiId = cerere.stadiuId;

            var stadiuVechi = _entities.Stadiu.FirstOrDefault(s => s.id == stadiuVechiId);

            var numeStadiuVechi = "NULL";

            if (stadiuVechi != null)
            {
                numeStadiuVechi = stadiuVechi.nume;
            }

            var stadiuNou = _entities.Stadiu.FirstOrDefault(s => s.nume == numeStadiuNou);

            if (stadiuNou == null)
            {
                throw new Exception(string.Format("Stadiul cu numele {0} nu exista!", numeStadiuNou));
            }

            cerere.stadiuId = stadiuNou.id;

            _entities.Istoric.Add(new Istoric
            {
                numeUtilizator = GlobalVariables.CurrentUser.Name,
                data = DateTime.Now,
                numarDocument = cerere.nrInfocet,
                detalii = string.Format("CERERE;ACTUALIZARE;{0};{1}", numeStadiuVechi, numeStadiuNou)
            });

            _entities.SaveChanges();
        }

        public void StergeCerere(int numar)
        {
            var cerere = _entities.CerereLoc.FirstOrDefault(c => c.numar == numar);

            if (cerere == null)
                return;

            var cerereNrInfocet = cerere.nrInfocet;

            _entities.CerereLoc.Remove(cerere);

            _entities.Istoric.Add(new Istoric
            {
                numeUtilizator = GlobalVariables.CurrentUser.Name,
                data = DateTime.Now,
                numarDocument = cerereNrInfocet,
                detalii = "CERERE;STERGERE"
            });

            _entities.SaveChanges();
        }

        public List<string> ObtineToateStadiile()
        {
            return _entities.Stadiu.Select(s => s.nume).ToList();
        }
    }
}
