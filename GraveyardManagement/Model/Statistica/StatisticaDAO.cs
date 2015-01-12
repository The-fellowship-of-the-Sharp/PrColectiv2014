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
            var list = new List<StatisticaDTO>();

            foreach (var alocareLoc in database.AlocareLoc)
            {
                var alocareCuProprietar = alocareLoc.AlocareCuProprietar;
                var mormant = alocareLoc.Mormant;
                var cimitir = mormant.Cimitir;
                if (alocareCuProprietar != null && alocareCuProprietar.Count > 0)
                {
                    foreach (var cuProprietar in alocareCuProprietar)
                    {
                        var poza = cuProprietar.Poza;
                        var persoana = cuProprietar.Persoana;
                        list.Add(new StatisticaDTO
                        {
                            Cimitir = cimitir != null ? cimitir.nume : "N/A",
                            CNPDecedat = alocareLoc.cnpDecedat,
                            DataExpirare = alocareLoc.dataExpirare,
                            NumarMormant = mormant != null ? mormant.numar : null,
                            Parcela = mormant != null ? mormant.parcela : "N/A",
                            Suprafata = alocareLoc.suprafata,
                            Poza = poza != null ? ConvertByteArrayToImage(poza.continut) : null,
                            Nume = persoana != null ? persoana.nume : "N/A",
                            Prenume = persoana != null ? persoana.prenume : "N/A",
                            DataEmitere = cuProprietar.dataEmitereChitanta
                        });
                    }
                }
                else
                {
                    list.Add(new StatisticaDTO
                    {
                        Cimitir = cimitir != null ? cimitir.nume : "N/A",
                        CNPDecedat = alocareLoc.cnpDecedat,
                        DataExpirare = alocareLoc.dataExpirare,
                        NumarMormant = mormant != null ? mormant.numar : null,
                        Parcela = mormant != null ? mormant.parcela : "N/A",
                        Suprafata = alocareLoc.suprafata,
                        Nume = "N/A",
                        Prenume = "N/A"
                    });
                }
            }
            return list;
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
