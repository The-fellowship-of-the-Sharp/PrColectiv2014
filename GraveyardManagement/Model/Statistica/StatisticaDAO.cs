using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using GraveyardManagement.Global;

namespace GraveyardManagement.Model.Statistica
{
    public class StatisticaDAO
    {
        public List<StatisticaDTO> GetDataFromDB()
        {
            var database = GlobalVariables.Entities;
            
            return (from al in database.AlocareLoc
                    join acp in database.AlocareCuProprietar on al.id equals acp.alocareId into acps
                    from ap in acps.DefaultIfEmpty()
                    join p in database.Poza on ap.pozaId equals p.id into poze
                    from poz in poze.DefaultIfEmpty()
                    join persoana in database.Persoana on ap.cnpDetinator equals persoana.cnp into persoane
                    from pers in persoane.DefaultIfEmpty()
                    join m in database.Mormant on al.mormantId equals m.id into morminte
                    from mormant in morminte.DefaultIfEmpty()
                    join c in database.Cimitir on mormant.cimitirId equals c.id into cimitire
                    from cimitir in cimitire.DefaultIfEmpty()

                    select new
                    {
                        Cimitir = cimitir != null ? cimitir.nume : "N/A",
                        CNPDecedat = al.cnpDecedat ?? "N/A",
                        DataExpirare = al.dataExpirare,
                        NumarMormant = mormant != null ? mormant.numar : null,
                        Parcela = mormant != null ? mormant.parcela : "N/A",
                        Suprafata = al.suprafata,
                        Poza = (poz != null) ? poz.continut : null,
                        Nume = ap != null ? pers.nume : "N/A",
                        Prenume = ap != null ? pers.prenume : "N/A",
                        DataEmiterii = ap != null ? ap.dataEmitereChitanta : null
                    }).ToList().Select(element => new StatisticaDTO
                    {
                        Cimitir = element.Cimitir,
                        CNPDecedat = element.CNPDecedat,
                        DataExpirare = element.DataExpirare,
                        NumarMormant = element.NumarMormant,
                        Parcela = element.Parcela,
                        Suprafata = element.Suprafata,
                        Poza = ConvertByteArrayToImage(element.Poza),
                        Nume = element.Nume,
                        Prenume = element.Prenume,
                        DataEmitere = element.DataEmiterii
                    }).ToList();
        } 

        public List<StatisticaDTO> SelectMorminteCareExpiraInAnulCurrent()
        {
            var currentYear = DateTime.Now.Year;
            return GetDataFromDB().Where(element => element.DataExpirare != null && element.DataExpirare.Value.Year == currentYear).ToList();
        }

        public List<StatisticaDTO> SelectMorminteExpiratePeAni()
        {
            return GetDataFromDB().OrderByDescending(element => element.DataExpirare).ToList();
        }

        public List<StatisticaDTO> SelectMormintePlatiteInAnulCurrent()
        {
            var currentYear = DateTime.Now.Year;
            return
                GetDataFromDB()
                    .Where(element => element.DataEmitere != null && element.DataEmitere.Value.Year == currentYear)
                    .ToList();
        } 

        private static Image ConvertByteArrayToImage(byte[] bytes)
        {
            if (bytes == null) return null;
            var ms = new MemoryStream(bytes);
            var image = Image.FromStream(ms);
            var newImage = new Bitmap(GlobalVariables.ImageWidthInGrid, GlobalVariables.ImageHeightInGrid);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, GlobalVariables.ImageWidthInGrid, GlobalVariables.ImageHeightInGrid);
            return newImage;
        }
    }
}
