// req 1.
int[] canalA = { 85, 42, 15, 85, 60 };
List<int> canalB = new List<int> { 42, 98, 15, 73 };

// req 2.
List<int> canalUnificado = new List<int>();
canalUnificado.AddRange(canalA);
canalUnificado.AddRange(canalB);

List<int> canalUnico = new List<int>();

foreach (int item in canalUnificado)
{
  if (!canalUnico.Contains(item))
    canalUnico.Add(item);
}

canalUnico.Sort();

// req 3.
if (canalUnico.Count == 0)
{
  Console.WriteLine("Nenhuma leitura valida");
  return;
}

for (int i = 0; i < canalUnico.Count; i++)
  Console.WriteLine($"Bateria {i + 1}: {canalUnico[i]}%");

// req 4.
int menorNivel = canalUnico[0];
int maiorNivel = canalUnico[canalUnico.Count - 1];

// req 5 e 6.
int quantidadeSaudavel = 0;
bool alertaCritico = false;

foreach (int nivel in canalUnico)
{
  if (nivel >= 40 && nivel <= 80)
    quantidadeSaudavel += 1;

  if (nivel < 20)
    alertaCritico = true;
}

// req 7.
Console.WriteLine("\n=== RESUMO ===");
Console.WriteLine(@$"Total de leituras distintas: {canalUnico.Count}
Menor nível: {menorNivel}%
Maior nível: {maiorNivel}%
Contagem na faixa saudável: {quantidadeSaudavel} baterias
Alerta de bateria critica: {(alertaCritico ? "Sim" : "Não")}
");
