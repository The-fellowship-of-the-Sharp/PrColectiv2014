using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardManagement.Model
{
    public class User // inspectorul
    {
        public User()
        {}

        public int Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AccountName { get; set; }
        public string Email { get; set; }
    }
}