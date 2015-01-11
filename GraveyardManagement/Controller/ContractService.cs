using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Global;
using GraveyardManagement.Model.Contract;

namespace GraveyardManagement.Controller
{
    class ContractService
    {
        private readonly ModelContract _modelContract;

        public ContractService()
        {
            _modelContract = new ModelContract(GlobalVariables.Entities);
        }

        public List<ContractDto> CautaContracte(string cnp)
        {
            return _modelContract.CautaContracte(cnp);
        }

        public ContractDto CautaContract(int id)
        {
           return _modelContract.CautaContract(id);
        }

        public void StergeContract(int nr)
        {
            _modelContract.StergeContract(nr);
        }

        public int findLocAlocat(string cnpDecedat)
        {
            return _modelContract.findLocAlocat(cnpDecedat);
        }

        public void AddPropContract(int nrContract, DateTime CdateEmitere, DateTime CdateExpirare, int idloc, string cnp1, string cnp2, int nrChitanta, DateTime Chitantadate)
        {
            _modelContract.AdaugaPropContract(nrContract, CdateEmitere, CdateExpirare, idloc);
            _modelContract.AdaugaDetinator(nrContract, cnp1);
            if (cnp2 != null)
            {
                _modelContract.AdaugaDetinator(nrContract, cnp2);
            }
            _modelContract.AdaugareAlocareProprietar(idloc, nrChitanta, Chitantadate);

        }

        public void AddFaraProcContract(int nrContract, DateTime CdateEmitere, DateTime CdateExpirare, int idloc, int solicitate, int adeverinta)
        {
            _modelContract.AdaugaPropContract(nrContract, CdateEmitere, CdateExpirare, idloc);
            _modelContract.AdaugaAlocareFaraProprietar(idloc, solicitate, adeverinta);
        }

        public void ActualizeazaCerere(int nrContract, int nrChitanta, DateTime ContractDate, DateTime ChitantaDate)
        {

        }
    }


}
