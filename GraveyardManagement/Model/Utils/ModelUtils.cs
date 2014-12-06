using System.Collections.Generic;
using System.Linq;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model.Utils
{
    class ModelUtils
    {
        private readonly NecropolisEntities _entities;

        public ModelUtils(NecropolisEntities entities)
        {
            _entities = entities;
        }
        
        public List<CimitirDTO> IncarcaToateCimitirele()
        {
            return (from it in _entities.Cimitir
                   select new CimitirDTO
                   {
                       Id = it.id,
                       Name = it.nume
                   }).ToList();
        }

        public List<string> IncarcaToateLocalitatile()
        {
            return _entities.Localitate.Select(loc => loc.nume).ToList();
        }
    }
}
