using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using GraveyardManagement.Model;

namespace GraveyardManagement.Controller
{
    public interface ILoginService
    {
        User Login(string name, string password);
    }
}
