using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class PersonValidator
    {
        /*uma possibilidade seria criar dois métodos, um para validar FirstName e outro para validar LastName, mas 
         * isso faria com que a classe principal tivesse que chamar os dois métodos, além disso, se uma nova propriedade
         * for criada e precisar ser validada, precisaria ser criado um terceiro método e a classe principal sofreria
         * mais uma alteração para chamá-lo*/
        public static bool Validate (Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.DisplayValidationError("primeiro nome");
                return false;
            }
            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.DisplayValidationError("último nome");
                return false;
            }
            return true;
        }
    }
}
