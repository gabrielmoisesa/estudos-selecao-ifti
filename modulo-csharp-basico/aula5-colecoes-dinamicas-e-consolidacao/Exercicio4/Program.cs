List<string> produtos = new List<string> { "Dipirona", "Vitamina C", "Protetor Solar", "Termometro" };
List<int> quantidadesProdutos = new List<int> { 25, 8, 4, 12 };

Console.WriteLine("=== ESTOQUE INICIAL ===");
for (int i = 0; i < produtos.Count; i++)
{
  Console.WriteLine($"{produtos[i]}: {quantidadesProdutos[i]} unidades");
}

Console.WriteLine("\n=== OPERACOES ===");

produtos.Add("Mascara");
quantidadesProdutos.Add(30);
int indexMascara = produtos.IndexOf("Mascara");

Console.WriteLine($"Produto adicionado: {produtos[indexMascara]} ({quantidadesProdutos[indexMascara]} unidades)");

int indexProtetorSolar = produtos.IndexOf("Protetor Solar");
quantidadesProdutos[indexProtetorSolar] = 15;

Console.WriteLine($"Quantidade atualizada: {produtos[indexProtetorSolar]} ({quantidadesProdutos[indexProtetorSolar]} unidades)");

Console.WriteLine($"Produto \"Soro\" existe? {(produtos.Contains("Soro") ? "Sim" : "Nao")}");

int qtdAbaixoDeDez = 0;

foreach (int quantidade in quantidadesProdutos)
{
  if (quantidade < 10)
    qtdAbaixoDeDez += 1;
}

Console.WriteLine($"Produtos com estoque baixo (< 10): {qtdAbaixoDeDez}");

int indexTermometro = produtos.IndexOf("Termometro");
produtos.RemoveAt(indexTermometro);
quantidadesProdutos.RemoveAt(indexTermometro);

int totalUnidades = 0;
Console.WriteLine("\n=== ESTOQUE FINAL ===");

for (int i = 0; i < produtos.Count; i++)
{
  totalUnidades += quantidadesProdutos[i];
  Console.WriteLine($"{produtos[i]}: {quantidadesProdutos[i]} unidades");
}

Console.WriteLine($"\nTotal de unidades: {totalUnidades}");
