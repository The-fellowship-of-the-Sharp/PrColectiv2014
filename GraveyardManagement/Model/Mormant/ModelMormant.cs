using System;
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
                join aloccupropr in entities.AlocareCuProprietar
                    on aloc.id equals aloccupropr.alocareId
                join contr in entities.ContractConcesiune
                    on aloc.id equals contr.alocareId
                join decedat in entities.Persoana
                on aloc.cnpDecedat equals decedat.cnp
                select new MormantCuProprietarDTO
                {
                    Cimitir = mmt.Cimitir.nume,
                    Id = mmt.id,
                    Parcela = mmt.parcela,
                    NumarMormant = (int) mmt.numar,
                    EsteMonument = mmt.EsteMonument.HasValue ? (mmt.EsteMonument.Value ? "Da" : "Nu") : "Nu",
                    DataExpirare = (DateTime) aloc.dataExpirare,
                    Suprafata = (double) aloc.suprafata,
                    Poza = aloccupropr.Poza,
                    CnpDecedat = aloc.cnpDecedat,
                    NumeDecedat = decedat.nume,
                    PrenumeDecedat = decedat.prenume,
                    /*NumeDetinator = det.nume,
                    PrenumeDetinator = det.prenume,*/
                    NumarChitanta = (int) aloccupropr.nrChitanta,
                    NumarContract = (int) contr.numar,
                    DataEliberareContract = (DateTime) contr.dataEliberare,
                    /* Domiciliu = new Domiciliu
                                {
                                    Localitate = det.Domiciliu.Strada.Localitate.nume,
                                    Strada = det.Domiciliu.Strada.nume,
                                    Numar = det.Domiciliu.numar,
                                    AlteInformatii = det.Domiciliu.alteInformatii
                                }*/
                };
            /*IQueryable<MormantDTO> morminte = from mmt in entities.Mormant
                            join aloc in entities.AlocareLoc
                            on mmt.id equals aloc.mormantId
                            join alocProprietar in entities.AlocareCuProprietar 
                            on aloc.id equals alocProprietar.alocareId
                            join pers in entities.Persoana
                            on aloc.cnpDecedat equals pers.cnp 
                            join det in entities.Persoana
                            on alocProprietar.cnpDetinator equals det.cnp
                            join contract in entities.ContractConcesiune
                            on aloc.id equals contract.alocareId
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
                            };*/
            var m = morminte.ToArray();
            return morminte;
        }

        private IQueryable<MormantDTO> ToateMorminteleIncomplete()
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
            var mormantIncomplet = from incomplet in ToateMorminteleIncomplete()
                where incomplet.CnpDecedat.Equals(cnpDecedat)
                select incomplet;
            if (mormantCuProp.Count() == 0 && mormantFaraProp.Count() == 0 && mormantIncomplet.Count() == 0)
            {
                throw new Exception("Nu s-a gasit niciun decedat cu cnp-ul dat.");    
            }
            return mormantCuProp.ToList().Concat(mormantFaraProp.ToList()).ToList().Concat(mormantIncomplet.ToList()).ToList();
        }

        public List<MormantDTO> CautaMormantDupaLoc(String cimitir, String parcela, int numar)
        {
            IQueryable<MormantDTO> faraProprietar;
            IQueryable<MormantDTO> cuProprietar;
            IQueryable<MormantDTO> neatribuit;
            if (numar != 0)
            {
                faraProprietar = from fara in this.ToateMorminteFaraProrietar()
                                    where fara.Cimitir.Contains(cimitir) && fara.Parcela.Contains(parcela)
                                    && fara.NumarMormant.Equals(numar)    
                                    select fara;
                cuProprietar = from cu in this.ToateMorminteFaraProrietar()
                                   where cu.Cimitir.Contains(cimitir) && cu.Parcela.Contains(parcela)
                                   && cu.NumarMormant.Equals(numar)
                                   select cu;
                neatribuit = from neattr in this.ToateMorminteleIncomplete()
                             where neattr.Cimitir.Contains(cimitir) && neattr.Parcela.Contains(parcela)
                             && neattr.NumarMormant.Equals(numar)
                             select neattr;
            }
            else
            {
                faraProprietar = from fara in this.ToateMorminteFaraProrietar()
                                     where fara.Cimitir.Contains(cimitir) && fara.Parcela.Contains(parcela)
                                     select fara;
                cuProprietar = from cu in this.ToateMorminteFaraProrietar()
                                   where cu.Cimitir.Contains(cimitir) && cu.Parcela.Contains(parcela)
                                   select cu;
                neatribuit = from neattr in this.ToateMorminteleIncomplete()
                             where neattr.Cimitir.Contains(cimitir) && neattr.Parcela.Contains(parcela)
                                 select neattr;
            }
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
            istoricNou.numeUtilizator = Global.GlobalVariables.CurrentUser.Name;
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
            istoricNou.numeUtilizator = Global.GlobalVariables.CurrentUser.Name;
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
