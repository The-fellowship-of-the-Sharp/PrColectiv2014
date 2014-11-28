using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Model;

namespace GraveyardManagement.Controller
{
    public class LoginMock : ILoginService
    {
        public User Login(string name, string password)
        {
            return new User() { AccountName = "Inspector007" };
        }
    }
}
