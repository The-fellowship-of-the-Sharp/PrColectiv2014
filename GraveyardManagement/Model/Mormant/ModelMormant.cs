using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model.Mormant
{
    class ModelMormant
    {
        private readonly NecropolisEntities entities;

        public ModelMormant(NecropolisEntities entities)
        {
            this.entities = entities;
        }

        private IQueryable<MormantDTO> ToateMorminteCuProprietar()
        {
            var morminte = from alocProprietar in entities.AlocareCuProprietar 
                            join aloc in entities.AlocareLoc
                            on alocProprietar.alocareId equals aloc.id
                            join pers in entities.Persoana
                            on aloc.cnpDecedat equals pers.cnp 
                            join mmt in entities.Mormant
                            on aloc.mormantId equals mmt.id
                            join det in entities.Persoana
                            on alocProprietar.cnpDetinator equals det.cnp
                            select new MormantCuProprietarDTO
                            {
                                Cimitir = mmt.Cimitir.nume,
                                Id = mmt.id,
                                Parcela = mmt.parcela,
                                NumarMormant = (int)mmt.numar,
                                DataExpirare = (DateTime)aloc.dataExpirare,
                                Suprafata = (double)aloc.suprafata,
                                Poza = alocProprietar.Poza,
                                CnpDecedat = aloc.cnpDecedat,
                                NumeDecedat = pers.nume,
                                PrenumeDecedat = pers.prenume,
                                NumeDetinator = det.nume,
                                PrenumeDetinator = det.prenume,
                                NumarChitanta = (int)alocProprietar.nrChitanta,
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

        private IQueryable<MormantDTO> ToateMorminteFaraProrietar()
        {
            var morminte = from alocFara in entities.AlocareFaraProprietar
                           join aloc in entities.AlocareLoc
                           on alocFara.alocareId equals aloc.id
                           join pers in entities.Persoana
                           on aloc.cnpDecedat equals pers.cnp
                           join mmt in entities.Mormant
                           on aloc.mormantId equals mmt.id
                           select new MormantFaraProprietarDTO
                           {
                               Cimitir = mmt.Cimitir.nume,
                               Id = mmt.id,
                               Parcela = mmt.parcela,
                               NumarMormant = (int)mmt.numar,
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

        public MormantDTO CautaMormantDupaDecedat(String cnpDecedat)
        {
            var mormant = from prop in this.ToateMorminteCuProprietar()
                          where prop.CnpDecedat.Equals(cnpDecedat)
                          select prop;
            if (mormant.Count()==0) 
            {
                return mormant.ToArray()[0];
            }
            mormant = from faraProp in this.ToateMorminteFaraProrietar()
                      where faraProp.CnpDecedat.Equals(cnpDecedat)
                      select faraProp;
            if (mormant.Count()==0)
            {
                return mormant.ToArray()[0];
            }
            throw new Exception("Nu s-a gasit niciun decedat cu cnp-ul dat.");
        }

        public List<MormantDTO> CautaMormantDupaLoc(String cimitir, String parcela, int numar)
        {
            var faraProprietar = from fara in this.ToateMorminteFaraProrietar()
                                 where fara.Cimitir.Contains(cimitir) && fara.NumarMormant.Equals(numar) 
                                 select fara;
            var cuProprietar = from cu in this.ToateMorminteFaraProrietar()
                               where cu.Cimitir.Contains(cimitir) && cu.NumarMormant.Equals(numar)
                               select cu;
            return faraProprietar.ToList().Concat(cuProprietar.ToList()).ToList();
        }
        
        public void AdaugaMormant(int cimitir, String parcela)
        {
            var mormantNou = new EntityFramework.Mormant();
            mormantNou.cimitirId = cimitir;
            mormantNou.parcela = parcela;
            entities.Mormant.Add(mormantNou);
            entities.SaveChanges();
        }

        public void ElibereazaMormant(int id)
        {
            var mormant = (from crypt in entities.Mormant
                          where crypt.id.Equals(id)
                          select crypt).ToArray()[0];
            entities.Mormant.Remove(mormant);
            entities.SaveChanges();
        }
    }
}
