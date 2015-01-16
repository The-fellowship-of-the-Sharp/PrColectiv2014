using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model.ModelDecedat
{
    public class ModelDecedat
    {
        private readonly NecropolisEntities _entities;

        public ModelDecedat(NecropolisEntities entities)
        {
            _entities = entities;
        }

        public void AdaugaDecedat(string cnp, string nume, string prenume)
        {

            _entities.Persoana.Add(new Persoana
            {
                cnp = cnp,
                nume = nume,
                prenume = prenume,
            });

            _entities.SaveChanges();
        }

        public void TransformaCetateanInDecedat(string cnp)
        {
            var cetatean = _entities.Persoana.FirstOrDefault(cet => cet.cnp == cnp && cet.domiciliuId != null);
            if (cetatean == null)
            {
                throw new Exception("Cetateanul cu CNP-ul introdus nu exista!");
            }
            cetatean.domiciliuId = null;
            cetatean.Domiciliu = null;
            _entities.SaveChanges();

        }
        public bool ExistaCetateanCuCNPulDecedatului(string cnp)
        {
            return _entities.Persoana.FirstOrDefault(cetatean => cetatean.cnp == cnp && cetatean.domiciliuId != null) != null;
        }
        public DecedatDTO CautaDecedat(string cnp)
        {
            var decedatDb = _entities.Persoana.FirstOrDefault(d => d.cnp == cnp && d.domiciliuId == null);

            if (decedatDb == null)
            {
                throw new Exception(string.Format("Decedatul cu CNP-ul: {0} nu a fost gasit!", cnp));
            }

            return new DecedatDTO
            {
                Cnp = cnp,
                Nume = decedatDb.nume,
                Prenume = decedatDb.prenume
            };
        }

        public void AtribuieMormant(string cnpDecedat, int cimitirId, string parcela, int numar)
        {
            var mormant = _entities.Mormant.FirstOrDefault(m => m.cimitirId == cimitirId && m.parcela == parcela && m.numar == numar);

            string numeCimitir = _entities.Cimitir.FirstOrDefault(c=>c.id==cimitirId).nume;

            if (mormant == null)
            {
                throw new Exception(string.Format("Mormantul cu numarul {0} aflat pe parcela {1} nu exista in {2}! Va rugam sa reintroduceti datele!",numar,parcela,numeCimitir));
            }

            if (mormant.AlocareLoc.Count != 0)
            {
                throw new Exception(string.Format("Mormantul cu numarul {0} aflat pe parcela {1} in {2} este deja alocat!", numar, parcela, numeCimitir));
            }

            _entities.AlocareLoc.Add(new AlocareLoc
                {
                    suprafata = 4,
                    dataExpirare = DateTime.Now,
                    mormantId = mormant.id,
                    cnpDecedat = cnpDecedat
                });

            _entities.SaveChanges();

        }

        public List<DecedatDTO> TotiDecedatii()
        {
            var totiDecedatii = _entities.Persoana.Where(d => d.domiciliuId == null).ToList();
            List<DecedatDTO> totiDecedatiiDTO = new List<DecedatDTO>();

            foreach (var decedat in totiDecedatii)
            {
                var alocare = _entities.AlocareLoc.FirstOrDefault(a => a.cnpDecedat == decedat.cnp);
                if (alocare != null)
                {
                    var mormant = _entities.Mormant.FirstOrDefault(m => m.id == alocare.mormantId);
                    totiDecedatiiDTO.Add(new DecedatDTO
                    {
                        Cnp = decedat.cnp,
                        Nume = decedat.nume,
                        Prenume = decedat.prenume,
                        Cimitir = mormant.Cimitir.nume,
                        Parcela = mormant.parcela,
                        Numar = mormant.numar.ToString()
                    });
                }
                else 
                {
                    totiDecedatiiDTO.Add(new DecedatDTO
                    {
                        Cnp = decedat.cnp,
                        Nume = decedat.nume,
                        Prenume = decedat.prenume,
                        Cimitir = "",
                        Parcela = "",
                        Numar = ""
                    });
                }

                
            }

            return totiDecedatiiDTO;
        }
    }
}
