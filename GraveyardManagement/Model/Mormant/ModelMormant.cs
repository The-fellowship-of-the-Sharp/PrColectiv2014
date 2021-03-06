﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model.Mormant
{
    public class ModelMormant
    {
        private readonly NecropolisEntities entities;

        public ModelMormant(NecropolisEntities entities)
        {
            this.entities = entities;
        }

        private IQueryable<MormantDTO> ToateMorminteCuProprietar()
        {
            var morminte = from mmt in entities.Mormant
                            join aloc in entities.AlocareLoc
                            on mmt.id equals aloc.mormantId
                            join alocProprietar in entities.AlocareCuProprietar 
                            on aloc.id equals alocProprietar.alocareId
                            join pers in entities.Persoana
                            on aloc.cnpDecedat equals pers.cnp 
                            join contract in entities.ContractConcesiune
                            on aloc.id equals contract.alocareId
                            from det in contract.Persoana
                            select new MormantCuProprietarDTO
                            {
                                Cimitir = mmt.Cimitir.nume,
                                Id = mmt.id,
                                Parcela = mmt.parcela,
                                NumarMormant = (int)mmt.numar,
                                EsteMonument = mmt.EsteMonument.HasValue ? (mmt.EsteMonument.Value ? "Da" : "Nu") : "Nu",
                                DataExpirare = (DateTime)aloc.dataExpirare,
                                Suprafata = (double)aloc.suprafata,
                                Poza = alocProprietar.Poza,
                                CnpDecedat = aloc.cnpDecedat,
                                NumeDecedat = pers.nume,
                                PrenumeDecedat = pers.prenume,
                                NumeDetinator = det.nume,
                                PrenumeDetinator = det.prenume,
                                NumarChitanta = (int)alocProprietar.nrChitanta,
                                NumarContract = (int)contract.numar,
                                DataEliberareContract = (DateTime)contract.dataEliberare,
                                Domiciliu = new Domiciliu
                                {
                                    Localitate = det.Domiciliu.Strada.Localitate.nume,
                                    Strada = det.Domiciliu.Strada.nume,
                                    Numar = det.Domiciliu.numar,
                                    AlteInformatii = det.Domiciliu.alteInformatii
                                }
                            };
            return morminte;
        }

        private IQueryable<MormantDTO> ToateMorminteleInclomplete()
        {
            var morminte = from mmt in entities.Mormant
                           where mmt.AlocareLoc.Count().Equals(0) || mmt.ProgramareInmormantare.Count().Equals(0)
                           select new MormantFaraProprietarDTO
                           {
                               Cimitir = mmt.Cimitir.nume,
                               Id = mmt.id,
                               Parcela = mmt.parcela,
                               NumarMormant = (mmt.numar == null ? 0 : (int)mmt.numar),
                               EsteMonument = mmt.EsteMonument.HasValue ? (mmt.EsteMonument.Value ? "Da" : "Nu") : "Nu"
                           };
            return morminte;
        }

        private IQueryable<MormantDTO> ToateMorminteFaraProrietar()
        {
            var morminte = from mmt in entities.Mormant
                           join aloc in entities.AlocareLoc
                           on mmt.id equals aloc.mormantId
                           join alocFara in entities.AlocareFaraProprietar
                           on aloc.id equals alocFara.alocareId
                           join pers in entities.Persoana
                           on aloc.cnpDecedat equals pers.cnp
                           select new MormantFaraProprietarDTO
                           {
                               Cimitir = mmt.Cimitir.nume,
                               Id = mmt.id,
                               Parcela = mmt.parcela,
                               NumarMormant = (int)mmt.numar,
                               EsteMonument = mmt.EsteMonument.HasValue ? (mmt.EsteMonument.Value ? "Da" : "Nu") : "Nu",
                               DataExpirare = (DateTime)aloc.dataExpirare,
                               Suprafata = (double)aloc.suprafata,
                               CnpDecedat = aloc.cnpDecedat,
                               NumeDecedat = pers.nume,
                               PrenumeDecedat = pers.prenume,
                               NumarSolicitareAsistentaSociala = (int)alocFara.solicitareAsistentaSociala,
                               NumarAdeverintaInhumare = (int)alocFara.nrAdeverintaInhumare
                           };
            return morminte;
        }

        public List<MormantDTO> CautaMormantDupaDecedat(String cnpDecedat)
        {
            var mormantCuProp = from prop in this.ToateMorminteCuProprietar()
                          where prop.CnpDecedat.Equals(cnpDecedat)
                          select prop;
            var mormantFaraProp = from faraProp in this.ToateMorminteFaraProrietar()
                      where faraProp.CnpDecedat.Equals(cnpDecedat)
                      select faraProp;
            if (mormantCuProp.Count() == 0 && mormantFaraProp.Count() == 0)
            {
                throw new Exception("Nu s-a gasit niciun decedat cu cnp-ul dat.");    
            }
            return mormantCuProp.ToList().Concat(mormantFaraProp.ToList()).ToList();
        }

        public List<MormantDTO> CautaMormantDupaLoc(String cimitir, String parcela, int ? numar, Boolean ? monument)
        {
            IQueryable<MormantDTO> faraProprietar;
            IQueryable<MormantDTO> cuProprietar;
            IQueryable<MormantDTO> neatribuit;

            var esteMonument = "";
            if (monument == true)
                esteMonument = "Da";
            else
                esteMonument = "Nu";
            
            faraProprietar = this.ToateMorminteFaraProrietar();
            cuProprietar = this.ToateMorminteCuProprietar();
            neatribuit = this.ToateMorminteleInclomplete();
            if (numar != null)
            {
                faraProprietar = from fara in faraProprietar
                                 where fara.NumarMormant.Equals((int)numar)
                                 select fara;
                cuProprietar = from cu in cuProprietar
                               where cu.NumarMormant.Equals((int)numar)
                               select cu;
                neatribuit = from neattr in neatribuit
                             where neattr.NumarMormant.Equals((int)numar)
                             select neattr;
            }
            if (monument != null)
            {
                faraProprietar = from fara in faraProprietar
                                 where fara.EsteMonument.Equals(esteMonument)
                                 select fara;
                cuProprietar = from cu in cuProprietar
                               where cu.EsteMonument.Equals(esteMonument)
                               select cu;
                neatribuit = from neattr in neatribuit
                             where neattr.EsteMonument.Equals(esteMonument)
                             select neattr;
            }

            faraProprietar = from fara in faraProprietar
                             where fara.Cimitir.Contains(cimitir) && fara.Parcela.Contains(parcela)
                             select fara;
            cuProprietar = from cu in cuProprietar
                           where cu.Cimitir.Contains(cimitir) && cu.Parcela.Contains(parcela)
                           select cu;
            neatribuit = from neattr in neatribuit
                         where neattr.Cimitir.Contains(cimitir) && neattr.Parcela.Contains(parcela)
                         select neattr;

            var result = faraProprietar.ToList().Concat(cuProprietar.ToList()).ToList();
            result = result.Concat(neatribuit.ToList()).ToList();

            return result;
        }
        
        public void AdaugaMormant(int cimitir, String parcela, int numar, bool esteMormant)
        {
            var mormantNou = new EntityFramework.Mormant();
            mormantNou.cimitirId = cimitir;
            mormantNou.parcela = parcela;
            mormantNou.numar = numar;
            mormantNou.EsteMonument = esteMormant;
            entities.Mormant.Add(mormantNou);
            var cimitirPentruLog = (from cim in entities.Cimitir
                          where cim.id.Equals(cimitir) select cim.nume).First();
            var istoricNou = new EntityFramework.Istoric();
            istoricNou.numeUtilizator = Global.GlobalVariables.CurrentUser.AccountName;
            istoricNou.data = DateTime.Now;
            var detalii = String.Format("MORMANT;ADAUGARE;{0};{1};{2}", cimitirPentruLog, mormantNou.parcela, mormantNou.numar);
            if (esteMormant)
            {
                detalii = string.Concat(detalii, ";MONUMENT");
            }

            istoricNou.detalii = detalii;

            entities.Istoric.Add(istoricNou);
            entities.SaveChanges();
        }

        public void ElibereazaMormant(int id)
        {
            var mormant = (from crypt in entities.Mormant
                          where crypt.id.Equals(id)
                          select crypt).First();
            var decedatPentruLog = (from mmt in entities.Mormant
                            join aloc in entities.AlocareLoc
                            on mmt.id equals aloc.mormantId
                            select aloc.cnpDecedat).First();
            var istoricNou = new EntityFramework.Istoric();
            istoricNou.numeUtilizator = Global.GlobalVariables.CurrentUser.AccountName;
            istoricNou.data = DateTime.Now;
            var detalii = String.Format("MORMANT-ELIBERARE-{0}-{1},{2},{3}", decedatPentruLog, 
                mormant.Cimitir.nume, mormant.parcela, mormant.numar);
            entities.Istoric.Add(istoricNou);
            foreach (var it in mormant.AlocareLoc)
            {
                it.mormantId = null;
            }
            entities.SaveChanges();
        }
    }
}
