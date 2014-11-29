using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardManagement.Model.Mormant
{
    public class Domiciliu
    {
        private String localitate;

        public String Localitate
        {
            get { return localitate; }
            set { localitate = value; }
        }
        private String strada;

        public String Strada
        {
            get { return strada; }
            set { strada = value; }
        }
        private String numar;

        public String Numar
        {
            get { return numar; }
            set { numar = value; }
        }
        private String alteInformatii;

        public String AlteInformatii
        {
            get { return alteInformatii; }
            set { alteInformatii = value; }
        }
    }
}
