using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

// Program.cs - Relatorio da manha
decimal[] tarifas = { 12.50m, 4.00m, 23.00m, 8.90m, 15.70m, 6.20m };

Console.WriteLine("=== RELATORIO DA MANHA ===");

// TODO 1: imprimir as tarifas numeradas
void ImprimirTarifasNumeradas(decimal[] tarifas)
{
  for (int i = 0; i < tarifas.Length; i++)
    Console.WriteLine($"Corrida {i + 1}: {tarifas[i]:C}");
}

// TODO 2: uma passada: total, contador (> 10), maior e menor
decimal total = 0;
int ctdAcimaDeDez = 0;
decimal maiorTarifa = tarifas[0];
decimal menorTarifa = tarifas[0];

foreach (decimal tarifa in tarifas)
{
  total += tarifa;

  if (tarifa > 10)
    ctdAcimaDeDez += 1;

  if (tarifa > maiorTarifa)
    maiorTarifa = tarifa;

  if (tarifa < menorTarifa)
    menorTarifa = tarifa;
}

// TODO 3: media
decimal media = total / tarifas.Length;

// TODO 4: classificacao da manha
string classificacao = total > 60 ? "Otima" : total >= 40 ? "Normal" : "Fraca";

// TODO 5: relatorio final em secoes
Console.WriteLine("Tarifas Numeradas:");
ImprimirTarifasNumeradas(tarifas);

Console.WriteLine($"\nTotal: {total:C}");
Console.WriteLine($"Quantidade acima de dez: {ctdAcimaDeDez}");
Console.WriteLine($"Maior tarifa: {maiorTarifa:C}");
Console.WriteLine($"Menor tarifa: {menorTarifa:C}");
Console.WriteLine($"Média: {media:C}");
Console.WriteLine($"\nClassificação: {classificacao}");
