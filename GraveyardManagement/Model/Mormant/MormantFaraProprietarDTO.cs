using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardManagement.Model.Mormant
{
    class MormantFaraProprietarDTO : MormantDTO
    {
        private int numarSolicitareAsistentaSociala;

        public int NumarSolicitareAsistentaSociala
        {
            get { return numarSolicitareAsistentaSociala; }
            set { numarSolicitareAsistentaSociala = value; }
        }
        private int numarAdeverintaInhumare;

        public int NumarAdeverintaInhumare
        {
            get { return numarAdeverintaInhumare; }
            set { numarAdeverintaInhumare = value; }
        }

        public override string Tip()
        {
            return "fara";
        }
    }
}
