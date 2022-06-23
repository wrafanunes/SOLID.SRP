using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class AccountGenerator
    {
        public static void CreateAccount (Person user)
        {
            Console.WriteLine($"Seu nome de usuário é {user.FirstName[..1]}{user.LastName}".ToLower());
        }
    }
}
