using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model.Utils
{
    class ModelUtils
    {
        private readonly NecropolisEntities entities;

        public ModelUtils(NecropolisEntities entities)
        {
            this.entities = entities;
        }
        
        public List<CimitirDTO> IncarcaToateCimitirele()
        {
            return (from it in entities.Cimitir
                   select new CimitirDTO
                   {
                       Id = it.id,
                       Name = it.nume
                   }).ToList();
        }
    }
}
