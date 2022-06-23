// See https://aka.ms/new-console-template for more information
using SOLID.SRP;

StandardMessages.WelcomeMessage();

Person person = new();

Console.WriteLine("Qual seu primeiro nome?");
person.FirstName = Console.ReadLine()!;

Console.WriteLine("Qual seu último nome?");
person.LastName = Console.ReadLine()!;

if (string.IsNullOrEmpty(person.FirstName))
{
    Console.WriteLine("Você não informou um primeiro nome válido");
    StandardMessages.EndApplication();
    return;
}

if (string.IsNullOrEmpty(person.LastName))
{
    Console.WriteLine("Você não informou um último nome válido");
    StandardMessages.EndApplication();
    return;
}

Console.WriteLine($"Seu nome de usuário é {person.FirstName[..1]}{person.LastName}".ToLower());

StandardMessages.EndApplication();
