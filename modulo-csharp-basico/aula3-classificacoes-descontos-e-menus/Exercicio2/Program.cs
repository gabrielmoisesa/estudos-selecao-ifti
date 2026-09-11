using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

decimal valorCorrida = 48.00m;
string planoCliente = "Mensalista";
string formaPagamento = "Credito";

decimal descontoPlano = planoCliente switch
{
  "Mensalista" => 0.2m,
  "Turista" => 0.1m,
  _ => 0
};

decimal valorAposPlano = valorCorrida - (valorCorrida * descontoPlano);

decimal descontoFormaPagamento = formaPagamento switch
{
  "Dinheiro" => -0.05m,
  "Pix" => -0.03m,
  "Credito" => 0.05m,
  _ => 0,
};

decimal valorFinal = valorAposPlano + (valorAposPlano * descontoFormaPagamento);

int parcelas = 4;
decimal valorParcela = formaPagamento == "Credito" ? valorFinal / parcelas : 0;

if (valorParcela == 0) System.Console.WriteLine("Pagamento a vista");

System.Console.WriteLine("=== RELATORIO ===");
System.Console.WriteLine($"Valor original: {valorCorrida:C}");
System.Console.WriteLine($"Valor após plano: {valorAposPlano:C}");
System.Console.WriteLine($"Valor após plano e desconto de forma de pagamento: {valorFinal:C}");
System.Console.WriteLine($"Parcelamento: {(valorParcela > 0 ? $"{valorParcela:C} ({parcelas}x)" : "pagamento a vista")}");