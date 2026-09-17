using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

// req 1.
int[] duracaoCorridas = new int[6];

for (int i = 0; i < duracaoCorridas.Length; i++)
{
  bool valida = false;

  while (!valida)
  {
    Console.Write($"Duração da corrida {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out duracaoCorridas[i]))
      valida = true;
    else
      Console.WriteLine("Digite um número válido.");
  }
}

// req 2.
int totalMinutos = 0;
int corridaMaisLonga = duracaoCorridas[0];
int indiceCorridaMaisLonga = 0;

for (int i = 0; i < duracaoCorridas.Length; i++)
{
  totalMinutos += duracaoCorridas[i];

  if (duracaoCorridas[i] > corridaMaisLonga)
  {
    corridaMaisLonga = duracaoCorridas[i];
    indiceCorridaMaisLonga = i;
  }
}

// req 3.
decimal mediaMinutos = (decimal)totalMinutos / duracaoCorridas.Length;

// req 4.
int qtdCorridasAcimaMedia = 0;

foreach (int duracao in duracaoCorridas)
{
  if (duracao > mediaMinutos)
    qtdCorridasAcimaMedia += 1;
}

// req 5.
Console.WriteLine("\n=== RELATÓRIO ===");

for (int i = 0; i < duracaoCorridas.Length; i++)
  Console.WriteLine($"Corrida {i + 1}: {duracaoCorridas[i]} minutos");

Console.WriteLine();
Console.WriteLine(@$"Total: {totalMinutos} minutos

Corrida mais longa (posição, duração): {indiceCorridaMaisLonga}, {corridaMaisLonga} minutos
Média: {mediaMinutos:N1} minutos
Quantidade de corridas acima da média: {qtdCorridasAcimaMedia}
");
