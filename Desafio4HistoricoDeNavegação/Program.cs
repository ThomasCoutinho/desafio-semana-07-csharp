Console.WriteLine("============================================");
Console.WriteLine("           Histórico de navegação           ");
Console.WriteLine("             Last In, First Out             ");
Console.WriteLine("============================================");

Stack<string> historico = new Stack<string>();
historico.Push("meusite.com.br/home");
historico.Push("meusite.com.br/produtos");
historico.Push("meusite.com.br/carrinho");


Console.WriteLine("\nHistórico de navegação:");
foreach (string pagina in historico)
{
    Console.WriteLine($"- {pagina}");
}

string ultimaPag = historico.Pop();
Console.WriteLine("\n============================================");
Console.WriteLine($"      **** Botão voltar clicado! ****      ");
Console.WriteLine("============================================");
Console.WriteLine($"\nSaindo de: {ultimaPag}");

Console.WriteLine($"\nVoltando para: {historico.Peek()}");