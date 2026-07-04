Console.WriteLine("============================================");
Console.WriteLine("     Cadastro de Produtos com Dicionário    ");
Console.WriteLine("============================================");

var dicionarioProdutos = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);

dicionarioProdutos.Add("Mouse", 80.00);
dicionarioProdutos.Add("Teclado", 150.00);
dicionarioProdutos.Add("Monitor", 900.00);

Console.WriteLine("              CONSULTA DE PREÇO            ");
Console.Write("\nDigite o nome do produto: ");
string produtoBusca = Console.ReadLine();

Console.WriteLine("\n============================================");

if (dicionarioProdutos.ContainsKey(produtoBusca))
{
    double preco = dicionarioProdutos[produtoBusca];
    Console.WriteLine($"{produtoBusca.ToUpper()} - R$ {preco:F2}");
}
else
{
    Console.WriteLine("Produto não encontrado!");
}
Console.WriteLine("============================================");