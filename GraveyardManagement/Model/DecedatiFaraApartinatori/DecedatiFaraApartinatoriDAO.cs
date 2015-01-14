using System.Collections.Generic;
using System.Linq;
using GraveyardManagement.Global;

namespace GraveyardManagement.Model.DecedatiFaraApartinatori
{
    public class DecedatiFaraApartinatoriDAO
    {
        public List<DecedatiFaraApartinatoriDTO> CautaDupaCNPDecedat(string cnp)
        {
            var decedatiFaraApartinatori = new List<DecedatiFaraApartinatoriDTO>();
            var alocareLoc = GlobalVariables.Entities.AlocareLoc;
            var decedat = alocareLoc.First(alocare => alocare.cnpDecedat.Equals(cnp));
            if (decedat.AlocareFaraProprietar != null && decedat.AlocareFaraProprietar.Count > 0)
            {
                decedatiFaraApartinatori.AddRange(decedat.AlocareFaraProprietar.Select(alocare => new DecedatiFaraApartinatoriDTO
                {
                    CNPDecedat = decedat.cnpDecedat, NrAdeverinta = alocare.nrAdeverintaInhumare, NrSolicitare = alocare.solicitareAsistentaSociala
                }));
            }
            return decedatiFaraApartinatori;
        }

        public List<DecedatiFaraApartinatoriDTO> CautaDupaNrAdeverinta(int nrAdeverinta)
        {
            var decedatiFaraApartinatori = new List<DecedatiFaraApartinatoriDTO>();
            var alocareFaraProprietar = GlobalVariables.Entities.AlocareFaraProprietar;
            foreach (var faraProprietar in alocareFaraProprietar)
            {
                if (faraProprietar.nrAdeverintaInhumare == nrAdeverinta)
                {
                    decedatiFaraApartinatori.Add(new DecedatiFaraApartinatoriDTO
                    {
                      CNPDecedat  = faraProprietar.AlocareLoc.cnpDecedat,
                      NrAdeverinta = faraProprietar.nrAdeverintaInhumare,
                      NrSolicitare = faraProprietar.solicitareAsistentaSociala
                    });
                }
            }
            return decedatiFaraApartinatori;
        }

        public List<DecedatiFaraApartinatoriDTO> CautaDupaNrSolicitare(int nrSolicitare)
        {
            var decedatiFaraApartinatori = new List<DecedatiFaraApartinatoriDTO>();
            var alocareFaraProprietar = GlobalVariables.Entities.AlocareFaraProprietar;
            foreach (var faraProprietar in alocareFaraProprietar)
            {
                if (faraProprietar.solicitareAsistentaSociala == nrSolicitare)
                {
                    decedatiFaraApartinatori.Add(new DecedatiFaraApartinatoriDTO
                    {
                        CNPDecedat = faraProprietar.AlocareLoc.cnpDecedat,
                        NrAdeverinta = faraProprietar.nrAdeverintaInhumare,
                        NrSolicitare = faraProprietar.solicitareAsistentaSociala
                    });
                }
            }
            return decedatiFaraApartinatori;
        }
    }
}
