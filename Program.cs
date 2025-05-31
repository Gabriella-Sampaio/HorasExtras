Console.Clear();

decimal salarioMensal, horasDiaria, horasTrabalhadas;
const decimal acrescimoHrExtra = 1.4m;

Console.WriteLine("Bem vindo, aqui você calcula suas horas extra do dia");

salarioMensal = ValorDigitado("Qual seu salário mensal bruto?: ");
horasDiaria = ValorDigitado("Quantas horas você trabalha por dia?: ");
horasTrabalhadas = ValorDigitado("Quantas horas você trabalhou hoje? (incluindo horas extra): ");

decimal salarioHoraBase = salarioMensal / 30 / horasDiaria;
decimal horasExtra = horasTrabalhadas - horasDiaria;
decimal Total = salarioHoraBase * acrescimoHrExtra * horasExtra;

Console.WriteLine($"{Total:C}");
/*
Fórmula

Valores solicitados

decimal salarioMensal - ganha por mês
double horasDiaria - quanto vc trabalha por dia
double horasTotalDia - quanto vc trabalhou no dia

decimal salárioHoraBase = (salarioMensal / 30) / horasTrabDiaria

horasExtra = horasTotalDia - horasDiaria  // pega quanto a pessoa trabalhou - o q normalmente trabalharia

Total =  (salárioHoraBase * 1,4) * horasExtra


*/





decimal ValorDigitado (string mensagem)
{
    Console.Write(mensagem);
    decimal vlDig;
    while (!Decimal.TryParse(Console.ReadLine(), out vlDig))
    {
        Console.WriteLine("Valor inválido, tente novamente");
        Console.Write(mensagem);
    }
    return vlDig;
}
