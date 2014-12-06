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

        public void AdaugaMormant(int cimitir, String parcela)
        {
            this.model.AdaugaMormant(cimitir, parcela);
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
    }
}
