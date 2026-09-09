using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

int minutosCorrida1 = 16;
int minutosCorrida2 = 10;
int minutosCorrida3 = 50;
int minutosCorrida4 = 90;

decimal CalcularTarifa(int minutos)
{

  decimal tarifaCorrida;

  if (minutos <= 15)
    tarifaCorrida = 4;
  else if (minutos <= 30)
    tarifaCorrida = 7;
  else if (minutos <= 60)
    tarifaCorrida = 12;
  else
    tarifaCorrida = 12 + (0.30m * (minutos - 60));

  return tarifaCorrida;
}

System.Console.WriteLine(CalcularTarifa(minutosCorrida1));
System.Console.WriteLine(CalcularTarifa(minutosCorrida2));
System.Console.WriteLine(CalcularTarifa(minutosCorrida3));
System.Console.WriteLine(CalcularTarifa(minutosCorrida4));

StatusEstacao statusAtual = StatusEstacao.Operacional;

switch (statusAtual)
{
  case StatusEstacao.Operacional:
    System.Console.WriteLine("Em operação.");
    break;
  case StatusEstacao.Cheia:
    System.Console.WriteLine("Cheia! Redistribua as bikes.");
    break;
  case StatusEstacao.Vazia:
    System.Console.WriteLine("Vazia.");
    break;
  default:
    System.Console.WriteLine("Em manutenção. Bloqueando novas devoluções.");
    break;
}

decimal saldoCliente = 20;
int minutosCorridaCliente = 30;
char tipoCliente = 'A';

if (saldoCliente >= CalcularTarifa(minutosCorridaCliente) && statusAtual == StatusEstacao.Operacional || tipoCliente == 'M' && statusAtual == StatusEstacao.Operacional)
  System.Console.WriteLine("Validação do desbloqueio autorizada.");
else
  System.Console.WriteLine($"Validação do desbloqueio não autorizada. Motivo: {(CalcularTarifa(minutosCorridaCliente) > saldoCliente ? "Saldo insuficiente" : "Estação indisponível.")}");

enum StatusEstacao
{
  Operacional,
  Cheia,
  Vazia,
  EmManutencao
}