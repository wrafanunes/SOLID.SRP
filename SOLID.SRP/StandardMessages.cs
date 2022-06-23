namespace SOLID.SRP
{
    // Nesta classe, ainda é possível ir mais a fundo no SRP e criar uma classe para cada mensagem padrão
    internal class StandardMessages
    {
        public static void WelcomeMessage ()
        {
            Console.WriteLine("Bem-vindo");
        }

        public static void EndApplication ()
        {
            /*Por seguir o princípio de responsabilidade única, a nova mensagem inserida funcionará em todas as partes
             * do sistema que usam o método EndApplication, do contrário esse código precisaria ser repetido em outras
             * partes*/
            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }

        public static void DisplayValidationError (string fieldName)
        {
            Console.WriteLine($"Você não inseriu um {fieldName} válido");
        }
    }
}
