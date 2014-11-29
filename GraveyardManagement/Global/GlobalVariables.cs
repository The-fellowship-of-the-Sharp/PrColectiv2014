using GraveyardManagement.Model;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Global
{
    public static class GlobalVariables
    {
        private static NecropolisEntities entities = new NecropolisEntities();

        public static User CurrentUser { get; set; }
        public static NecropolisEntities Entities 
        {
            get { return entities; }
        }
    }
}
