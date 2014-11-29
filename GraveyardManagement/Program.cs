using System;
using System.Windows.Forms;
using GraveyardManagement.Global;
using GraveyardManagement.Model.ModelProgramareInmormantare;
using GraveyardManagement.View.Login;

namespace GraveyardManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mpi = new ModelProgramareInmormantare(GlobalVariables.Entities);
            GlobalVariables.CurrentUser = new Model.User() { AccountName = "inspector007" };
            
            //mpi.AdaugaProgramareInmormantare("1930129124931", "Central", "A", 3, DateTime.Now, 2);
            mpi.ActualizeazaProgramareInmormantare(2, null, null, null, null, null);
            //mpi.StergeProgramareInmormantare(1);


            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());*/
        }
    }
}
