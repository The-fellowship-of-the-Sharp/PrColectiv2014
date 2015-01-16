using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using GraveyardManagement.Model.Mormant;
using GraveyardManagement.Utils.Exceptions;

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
                throw new ValidationException("CNP-ul poate contine numai cifre intre 0 si 9.");
            }
            return this.model.CautaMormantDupaDecedat(cnp);
        }

        public List<MormantDTO> CautaMormantDupaLoc(String cimitir, String parcela, String numar, Boolean monument) 
        {
            try
            {
                if (numar != "" && numar !=null)
                {
                    int validNumber = int.Parse(numar);
                    return this.model.CautaMormantDupaLoc(cimitir, parcela, validNumber, monument);
                }
                else
                {
                    if (cimitir != "" || parcela != "")
                    {
                        return this.model.CautaMormantDupaLoc(cimitir, parcela, null, monument);
                    }
                    else
                    {
                        return this.model.CautaMormantDupaLoc(cimitir, parcela, null, null);
                    }

                }
            }
            catch
            {
                throw new ValidationException("Numarul nu poate contine alte caractere in afara de cifre.");
            }
            
        }

        public void ElibereazaMormant(int id)
        {
            
            this.model.ElibereazaMormant(id);
        }

        private void VerificareDuplicat(string cimitir, string parcela, int numar)
        {
            var morminte = CautaMormantDupaLoc(cimitir, parcela, numar.ToString(), true);
            var morminte2 = CautaMormantDupaLoc(cimitir, parcela, numar.ToString(), false);

            if (morminte.Count > 0 || morminte2.Count > 0)
            {
                throw new ValidationException(string.Format("Exista deja un mormant in cimitirul {0} pe parcela {1} cu numarul {2}!", 
                    cimitir, parcela, numar));
            }
        }
    }
}
