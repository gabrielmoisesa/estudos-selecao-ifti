using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

// req 1.
int quantidadeCorridas = 0;
bool valida = false;

while (!valida)
{
  Console.Write("Quantas corridas serão auditadas? ");
  if (int.TryParse(Console.ReadLine(), out quantidadeCorridas) && quantidadeCorridas >= 2 && quantidadeCorridas <= 15)
    valida = true;
  else
    Console.WriteLine("Digite um número inteiro válido entre 2 e 15.");
}

// req 2.
List<decimal> tarifas = new List<decimal>();


for (int i = 0; i < quantidadeCorridas; i++)
{
  valida = false;

  while (!valida)
  {
    Console.Write($"Digite o valor da tarifa {i + 1}: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal tarifa) && tarifa > 0)
    {
      tarifas.Add(tarifa);
      valida = true;
    }
    else
      Console.WriteLine("Digite um número positivo válido.");
  }
}

// req 3.
decimal totalTarifas = 0;
decimal maiorTarifa = tarifas[0];
decimal menorTarifa = tarifas[0];

foreach (decimal tarifa in tarifas)
{
  totalTarifas += tarifa;

  if (tarifa > maiorTarifa)
    maiorTarifa = tarifa;

  if (tarifa < menorTarifa)
    menorTarifa = tarifa;
}

decimal mediaTarifas = totalTarifas / tarifas.Count;

Console.WriteLine();
Console.WriteLine(@$"Quantidade: {tarifas.Count} corridas
Total tarifas: {totalTarifas:C}
Maior tarifa: {maiorTarifa:C}
Menor tarifa: {menorTarifa:C}
Média: {mediaTarifas:C}
");

// req 4.
valida = false;

while (!valida)
{
  Console.Write("Digite a tarifa da corrida extra: ");
  if (decimal.TryParse(Console.ReadLine(), out decimal tarifa))
  {
    tarifas.Add(tarifa);
    valida = true;
  }
  else
    Console.WriteLine("Digite um número positivo válido.");
}

// req 5.
totalTarifas = 0;
maiorTarifa = tarifas[0];
menorTarifa = tarifas[0];

foreach (decimal tarifa in tarifas)
{
  totalTarifas += tarifa;

  if (tarifa > maiorTarifa)
    maiorTarifa = tarifa;

  if (tarifa < menorTarifa)
    menorTarifa = tarifa;
}

mediaTarifas = totalTarifas / tarifas.Count;

Console.WriteLine();
Console.WriteLine(@$"Quantidade: {tarifas.Count} corridas
Total tarifas: {totalTarifas:C}
Maior tarifa: {maiorTarifa:C}
Menor tarifa: {menorTarifa:C}
Média: {mediaTarifas:C}
");

// req 6.
int quantidadeAcimaDe25 = 0;
int quantidadeAbaixoDe8 = 0;

foreach (decimal tarifa in tarifas)
{
  if (tarifa > 25)
    quantidadeAcimaDe25 += 1;

  if (tarifa < 8)
    quantidadeAbaixoDe8 += 1;
}

Console.WriteLine(@$"Quantidade de tarifas acima de R$ 25,00: {quantidadeAcimaDe25}
Quantidade de tarifas abaixo de R$ 8,00: {quantidadeAbaixoDe8}");
