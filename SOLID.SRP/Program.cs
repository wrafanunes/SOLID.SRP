// See https://aka.ms/new-console-template for more information
using SOLID.SRP;

/*agora a única responsabilidade da classe principal é controlar o fluxo
 * uma das dicas para seguir o SRP é que se em uma classe for necessário usar a barra de rolagem para percorrer todo
 * o código, é bom analisar se é possível dividi-la em mais partes (isso não se aplica à classe Program)*/
StandardMessages.WelcomeMessage();

Person person = PersonDataCapture.Capture();

bool isPersonValid = PersonValidator.Validate(person);

if (!isPersonValid)
{
    StandardMessages.EndApplication();
    return;
}

AccountGenerator.CreateAccount(person);

StandardMessages.EndApplication();
