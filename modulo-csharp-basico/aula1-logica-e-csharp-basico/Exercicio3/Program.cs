int[] duracaoCorridas = { 25, 18, 32, 45, 27, 39, 21, 60, 41, 93 };
int totalMinutos = 0;
int corridaMaisLonga = 0;

for (int i = 0; i < duracaoCorridas.Length; i++)
{
  totalMinutos += duracaoCorridas[i];

  if (duracaoCorridas[i] > corridaMaisLonga)
    corridaMaisLonga = duracaoCorridas[i];
}

List<string> codigosBikes = new List<string>();
codigosBikes.Add("PU-0001");
codigosBikes.Add("PU-0002");
codigosBikes.Remove("PU-0001");

if (!codigosBikes.Contains("PU-0001"))
  System.Console.WriteLine("O código não existe.");

List<string> bikesFrota = new() { "PU-0001", "PU-0002", "PU-0003", "", "PU-0005" };
List<string> bikesManutencao = new() { "PU-0002" };
List<string> codigosValidos = new List<string>();

foreach (string codigo in bikesFrota)
{
  if (bikesManutencao.Contains(codigo))
    continue;

  if (codigo == "")
    break;

  string[] partesCodigo = codigo.Split("-");
  bool temQuatroDigitos = partesCodigo.Length == 2 && partesCodigo[1].Length == 4;

  if (codigo.StartsWith("PU-") && temQuatroDigitos)
  {
    System.Console.WriteLine($"Código {codigo} validado corretamente!");
    codigosValidos.Add(codigo);
  }
  else
    System.Console.WriteLine($"Código {codigo} não possuí o formato correto.");
}

System.Console.WriteLine("\n======== Relatório Final ========");
System.Console.WriteLine($"Total de minutos rodados: {totalMinutos} minutos");
System.Console.WriteLine($"Corrida mais longa: {corridaMaisLonga} minutos");
System.Console.WriteLine($"Quantidade de bikes ativas: {codigosValidos.Count()}");

System.Console.WriteLine("Lista de códigos válidos:");
for (int i = 0; i < codigosValidos.Count(); i++)
  System.Console.WriteLine($"{i} — {codigosValidos[i]}");