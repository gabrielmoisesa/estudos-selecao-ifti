using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

// Program.cs - Ficha de devolucao
Console.WriteLine("=== TOTEM DE DEVOLUCAO ===");

// TODO 1: ler e normalizar o codigo da bike
System.Console.Write("Digite o código da bike: ");
string codigoBike = (Console.ReadLine() ?? "").Trim().ToUpper();
// TODO 2: ler os minutos de uso com int.TryParse (encerrar se invalido)
System.Console.Write("Digite os minutos de uso: ");
if (!int.TryParse(Console.ReadLine(), out int minutos))
{
  Console.WriteLine("Minutos invalidos.");
  return;
}
// TODO 3: ler o valor por minuto com decimal.TryParse (encerrar se invalido)
System.Console.Write("Digite o valor por minuto: ");
if (!decimal.TryParse(Console.ReadLine(), NumberStyles.Any, culture, out decimal valorMinuto))
{
  Console.WriteLine("Valor invalido.");
  return;
}
// TODO 4: calcular o custo da corrida
decimal custoCorrida = minutos * valorMinuto;
// TODO 5: imprimir a ficha formatada
System.Console.WriteLine("=== DEVOLUCAO ===");
System.Console.WriteLine($"Código da bike: {codigoBike}");
System.Console.WriteLine($"Minutos: {minutos}");
System.Console.WriteLine($"Valor por minuto: {valorMinuto:C}");
System.Console.WriteLine($"Custo: {custoCorrida:C}");
