using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Global;
using GraveyardManagement.Model.Contract;
using GraveyardManagement.Model.ModelCetatean;

namespace GraveyardManagement.Controller
{
    class ContractService
    {
        private readonly ModelContract _modelContract;
        private readonly ModelCetatean _modelCetatean;  

        public ContractService()
        {
            _modelContract = new ModelContract(GlobalVariables.Entities);
            _modelCetatean = new ModelCetatean(GlobalVariables.Entities);
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
            if( _modelContract.ChechExistaContract(idloc))
            {
                throw new Exception("Decedatul deja are un contract!");
            }
            if (_modelCetatean.CautaCetatean(cnp1) == null)
            {
                throw new Exception("Proprietarul cu CNP:" + cnp1 + " nu exista");
            }
            if (cnp2.Length > 0)
            {
                if (_modelCetatean.CautaCetatean(cnp2) == null)
                {
                    throw new Exception("Proprietarul cu CNP:" + cnp2 + " nu exista");
                }
            }

            _modelContract.AdaugaPropContract(nrContract, CdateEmitere, CdateExpirare, idloc);
            _modelContract.AdaugaDetinator(nrContract, cnp1);
            if (cnp2.Length > 0)
            {

                _modelContract.AdaugaDetinator(nrContract, cnp2);
            }
            _modelContract.AdaugareAlocareProprietar(idloc, nrChitanta, Chitantadate);

        }

        public List<ContractDto> ToateContractele()
        {
           return  _modelContract.GetAllContracte();
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
