using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class StandardMessages
    {
        public static void WelcomeMessage ()
        {
            Console.WriteLine("Bem-vindo");
        }

        public static void EndApplication ()
        {
            Console.ReadLine();
        }
    }
}
