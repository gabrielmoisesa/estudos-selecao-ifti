using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

// Program.cs - Classificador PedalClub
// Teste 1: gasto 180,00 / 14 meses / com cartao / estudante  -> Diamante
// Teste 2: gasto 95,50  / 5 meses  / com cartao / nao        -> Ouro
// Teste 3: gasto 260,00 / 8 meses  / sem cartao / nao        -> qual categoria? Por que?
decimal gastoMes = 180.00m;
int mesesCliente = 14;
bool possuiCartaoClube = true;
bool ehEstudante = true;

string categoria;
// TODO 1: condicao do Diamante (|| e && com parenteses)
if (gastoMes > 300 || (gastoMes > 150 && mesesCliente > 12))
  categoria = "Diamante";
// TODO 2: cadeia if / else if / else completa
else if (gastoMes >= 80 && gastoMes <= 150 && possuiCartaoClube)
  categoria = "Ouro";
else if (gastoMes >= 40)
  categoria = "Prata";
else
  categoria = "Bronze";
// TODO 3: beneficios por categoria (switch expression)
string beneficios = categoria switch
{
  "Diamante" => "30 min gratis + Bike eletrica + Suporte prioritario",
  "Ouro" => "15 min gratis + Bike eletrica",
  "Prata" => "10 min gratis",
  _ => "5 min gratis na primeira corrida",
};
// TODO 4: beneficio extra de estudante (+=)
if (ehEstudante) beneficios += " + 20% na mensalidade";
// TODO 5: relatorio final
System.Console.WriteLine("=== RELATÓRIO ===");
System.Console.WriteLine($"Gasto no mês: {gastoMes:C}");
System.Console.WriteLine($"Tempo como cliente: {mesesCliente} meses");
System.Console.WriteLine($"Cartão do clube: {(possuiCartaoClube ? "Sim" : "Não")}");
System.Console.WriteLine($"Estudante: {(ehEstudante ? "Sim" : "Não")}");
System.Console.WriteLine($"Categoria: {categoria}");
System.Console.WriteLine($"Benefícios: {beneficios}");