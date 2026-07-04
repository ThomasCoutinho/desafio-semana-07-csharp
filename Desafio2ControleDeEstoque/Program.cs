Console.WriteLine("============================================");
Console.WriteLine("      Controle de Estoque de Produtos       ");
Console.WriteLine("============================================");

Console.Write("\nDigite o nome do produto: ");
var nomeProduto = Console.ReadLine();

Console.Write("Digite a quantidade atual: ");
int quantAtual = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n============================================");

if (quantAtual < 5)
{
    Console.WriteLine($"Estoque de {nomeProduto} crítico, necessário reposição urgente!");
}
else if (quantAtual >= 5 && quantAtual <= 10)
{
    Console.WriteLine($"Estoque de {nomeProduto} baixo, fique atento!");
}
else
{
    Console.WriteLine($"Estoque de {nomeProduto} OK!");
}

Console.WriteLine("============================================");