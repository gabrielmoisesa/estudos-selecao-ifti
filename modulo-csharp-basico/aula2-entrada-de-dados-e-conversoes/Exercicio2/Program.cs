using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

bool recargaValida = false;
decimal valorRecarga = 0;

while (!recargaValida)
{
  System.Console.Write("Digite o valor da recarga: ");
  if (decimal.TryParse(Console.ReadLine(), out valorRecarga) && valorRecarga >= 5)
    recargaValida = true;
  else
    System.Console.WriteLine("\nValor da recarga inválido! Digite um número válido igual ou maior a R$ 5,00.\n");
}

bool duracaoPlanoValido = false;
int duracaoPlano = 0;

while (!duracaoPlanoValido)
{
  System.Console.Write("Digite a quantidade de meses do plano: ");
  if (int.TryParse(Console.ReadLine(), out duracaoPlano) && duracaoPlano >= 1 && duracaoPlano <= 24)
    duracaoPlanoValido = true;
  else
    System.Console.WriteLine("\nDuração do plano inválida! Digite um número inteiro válido entre 1 e 24.\n");
}

decimal bonus = (valorRecarga >= 50 ? valorRecarga * 0.10m : 0);
decimal creditoFinal = valorRecarga + bonus;

System.Console.WriteLine("=== RESUMO ===");
System.Console.WriteLine($"Valor pago: {valorRecarga:C}");
if (bonus > 0) System.Console.WriteLine($"Crédito bônus: {bonus:C}");
System.Console.WriteLine($"Crédito final: {creditoFinal:C}");
System.Console.WriteLine($"Bônus: {(bonus > 0 ? "Sim" : "Não")}");
