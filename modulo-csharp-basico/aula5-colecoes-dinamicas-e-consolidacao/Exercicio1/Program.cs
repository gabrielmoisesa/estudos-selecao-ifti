// Program.cs - Lojinha de acessorios
List<string> produtos = new List<string> { "Capacete", "Garrafa", "Cadeado", "Farol" };
List<int> quantidades = new List<int> { 10, 18, 7, 12 };

Console.WriteLine("=== LOJINHA PEDALURBANO ===");

// TODO 1: exibir o estoque inicial (um unico for para as duas listas)
for (int i = 0; i < produtos.Count; i++)
  Console.WriteLine($"{produtos[i]}: {quantidades[i]} unidades");

// TODO 2: adicionar "Luva" (25) nas DUAS listas
produtos.Add("Luva");
quantidades.Add(25);

// TODO 3: atualizar "Garrafa" para 5 (IndexOf + indice)
int indexGarrafa = produtos.IndexOf("Garrafa");

if (indexGarrafa >= 0)
  quantidades[indexGarrafa] = 5;

// TODO 4: verificar se "Capa de chuva" existe (Contains)
Console.WriteLine($"\nExiste 'Capa de chuva': {(produtos.Contains("Capa de chuva") ? "Sim" : "Não")}");

// TODO 5: remover "Cadeado" de forma sincronizada (IndexOf + RemoveAt nas duas)
int indexCadeado = produtos.IndexOf("Cadeado");

if (indexCadeado >= 0)
{
  produtos.RemoveAt(indexCadeado);
  quantidades.RemoveAt(indexCadeado);
}

// TODO 6: estoque final + total de unidades
int totalUnidades = 0;

Console.WriteLine("\n=== ESTOQUE FINAL ===");
for (int i = 0; i < produtos.Count; i++)
{
  Console.WriteLine($"{produtos[i]}: {quantidades[i]} unidades");
  totalUnidades += quantidades[i];
}

Console.WriteLine($"\nTotal de unidades: {totalUnidades} unidades");
