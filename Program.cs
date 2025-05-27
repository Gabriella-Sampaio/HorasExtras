Console.Clear();

/*
Escreva uma função que calcule o salário de um funcionário 
a partir salário-hora base, (recebe quanto a pessoa recebe por
hora no dia)
o total de horas trabalhadas (recebe quanto a pessoa 
trabalha normalmente)
e número de horas-extras executadas. (recebe quantas horas extra
a pessoa fez) 
Considere que cada hora-extra é paga com acréscimo de 40%.

faz o cálculo em uma subrotina

idéia - fazer um programa q calcula de duas pessoas
*/

decimal salarioMensal;
double horasDiaria, horasTotalDia;
bool salarioMensalTrue, horasDiariaTrue;

Console.WriteLine("Bem vindo, aqui você calcula suas horas extra do dia");

Console.Write("\nQual seu salário mensal bruto?: "); //pegar e calcular o salário-hora base
do
{
    salarioMensalTrue = Decimal.TryParse(Console.ReadLine(), out salarioMensal);

    if (!salarioMensalTrue)
    {
        Console.Write("\nValor inválido, tente novamente: ");
    }
}
while (!salarioMensalTrue);

// HorasDigitadas("teste: ", horasDiariaTrue, horasDiaria); // ???


// Console.Write("\nQuantas horas você trabalha por mês?: ");
// do
// {
//     horasDiariaTrue = Double.TryParse(Console.ReadLine(), out horasDiaria);
//     if (!horasDiariaTrue)
//     {
//         Console.Write("\nValor inválido, tente novamente: ");
//     }
// }
// while (!horasDiariaTrue);


Console.Write("\nQuantas horas você trabalhou hoje no total? (incluindo horas extra): ");
horasTotalDia = Convert.ToDouble(Console.ReadLine());


/*
Fórmula

Valores solicitados
decimal salarioMensal
double horasDiaria - quanto vc trabalha por dia
double horasTotalDia - quanto vc trabalhou no dia

double salárioHoraBase = (salarioMensal / 30) / horasTrabDiaria

horasExtra = horasTotalDia - horasDiaria  // pega quanto a pessoa trabalhou - o q normalmente trabalharia

Total =  (salárioHoraBase * 1,4) * horasExtra 


*/



void HorasDigitadas (string mensagem, bool hrbool, double hr)
{
    Console.Write(mensagem);
    do
    {
        hrbool = Double.TryParse(Console.ReadLine(), out hr);
        if (!hrbool)
        {
            Console.Write("\nValor inválido, tente novamente: ");
        }
    }
    while (!hrbool);
}

