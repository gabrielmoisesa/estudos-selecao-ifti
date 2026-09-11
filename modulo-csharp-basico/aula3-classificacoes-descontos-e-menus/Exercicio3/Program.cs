string menu = "";

foreach (TipoVistoria tipo in Enum.GetValues<TipoVistoria>())
  menu += $"{(int)tipo} - {tipo}\n";

System.Console.WriteLine(menu.Trim());

int opcao;
while (!int.TryParse(Console.ReadLine(), out opcao) || !Enum.IsDefined(typeof(TipoVistoria), opcao))
{
  System.Console.WriteLine(menu);
  System.Console.WriteLine("Opcao inexistente. Tente novamente:");
}

TipoVistoria escolhaVistoria = (TipoVistoria)opcao;
string procedimento = "";
int tempoPrevisto = 0;

switch (escolhaVistoria)
{
  case TipoVistoria.Freios:
    procedimento = "ajuste e troca de pastilhas";
    tempoPrevisto = 20;
    break;
  case TipoVistoria.Pneus:
    procedimento = "calibragem e inspeção";
    tempoPrevisto = 10;
    break;
  case TipoVistoria.Bateria:
    procedimento = "teste de carga";
    tempoPrevisto = 15;
    break;
  case TipoVistoria.RevisaoCompleta:
    procedimento = "todos os itens";
    tempoPrevisto = 45;
    break;
}

System.Console.WriteLine("=== RELATORIO ===");
System.Console.WriteLine($"Vistoria escolhida: {escolhaVistoria}");
System.Console.WriteLine($"Procedimento: {procedimento}");
System.Console.WriteLine($"Tempo previsto {tempoPrevisto} minutos");

enum TipoVistoria
{
  Freios = 1,
  Pneus = 2,
  Bateria = 3,
  RevisaoCompleta = 4
}