using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GraveyardManagement.Global;
using GraveyardManagement.Model.Cerere;

namespace GraveyardManagement.Controller
{
    public class CerereService
    {
        private readonly ModelCerere _modelCerere;

        public CerereService()
        {
            _modelCerere = new ModelCerere(GlobalVariables.Entities);
        }

        public void AdaugaCerere(string cnpCetatean, int nrInfocet, DateTime dataInregistrare)
        {
            ValidareCerere(cnpCetatean, dataInregistrare);

            _modelCerere.AdaugaCerere(cnpCetatean, nrInfocet, dataInregistrare);
        }

        public CerereDto CautaCerere(int nrInfocet, DateTime dataInregistrare)
        {
            return _modelCerere.CautaCerere(nrInfocet, dataInregistrare);
        }

        public CerereDto CautaCerere(int numar)
        {
            return _modelCerere.CautaCerere(numar);
        }

        public void ActualizeazaCerere(int numar, string stadiuNou)
        {
            _modelCerere.ActualizeazaCerere(numar, stadiuNou);
        }

        public void StergeCerere(int numar)
        {
            _modelCerere.StergeCerere(numar);
        }

        public List<string> ObtineToateStadiile()
        {
            return _modelCerere.ObtineToateStadiile();
        }

        public void ValidareCerere(string cnp, DateTime dataInregistrare)
        {
            if (cnp.Length != 13)
            {
                throw new Exception(string.Format("Codul numeric personal (CNP): {0} este invalid!", cnp));
            }

            if (!Regex.IsMatch(cnp, @"^[0-9]+$"))
            {
                throw new Exception(string.Format("Codul numeric personal (CNP): {0} contine alte caractere decat cifre!", cnp));
            }

            if (dataInregistrare > DateTime.Now)
            {
                throw new Exception(string.Format("Data de {0} nu este valida. Va rugam introduceti o data din trecut!", dataInregistrare));
            }
        }
    }
}
