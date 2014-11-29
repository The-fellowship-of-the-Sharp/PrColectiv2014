using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardManagement.Model.Mormant
{
    class MormantDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String cimitir;

        public String Cimitir
        {
            get { return cimitir; }
            set { cimitir = value; }
        }
        private GraveyardManagement.Model.EntityFramework.Poza poza;

        public GraveyardManagement.Model.EntityFramework.Poza Poza
        {
            get { return poza; }
            set { poza = value; }
        }
        private String parcela;

        public String Parcela
        {
            get { return parcela; }
            set { parcela = value; }
        }
        private int numarMormant;

        public int NumarMormant
        {
            get { return numarMormant; }
            set { numarMormant = value; }
        }
        private DateTime dataExpirare;

        public DateTime DataExpirare
        {
            get { return dataExpirare; }
            set { dataExpirare = value; }
        }
        private Double suprafata;

        public Double Suprafata
        {
            get { return suprafata; }
            set { suprafata = value; }
        }
        private String cnpDecedat;

        public String CnpDecedat
        {
            get { return cnpDecedat; }
            set { cnpDecedat = value; }
        }
        private String numeDecedat;

        public String NumeDecedat
        {
            get { return numeDecedat; }
            set { numeDecedat = value; }
        }
        private String prenumeDecedat;

        public String PrenumeDecedat
        {
            get { return prenumeDecedat; }
            set { prenumeDecedat = value; }
        }

        public virtual String Tip() 
        {
            return "General";
        }
    }
}
