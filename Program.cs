Console.Clear();

decimal salarioMensal,
horasDiaria,
horasTrabalhadas,
ValorTotalHrExtra;
const decimal acrescimoHrExtra = 1.4m;

Console.WriteLine("Bem vindo, aqui você calcula suas horas extra do dia\n");

salarioMensal = ValorDigitado("Qual seu salário mensal bruto?: ");
horasDiaria = ValorDigitado("Quantas horas você trabalha por dia?: ");
horasTrabalhadas = ValorDigitado("Quantas horas você trabalhou hoje? (incluindo horas extra): ");

ValorTotalHrExtra = ValorTotal(salarioMensal, horasDiaria, horasTrabalhadas);
Console.WriteLine($"\nVocê tem {ValorTotalHrExtra:C} para receber deste dia referente às horas extra\n");


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

decimal ValorTotal(decimal salMens, decimal hrDir, decimal hrTrab)
{
    decimal salarioHoraBase,
    horasExtra,
    Total;

    salarioHoraBase = salMens / 30 / hrDir;
    horasExtra = hrTrab - hrDir;
    Total = salarioHoraBase * acrescimoHrExtra * horasExtra;
    return Total;
}
