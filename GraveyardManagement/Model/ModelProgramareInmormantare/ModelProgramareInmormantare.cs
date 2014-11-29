using System;
using System.Collections.Generic;
using System.Linq;
using GraveyardManagement.Global;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model.ModelProgramareInmormantare
{
    public class ModelProgramareInmormantare
    {
        private readonly NecropolisEntities entities;

        public ModelProgramareInmormantare(NecropolisEntities entities)
        {
            this.entities = entities;
        }

        public void AdaugaProgramareInmormantare(string cnpDecedat, string cimitir, string parcela, int numarMormant, DateTime? data, int religieId)
        {
            var queryDecedat =
                from persoana in entities.Persoana
                where persoana.cnp == cnpDecedat
                select persoana;

            if (queryDecedat.ToArray().Length == 0)
            {
                throw new Exception("CNP-ul introdus nu exista in baza de date!");
            }

            var queryExistaDejaProgramare =
                from progr in entities.ProgramareInmormantare
                where progr.cnpDecedat == cnpDecedat
                select progr.cnpDecedat;

            if (queryExistaDejaProgramare.ToArray().Length > 0)
            {
                throw new Exception("Exista deja o programare pentru acel Decedat!");
            }

            var queryMormant =
                from mormant in entities.Mormant
                where mormant.Cimitir.nume == cimitir && mormant.parcela == parcela && mormant.numar == numarMormant
                select mormant;
            var listaMorminte = queryMormant.ToArray();
            if (listaMorminte.Length == 0)
            {
                throw new Exception("Mormantul nu exista!");
            }
            var mormantulAsociatProgramarii = listaMorminte[0];

            var queryReligie =
                from religie in entities.Religie
                where religie.id == religieId
                select religie;

            var listaReligii = queryReligie.ToArray();
            if (listaReligii.Length == 0)
            {
                throw new Exception("Religia nu exista!"); // Nu ar trebui sa fie aruncata, religia se selecteaza dintr-o lista in GUI
            }

            var religiaDecedatului = listaReligii[0];

            var programare = new EntityFramework.ProgramareInmormantare(){ cnpDecedat = cnpDecedat, dataInmormantarii = data, Mormant = mormantulAsociatProgramarii, Religie = religiaDecedatului};

            try
            {
                entities.ProgramareInmormantare.Add(programare);

                var detalii = String.Format("PROGRAMARE-ADAUGARE-{0}-{1},{2},{3}-{4}-{5}", programare.cnpDecedat, programare.Mormant.Cimitir.nume, programare.Mormant.parcela, programare.Mormant.numar, programare.dataInmormantarii, programare.Religie.nume);
                var intrareIstoric = new Istoric() {data = DateTime.Now, numeUtilizator = GlobalVariables.CurrentUser.AccountName, numarDocument = null, detalii = detalii};
                entities.Istoric.Add(intrareIstoric);

                entities.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public ProgramareInmormantareDTO CautaProgramareDupaDecedat(string cnpDecedat)
        {
            var queryCNP =
                from decedat in entities.Persoana
                where decedat.cnp == cnpDecedat
                select decedat;

            if (queryCNP.ToArray().Length == 0)
            {
                throw new Exception("CNP-ul nu exista in baza de date!");
            }

            var queryProgramare =
                from programare in entities.ProgramareInmormantare
                where programare.cnpDecedat == cnpDecedat
                select programare;

            var listaProgramari = queryProgramare.ToArray();
            if (listaProgramari.Length == 0)
            {
                throw new Exception("Decedatul nu are inmormantare programata!");
            }

            var programareGasita = listaProgramari[0];
            var progDTO = new ProgramareInmormantareDTO()
            {
                CnpDecedat = programareGasita.cnpDecedat,   
                NumeDecedat = programareGasita.Persoana.nume, 
                PrenumeDecedat =  programareGasita.Persoana.prenume, 
                Religie = programareGasita.Religie.nume,
                Cimitir = programareGasita.Mormant.Cimitir.nume,
                Parcela = programareGasita.Mormant.parcela,
                NumarMormant = programareGasita.Mormant.numar,
                Data = programareGasita.dataInmormantarii
            };

            return progDTO;
        }
        public List<ProgramareInmormantareDTO> CautaProgramariInInterval(DateTime? t1, DateTime? t2)
        {
            DateTime data1;

            if (t1 == null)
            {
                data1 = DateTime.MinValue;
            }
            else
            {
                data1 = (DateTime)t1;
            }

            DateTime data2;

            if (t2 == null)
            {
                data2 = DateTime.MaxValue;
            }
            else
            {
                data2 = (DateTime)t2;
            }

            var query =
                from programare in entities.ProgramareInmormantare
                where programare.dataInmormantarii >= data1 && programare.dataInmormantarii <= data2
                orderby programare.dataInmormantarii descending 
                select programare;

            return query.ToArray().Select(programare => new ProgramareInmormantareDTO()
            {
                CnpDecedat = programare.cnpDecedat, NumeDecedat = programare.Persoana.nume, PrenumeDecedat = programare.Persoana.prenume, Religie = programare.Religie.nume, Cimitir = programare.Mormant.Cimitir.nume, Parcela = programare.Mormant.parcela, NumarMormant = programare.Mormant.numar, Data = programare.dataInmormantarii
            }).ToList();
        }
        public void ActualizeazaProgramareInmormantare(int id, string cimitirNou, string parcelaNoua, int? numarMormantNou, DateTime? dataNoua, string religieNoua)
        {
            var query =
                from programare in entities.ProgramareInmormantare
                where programare.id == id
                select programare;

            var listaProgramari = query.ToArray();

            if (listaProgramari.Length == 0)
            {
                throw new Exception("Nu exista acea programare"); // Asta n-ar trebui sa fie aruncata niciodata, ca din GUI vine un id valid intotdeauna
            }

            var programareDeActualizat = listaProgramari[0];

            string cimitir = null;
            string parcela = null;
            int? numar = null;
            string data = null;
            string religie = null;

            if (cimitirNou != null)
            {
                    cimitir = cimitirNou;
            }
            else
            {
                cimitir = "null";
            }
            if (parcelaNoua != null)
            {
                parcela = parcelaNoua;
            }
            else
            {
                parcela = "null";
            }
            if (numarMormantNou != null)
            {
                numar = numarMormantNou;
            }
            else
            {
                numar = null;
            }
            if (dataNoua != null)
            {
                programareDeActualizat.dataInmormantarii = dataNoua;
                data = dataNoua.ToString();
            }
            else
            {
                data = "null";
            }
            if (religieNoua != null)
            {
                try
                {
                    programareDeActualizat.religieId = (entities.Religie.First(rel => rel.nume == religieNoua)).id;
                    religie = religieNoua;
                }
                catch (Exception)
                {
                    throw new Exception("Religie invalida!");
                }
            }
            else
            {
                religie = "null";
            }

            // exista mormantul dorit?
            var queryMormant =
                from mormant in entities.Mormant
                where (mormant.Cimitir.nume == cimitir || cimitir == "null") && (mormant.numar == numar || numar == null) && (mormant.parcela == parcela || parcela == "null")
                select mormant;

            if (queryMormant.ToArray().Length == 0)
            {
                throw new Exception("Nu exista Mormantul cerut!");
            }

            var mormantDisponbil = queryMormant.ToArray()[0];

            programareDeActualizat.mormantId = mormantDisponbil.id;
            programareDeActualizat.Mormant = mormantDisponbil;


            string nrMormant = null;

            if (numar == null)
            {
                nrMormant = "null";
            }
            else
            {
                nrMormant = numar.ToString();
            }
            var detalii = String.Format(
                "PROGRAMARE-ACTUALIZARE-{0}-{1},{2},{3}-{4}-{5}",
                programareDeActualizat.cnpDecedat, cimitir, parcela, nrMormant, data, religie);

            var intrareIstoric = new Istoric() { data = DateTime.Now, numeUtilizator = GlobalVariables.CurrentUser.AccountName, numarDocument = null, detalii = detalii };

            entities.Istoric.Add(intrareIstoric);
            
            entities.SaveChanges();
        }
        public void StergeProgramareInmormantare(int id)
        {
            var query =
                from programare in entities.ProgramareInmormantare
                where programare.id == id
                select programare;

            if (query.ToArray().Length == 0)
            {
                throw new Exception("Nu exista programarea");
            }

            var programareDeSters = query.ToArray()[0];
            var detalii = String.Format("PROGRAMARE-STERGERE-{0}", programareDeSters.cnpDecedat);

            try
            {
                entities.ProgramareInmormantare.Remove(programareDeSters);
                var intrareIstoric = new Istoric()
                {
                    data = DateTime.Now,
                    numeUtilizator = GlobalVariables.CurrentUser.AccountName,
                    numarDocument = null,
                    detalii = detalii
                };

                entities.Istoric.Add(intrareIstoric); // logare stergere

                entities.SaveChanges();

            }
            catch (Exception)
            {
                throw new Exception("Eroare la stergerea Programarii!");
            }
        }
    }
}
