using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GraveyardManagement.Model;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Controller
{
    public class LoginService : ILoginService
    {
        private readonly NecropolisEntities entities;

        public LoginService(NecropolisEntities entities)
        {
            this.entities = entities;
        }

        public Model.User Login(string name, string password)
        {
            var passBytes = Encoding.UTF8.GetBytes(password);
            var shaAlgo = SHA256Managed.Create();
            
            var hashedPassword = shaAlgo.ComputeHash(passBytes);

            var query =
                (from utilizator in entities.Utilizator
                    where utilizator.cont == name && utilizator.parola == hashedPassword
                    select utilizator
                    );
            var result = query.ToArray();
            if (result.Length == 0)
                return null;
            else
                return new User()
                {    
                    AccountName = result[0].cont,
                    Email = result[0].email,
                    Guid = result[0].id,
                    Name = result[0].prenume,
                    Surname = result[0].nume,
                };

        }
    }
}
