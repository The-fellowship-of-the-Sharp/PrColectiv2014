using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using GraveyardManagement.Model.Mormant;

namespace GraveyardManagement.Controller
{
    public class ControllerMormant
    {
        private readonly ModelMormant model;
        public ControllerMormant()
        {
            model = new ModelMormant(Global.GlobalVariables.Entities);
        }

        public void AdaugaMormant(int cimitirId, string numeCimitir, String parcela, int numar, bool esteMonument)
        {
            VerificareDuplicat(numeCimitir, parcela, numar);

            this.model.AdaugaMormant(cimitirId, parcela, numar, esteMonument);
        }

        public List<MormantDTO> CautaMormantDupaDecedat(String cnp)
        {
            Regex nonDigit = new Regex(@"[^\d]");
            if (nonDigit.IsMatch(cnp)) {
                throw new Exception("CNP-ul poate contine numai cifre intre 0 si 9.");
            }
            return this.model.CautaMormantDupaDecedat(cnp);
        }

        public List<MormantDTO> CautaMormantDupaLoc(String cimitir, String parcela, String numar) 
        {
            try
            {
                int validNumber = int.Parse(numar);
                return this.model.CautaMormantDupaLoc(cimitir, parcela, validNumber);
            }
            catch
            {
                throw new Exception("Numarul nu poate contine alte caractere in afara de cifre.");
            }
            
        }

        public void ElibereazaMormant(String id)
        {
            int validId = int.Parse(id);
            this.model.ElibereazaMormant(validId);
        }

        private void VerificareDuplicat(string cimitir, string parcela, int numar)
        {
            var morminte = CautaMormantDupaLoc(cimitir, parcela, numar.ToString());

            if (morminte.Count > 0)
            {
                throw new Exception(string.Format("Exista deja un mormant in cimitirul {0} pe parcela {1} cu numarul {2}!", 
                    cimitir, parcela, numar));
            }
        }
    }
}
