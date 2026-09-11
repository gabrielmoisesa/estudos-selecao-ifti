using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

string nomeAluno = "Diego Ramos";
int idadeAluno = 27;
int anosTreino = 3;
bool estudante = true;

decimal planoMensalidade = 120;
TipoPagamentos tipoPagamento = TipoPagamentos.Pix;

string categoria;

if (anosTreino > 5 || (idadeAluno < 25 && anosTreino > 2))
  categoria = "Atleta";
else if (anosTreino > 2)
  categoria = "Intermediario";
else
  categoria = "Iniciante";

string beneficios = categoria switch
{
  "Atleta" => "Avaliacao fisica mensal + Acompanhamento nutricional",
  "Intermediario" => "Avaliacao fisica trimestral",
  _ => "Aula inaugural gratuita"
};

decimal descontoEstudante = 0;
if (estudante)
{
  beneficios += " + 15% de desconto na mensalidade";
  descontoEstudante = 0.15m;
}

decimal valorDescontadoEstudante = planoMensalidade * descontoEstudante;
decimal valorDescontoEstudante = planoMensalidade - valorDescontadoEstudante;

decimal descontoTipoPagamento = tipoPagamento switch
{
  TipoPagamentos.Dinheiro => -0.05m,
  TipoPagamentos.Pix => -0.03m,
  TipoPagamentos.Credito => 0.05m,
  _ => throw new NotImplementedException()
};

decimal valorDescontoPagamento = valorDescontoEstudante * descontoTipoPagamento;
decimal valorFinal = valorDescontoEstudante + valorDescontoPagamento;

System.Console.WriteLine("=== PLANO ACADEMIA FORCA TOTAL ===");
System.Console.WriteLine($"Aluno: {nomeAluno}");
System.Console.WriteLine($"Idade: {idadeAluno} anos");
System.Console.WriteLine($"Tempo de treino: {anosTreino} anos");
System.Console.WriteLine($"Estudante: {(estudante ? "Sim" : "Não")}");

System.Console.WriteLine($"\nCategoria: {categoria}");
System.Console.WriteLine($"Beneficios: {beneficios}");

System.Console.WriteLine($"\nMensalidade: {planoMensalidade:C}");

if (estudante) System.Console.WriteLine($"Desconto estudante ({(int)(descontoEstudante * 100)}%): {valorDescontadoEstudante:C}");

if (tipoPagamento == TipoPagamentos.Dinheiro)
  System.Console.WriteLine($"Ajuste dinheiro (5%): {valorDescontoPagamento:C}");
else if (tipoPagamento == TipoPagamentos.Pix)
  System.Console.WriteLine($"Ajuste Pix (3%): {valorDescontoPagamento:C}");
else if (tipoPagamento == TipoPagamentos.Credito)
  System.Console.WriteLine($"Ajuste crédito: {valorDescontoPagamento:C}");

System.Console.WriteLine($"VALOR FINAL: {valorFinal:C}");

if (tipoPagamento == TipoPagamentos.Credito)
  System.Console.WriteLine("Tipo de Pagamento: parcelado");
else
  System.Console.WriteLine("Tipo de Pagamento: A vista");

enum TipoPagamentos
{
  Dinheiro,
  Pix,
  Credito
}
