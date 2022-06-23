// See https://aka.ms/new-console-template for more information
using SOLID.SRP;

StandardMessages.WelcomeMessage();

Person person = PersonDataCapture.Capture();

bool isPersonValid = PersonValidator.Validate(person);

if (!isPersonValid)
{
    StandardMessages.EndApplication();
    return;
}

Console.WriteLine($"Seu nome de usuário é {person.FirstName[..1]}{person.LastName}".ToLower());

StandardMessages.EndApplication();
