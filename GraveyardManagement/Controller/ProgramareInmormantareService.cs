using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Global;
using GraveyardManagement.Model.ModelProgramareInmormantare;

namespace GraveyardManagement.Controller
{
    public class ProgramareInmormantareService
    {
        private readonly ModelProgramareInmormantare _model;

        public ProgramareInmormantareService()
        {
            _model = new ModelProgramareInmormantare(GlobalVariables.Entities);
        }

        public ProgramareInmormantareDTO CautaProgramareInmormantareDupaCNP(string cnp)
        {
            return _model.CautaProgramareDupaDecedat(cnp);
        }

        public List<ProgramareInmormantareDTO> CautaProgramariInInterval(DateTime? start, DateTime? end)
        {
            return _model.CautaProgramariInInterval(start, end);
        }

        public void AdaugaProgramareInmormantare(string cnp, string cimitir, string parcela, int numarMormant,
            DateTime? data, string religie)
        {
            _model.AdaugaProgramareInmormantare(cnp, cimitir, parcela, numarMormant, data, religie);
        }

        public void ActualizeazaProgramareInmormantare(int programare, string cimitir, string parcela, int? numarMormant, DateTime? data, string religie)
        {
            _model.ActualizeazaProgramareInmormantare(programare, cimitir, parcela, numarMormant, data, religie);
        }

        public void StergeProgramareInmormantare(int programare)
        {
            _model.StergeProgramareInmormantare(programare);
        }
    }
}
