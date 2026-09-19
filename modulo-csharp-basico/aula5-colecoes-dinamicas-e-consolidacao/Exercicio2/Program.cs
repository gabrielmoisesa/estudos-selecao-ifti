// req 1.
string[] centro = { "PU-0042", "PU-0013", "PU-0007", "PU-0042" };
List<string> parque = new List<string> { "PU-0007", "PU-0101", "PU-0013" };

// req 2.
List<string> todosCodigos = new List<string>();
todosCodigos.AddRange(centro);
todosCodigos.AddRange(parque);

if (todosCodigos.Count == 0)
// req 6. Teste caso especial
{
  Console.WriteLine("Nenhum check-in registrado");
  return;
}

Console.WriteLine($"Contagem unificada: {todosCodigos.Count}");

// req 3.
List<string> codigosUnicos = new List<string>();

foreach (string codigo in todosCodigos)
{
  if (!codigosUnicos.Contains(codigo))
    codigosUnicos.Add(codigo);
}

Console.WriteLine($"Contagem de bikes únicas: {codigosUnicos.Count}");

// req 4.
codigosUnicos.Sort();

Console.WriteLine();
for (int i = 0; i < codigosUnicos.Count; i++)
  Console.WriteLine($"Código {i + 1}: {codigosUnicos[i]}");

// req 5.
int quantidadeDuplicados = todosCodigos.Count - codigosUnicos.Count;

Console.WriteLine($"\nQuantidade de registros duplicados descartados: {quantidadeDuplicados}");

// req 6. (Teste caso especial)
// If adicionado na linha 10 para exibir "Nenhum check-in registrado"
// em caso de valores vazios e sem quebrar.
