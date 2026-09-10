using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

string tarifaTexto = "18.70";
string minutosTexto = "52";
string planoAtivoTexto = "true";

bool tarifaValido = decimal.TryParse(tarifaTexto, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal tarifa);
bool minutosValido = int.TryParse(minutosTexto, out int minutos);
bool planoAtivoValido = bool.TryParse(planoAtivoTexto, out bool planoAtivo);

System.Console.WriteLine("=== VALIDACAO ===");
System.Console.WriteLine($"Tarifa: {(tarifaValido ? "OK" : "ERRO")}");
System.Console.WriteLine($"Minutos: {(minutosValido ? "OK" : "ERRO")}");
System.Console.WriteLine($"Plano ativo: {(planoAtivoValido ? "OK" : "ERRO")}");

if (tarifaValido && minutosValido && planoAtivoValido)
{
  System.Console.WriteLine("=== CORRIDA IMPORTADA ===");
  System.Console.WriteLine($"Tarifa: {tarifa:C}");
  System.Console.WriteLine($"Tempo: {minutos} minutos");
  System.Console.WriteLine($"Plano: {(planoAtivo ? "Sim" : "Não")}");
}
else
  System.Console.WriteLine("\nRegistro rejeitado.");

// Se a tarifa "18.70" fosse convertida sem InvariantCulture em um computador brasileiro, o valor se tornaria "1870" ao invés de 18,70 por conta da diferença de sistemas de separação de milhar e decimal entre pt-BR e o padrão que usa o ponto "." como decimal, como o americano.