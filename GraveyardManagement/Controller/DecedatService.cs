using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Global;
using GraveyardManagement.Model.ModelDecedat;
using System.Text.RegularExpressions;

namespace GraveyardManagement.Controller
{
    public class DecedatService
    {
        private readonly ModelDecedat _modelDecedat;

        public DecedatService()
        {
            _modelDecedat = new ModelDecedat(GlobalVariables.Entities);
        }

        public void AdaugaDecedat(string cnp, string nume, string prenume)
        {
            ValidareDecedat(cnp, nume, prenume);

            _modelDecedat.AdaugaDecedat(cnp, nume, prenume);
        }

        public void AtribuieMormant(string cnpDecedat, int cimitirId, string parcela, int numar)
        {
            _modelDecedat.AtribuieMormant(cnpDecedat,cimitirId,parcela,numar);
        }

        private void ValidareDecedat(string cnp, string nume, string prenume)
        {
            if (cnp.Length != 13)
            {
                throw new Exception(string.Format("Codul numeric personal (CNP): {0} este invalid!", cnp));
            }

            if (!Regex.IsMatch(nume, @"^[a-zA-Z]+$"))
            {
                throw new Exception(string.Format("Numele: {0} este invalid. Numele poate contine doar litere.", nume));
            }

            if (!Regex.IsMatch(prenume, @"^[a-zA-Z]+$"))
            {
                throw new Exception(string.Format("Prenumele: {0} este invalid. Prenumele poate contine doar litere.", prenume));
            }
        }

        public DecedatDTO CautaDecedat(string cnp)
        {
            return _modelDecedat.CautaDecedat(cnp);
        }

        public List<DecedatDTO> TotiDecedatii()
        {
            return _modelDecedat.TotiDecedatii();
        }
    }
}
