﻿using GraveyardManagement.Model;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Global
{
    public static class GlobalVariables
    {
        public static readonly int ImageWidthInGrid = 75;
        public static readonly int ImageHeightInGrid = 60;

        private static NecropolisEntities entities = new NecropolisEntities();
        private static Model.Utils.ModelUtils utils = new Model.Utils.ModelUtils(entities);

        internal static Model.Utils.ModelUtils Utils
        {
            get { return GlobalVariables.utils; }
            set { GlobalVariables.utils = value; }
        }

        public static User CurrentUser { get; set; }
        public static NecropolisEntities Entities 
        {
            get { return entities; }
        }
    }
}
