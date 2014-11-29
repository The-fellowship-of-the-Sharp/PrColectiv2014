using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardManagement.Model.Mormant
{
    class MormantCuProprietarDTO : MormantDTO
    {
        private String numeDetinator;

        public String NumeDetinator
        {
            get { return numeDetinator; }
            set { numeDetinator = value; }
        }
        private String prenumeDetinator;

        public String PrenumeDetinator
        {
            get { return prenumeDetinator; }
            set { prenumeDetinator = value; }
        }

        private Domiciliu domiciliu;

        public Domiciliu Domiciliu
        {
            get { return domiciliu; }
            set { domiciliu = value; }
        }

        private int numarContract;

        public int NumarContract
        {
            get { return numarContract; }
            set { numarContract = value; }
        }

        private DateTime dataEliberareContract;

        public DateTime DataEliberareContract
        {
            get { return dataEliberareContract; }
            set { dataEliberareContract = value; }
        }

        private int numarChitanta;

        public int NumarChitanta
        {
            get { return numarChitanta; }
            set { numarChitanta = value; }
        }

        public override string Tip()
        {
            return "cu";
        }
    }
}
