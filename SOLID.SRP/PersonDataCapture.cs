using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    /* A única razão para essa classe sofrer mudanças, é a alteração das informações capturadas de Person,
     * portanto ela respeita o SRP*/
    internal class PersonDataCapture
    {
        public static Person Capture ()
        {
            Person output = new();

            Console.WriteLine("Qual seu primeiro nome?");
            output.FirstName = Console.ReadLine()!;

            Console.WriteLine("Qual seu último nome?");
            output.LastName = Console.ReadLine()!;
            return output;
        }
    }
}
