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
