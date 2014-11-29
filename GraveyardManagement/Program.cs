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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
