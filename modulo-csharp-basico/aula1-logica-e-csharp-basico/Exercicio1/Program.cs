using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

string codigoBike = "PU-0042";
int minutosCorrida = 42;
decimal valorMinuto = 0.45m;
bool planoAtivo = true;
char categoriaBike = 'E';

decimal custoCorrida = minutosCorrida * valorMinuto;

string entradaMinutos = "3b";

if (int.TryParse(entradaMinutos, out int minutos))
  Console.WriteLine($"Minutos informados: {minutos}");
else
  Console.WriteLine("Valor inválido, digite apenas números");

decimal horasCompletas = minutosCorrida / 60;
decimal minutosRestantes = minutosCorrida % 60;

Console.WriteLine("============================");
Console.WriteLine("Ficha completa da corrida");
Console.WriteLine("============================");
Console.WriteLine($"Código da bike: {codigoBike}");
Console.WriteLine($"Minutos da corrida: {minutosCorrida}");
Console.WriteLine($"Valor por minuto: {valorMinuto:C}");
Console.WriteLine($"Plano ativo: {(planoAtivo ? "Sim" : "Não")}");
Console.WriteLine($"Categoria: {categoriaBike}");
Console.WriteLine($"Custo corrida: {custoCorrida:C}");
Console.WriteLine($"Horas completas: {horasCompletas}");
Console.WriteLine($"Minutos restantes: {minutosRestantes}");