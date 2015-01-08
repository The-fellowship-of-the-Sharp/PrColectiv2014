using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GraveyardManagement.Global;
using GraveyardManagement.Model.Cerere;
using GraveyardManagement.Model.ModelCetatean;
using GraveyardManagement.Model.Utils;

namespace GraveyardManagement.Controller
{
    public class CetateanService
    {
        private readonly ModelCetatean _modelCetatean;
        private readonly ModelCerere _modelCerere;
        private readonly ModelUtils _modelUtils;

        public CetateanService()
        {
            _modelCetatean = new ModelCetatean(GlobalVariables.Entities);
            _modelCerere = new ModelCerere(GlobalVariables.Entities);
            _modelUtils = new ModelUtils(GlobalVariables.Entities);
        }

        public void AdaugaCetatean(string cnp, string nume, string prenume, string localitate, string strada, string numar, string alteDetalii)
        {
            ValidareCetatean(cnp, nume, prenume, localitate, strada, numar);

            _modelCetatean.AdaugaCetatean(cnp, nume, prenume, localitate, strada, numar, alteDetalii);
        }

        public void ActualizeazaCetatean(string cnp, string numeNou, string prenumeNou, string localitateNoua, string stradaNoua, string numarNou, string detaliiNoi)
        {
            ValidareCetatean(cnp, numeNou, prenumeNou, localitateNoua, stradaNoua, numarNou);

            _modelCetatean.ActualizeazaCetatean(cnp, numeNou, prenumeNou, localitateNoua, stradaNoua, numarNou, detaliiNoi);
        }

        private void ValidareCetatean(string cnp, string nume, string prenume, string localitate, string strada, string numar)
        {
            if (cnp.Length != 13)
            {
                throw new Exception(string.Format("Codul numeric personal (CNP): {0} este invalid!", cnp));
            }

            if (!Regex.IsMatch(nume, @"^[a-zA-Z ]+$"))
            {
                throw new Exception(string.Format("Numele: {0} este invalid. Numele poate contine doar litere.", nume));
            }

            if (!Regex.IsMatch(prenume, @"^[a-zA-Z ]+$"))
            {
                throw new Exception(string.Format("Prenumele: {0} este invalid. Prenumele poate contine doar litere.", prenume));
            }

            if (!Regex.IsMatch(strada, @"^[a-zA-Z0-9 -]+$"))
            {
                throw new Exception(string.Format("Strada: {0} este invalida. Numele strazii poate contine doar litere si cifre.", strada));
            }

            if (!Regex.IsMatch(numar, @"^[a-zA-Z0-9]+$"))
            {
                throw new Exception(string.Format("Numarul: {0} este invalid. Numarul poate contine doar litere si cifre.", numar));
            }
        }

        public CetateanDto CautaCetatean(string cnp)
        {
            return _modelCetatean.CautaCetatean(cnp);
        }

        public List<CerereDto> CautaCereri(string cnp)
        {
            return _modelCerere.CautaCereri(cnp);
        }

        public List<string> ObtineLocalitatile()
        {
            return _modelUtils.IncarcaToateLocalitatile();
        }
    }
}
