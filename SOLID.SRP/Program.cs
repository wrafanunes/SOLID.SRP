// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem-vindo");

Person person = new();

Console.WriteLine("Qual seu primeiro nome?");
person.FirstName = Console.ReadLine()!;

Console.WriteLine("Qual seu último nome?");
person.LastName = Console.ReadLine()!;

if (string.IsNullOrEmpty(person.FirstName))
{
    Console.WriteLine("Você não informou um primeiro nome válido");
    Console.ReadLine();
    return;
}

if (string.IsNullOrEmpty(person.LastName))
{
    Console.WriteLine("Você não informou um último nome válido");
    Console.ReadLine();
    return;
}

Console.WriteLine($"Seu nome de usuário é {person.FirstName[..1]}{person.LastName}".ToLower());

Console.ReadLine();
