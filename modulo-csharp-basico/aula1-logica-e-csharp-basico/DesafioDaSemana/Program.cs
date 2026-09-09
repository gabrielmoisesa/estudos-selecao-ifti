using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

// Program.cs - Fechamento do dia PedalUrbano
int[] minutosCorridas = { 12, 25, 70, 8, 45, 90, 30, 55 };
TipoPlano[] planosCorridas =
{
    TipoPlano.Avulso, TipoPlano.Mensalista, TipoPlano.Turista, TipoPlano.Avulso,
    TipoPlano.Mensalista, TipoPlano.Avulso, TipoPlano.Turista, TipoPlano.Mensalista
};

// TODO: calcular a tarifa de cada corrida (regras do Caso A)
decimal CalcularTarifa(int minutos, TipoPlano plano)
{
  const decimal taxaDesbloqueio = 3.00m;
  decimal valorTempo;

  // Faixas de tempo (regra de negocio da PedalUrbano)
  if (minutos <= 15)
    valorTempo = 4.00m;
  else if (minutos <= 30)
    valorTempo = 7.00m;
  else if (minutos <= 60)
    valorTempo = 12.00m;
  else
    valorTempo = 12.00m + (minutos - 60) * 0.30m;   // faixa cheia + 0,30 por minuto excedente

  // Desconto por plano com switch expression
  decimal desconto = plano switch
  {
    TipoPlano.Mensalista => 0.20m,
    TipoPlano.Turista => 0.10m,
    _ => 0m
  };

  decimal total = (taxaDesbloqueio + valorTempo) * (1 - desconto);
  return total;
}

decimal[] tarifaCorridas = new decimal[8];

for (int i = 0; i < tarifaCorridas.Length; i++)
  tarifaCorridas[i] = CalcularTarifa(minutosCorridas[i], planosCorridas[i]);

Array.ForEach(tarifaCorridas, Console.WriteLine);

// TODO: acumular o faturamento total
decimal faturamentoTotal = tarifaCorridas.Sum();
Console.WriteLine($"Faturamento total: {faturamentoTotal:C}");

// TODO: classificar cada corrida (Curta / Media / Longa) e contar por categoria
DuracaoCorrida[] duracaoCorridas = new DuracaoCorrida[8];
int contadorCorridaCurta = 0;
int contadorCorridaMedia = 0;
int contadorCorridaLonga = 0;

for (int i = 0; i < tarifaCorridas.Length; i++)
{
  if (minutosCorridas[i] <= 15)
  {
    contadorCorridaCurta += 1;
    duracaoCorridas[i] = DuracaoCorrida.Curta;
  }
  else if (minutosCorridas[i] <= 60)
  {
    contadorCorridaMedia += 1;
    duracaoCorridas[i] = DuracaoCorrida.Media;
  }
  else
  {
    contadorCorridaLonga += 1;
    duracaoCorridas[i] = DuracaoCorrida.Longa;
  }
}

foreach (var duracaoCorrida in duracaoCorridas)
  Console.WriteLine(duracaoCorrida);

Console.WriteLine($"\nCorridas curtas: {contadorCorridaCurta}");
Console.WriteLine($"Corridas médias: {contadorCorridaMedia}");
Console.WriteLine($"Corridas Longas: {contadorCorridaLonga}");

// TODO: identificar a corrida mais cara
decimal corridaMaisCara = tarifaCorridas.Max();
Console.WriteLine($"\nCorrida mais cara: Posição = {Array.IndexOf(tarifaCorridas, corridaMaisCara)}, Valor = {corridaMaisCara:C}");
// TODO: imprimir o relatorio final formatado
Console.WriteLine("================");
Console.WriteLine("Relatório Final");
Console.WriteLine("================");
Console.WriteLine($"Total de corridas: {minutosCorridas.Length}");
Console.WriteLine("----------");
Console.WriteLine($"Contagem por categoria:");
Console.WriteLine($"Corridas curtas: {contadorCorridaCurta}");
Console.WriteLine($"Corridas médias: {contadorCorridaMedia}");
Console.WriteLine($"Corridas Longas: {contadorCorridaLonga}");
Console.WriteLine("----------");
Console.WriteLine($"Faturamento total: {faturamentoTotal:C}");
Console.WriteLine($"Corrida mais cara: {tarifaCorridas.Max():C}");

enum DuracaoCorrida
{
  Curta,
  Media,
  Longa
}

enum TipoPlano
{
  Avulso,
  Mensalista,
  Turista
}