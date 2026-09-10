using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

string nome = "Carla Menezes";
string idadeTexto = "22";
string mensalidadeTexto = "149.90";
string bolsistaTexto = "true";

bool idadeValido = int.TryParse(idadeTexto, out int idade);
bool mensalidadeValido = decimal.TryParse(mensalidadeTexto, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal mensalidade);
bool bolsistaValido = bool.TryParse(bolsistaTexto, out bool bolsista);

System.Console.WriteLine("=== MATRICULA ONLINE ===");

System.Console.WriteLine("\nVALIDACAO");
System.Console.WriteLine($"Idade convertida: {(idadeValido ? "OK" : "ERRO")}");
System.Console.WriteLine($"Mensalidade convertida: {(mensalidadeValido ? "OK" : "ERRO")}");
System.Console.WriteLine($"Bolsista convertido: {(bolsistaValido ? "OK" : "ERRO")}");

decimal desconto = bolsista ? mensalidade * 0.3m : 0;
decimal mensalidadeFinal = mensalidade - desconto;
string statusAutorizacao = idade < 18 ? "PENDENTE" : "Nao se aplica";

if (idadeValido && mensalidadeValido && bolsistaValido)
{
  System.Console.WriteLine("\nCOMPROVANTE");
  System.Console.WriteLine($"Aluna: {nome}");
  System.Console.WriteLine($"Idade: {idade} anos");
  System.Console.WriteLine($"Bolsista: {(bolsista ? "Sim" : "Não")}");
  System.Console.WriteLine($"Mensalidade: {mensalidade:C}");
  System.Console.WriteLine($"Desconto (30%): {desconto:C}");
  System.Console.WriteLine($"Valor Final: {mensalidadeFinal:C}");
  System.Console.WriteLine($"Autorizacao do responsavel: {statusAutorizacao}");
}
else
  System.Console.WriteLine("\nComprovante rejeitado.");