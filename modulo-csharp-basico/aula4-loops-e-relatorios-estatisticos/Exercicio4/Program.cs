using System.Globalization;

CultureInfo culture = new("pt-BR");
Thread.CurrentThread.CurrentCulture = culture;

List<decimal> notasAlunos = new List<decimal>();

for (int i = 0; i < 6; i++)
{
  bool valida = false;

  while (!valida)
  {
    Console.Write($"Digite a nota do aluno {i + 1}: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal nota) && nota >= 0 && nota <= 10)
    {
      notasAlunos.Add(nota);
      valida = true;
    }
    else
      Console.WriteLine("Nota inválida. Digite um número válido de 0 a 10.");
  }
}

decimal mediaTurma = notasAlunos.Sum() / notasAlunos.Count;

decimal maiorNota = notasAlunos[0];
decimal menorNota = notasAlunos[0];

int quantidadeAcimaDaMedia = 0;
int quantidadeEmRecuperacao = 0;

foreach (decimal nota in notasAlunos)
{
  if (nota > maiorNota)
    maiorNota = nota;

  if (nota < menorNota)
    menorNota = nota;

  if (nota > mediaTurma)
    quantidadeAcimaDaMedia += 1;

  if (nota < 6)
    quantidadeEmRecuperacao += 1;
}

string classificacaoTurma = mediaTurma >= 8 ? "Turma excelente" : mediaTurma >= 6 ? "Turma regular" : "Turma em recuperacao";

Console.WriteLine("\n=== BOLETIM DA TURMA ===");
for (int i = 0; i < notasAlunos.Count; i++)
{
  Console.WriteLine($"Aluno {i + 1}: {notasAlunos[i]}");
}

Console.WriteLine(@$"
Media da turma: {mediaTurma:N1}
Maior nota: {maiorNota}
Menor nota: {menorNota}
Alunos acima da media: {quantidadeAcimaDaMedia}
Alunos em recuperacao: {quantidadeEmRecuperacao}

Classificacao: {classificacaoTurma}");
