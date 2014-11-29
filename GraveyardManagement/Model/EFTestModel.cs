using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model
{
    public class EFTestModel
    {
        private readonly NecropolisEntities entities;

        public EFTestModel()
        {
            entities = new NecropolisEntities();
        }
        public NecropolisEntities Entities
        {
            get { return entities; }
        }
    }
}
