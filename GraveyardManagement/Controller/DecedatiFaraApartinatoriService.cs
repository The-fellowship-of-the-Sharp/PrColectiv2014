using System.Collections.Generic;
using GraveyardManagement.Model.DecedatiFaraApartinatori;

namespace GraveyardManagement.Controller
{
    public class DecedatiFaraApartinatoriService
    {
        private readonly DecedatiFaraApartinatoriDAO _model = new DecedatiFaraApartinatoriDAO();

        public List<DecedatiFaraApartinatoriDTO> CautaDupaCNPDecedat(string cnp)
        {
            return _model.CautaDupaCNPDecedat(cnp);
        }

        public List<DecedatiFaraApartinatoriDTO> CautaDupaNrAdeverinta(int nrAdeverinta)
        {
            return _model.CautaDupaNrAdeverinta(nrAdeverinta);
        }

        public List<DecedatiFaraApartinatoriDTO> CautaDupaNrSolicitare(int nrSolicitare)
        {
            return _model.CautaDupaNrSolicitare(nrSolicitare);
        }
    }
}
