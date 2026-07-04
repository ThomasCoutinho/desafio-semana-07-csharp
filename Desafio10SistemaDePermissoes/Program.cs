Console.WriteLine("============================================");
Console.WriteLine("           Sistema de Permissões            ");
Console.WriteLine("============================================");

Console.WriteLine("                  CARGOS                   ");
Console.WriteLine("[1] - Administrador");
Console.WriteLine("[2] - Gerente");
Console.WriteLine("[3] - Funcionário");


Console.WriteLine("============================================");
Console.Write("Digite o número correspondente ao cargo: ");
var cargo = Console.ReadLine();

switch (cargo)
{
    case "1":
        Console.WriteLine("============================================");
        Console.WriteLine("            [1] - Administrador             ");
        Console.WriteLine("          Acesso total ao sistema           ");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("  Permissões exclusivas:");
        Console.WriteLine("- Alterar o preço de produtos no sistema.");
        Console.WriteLine("- Gerenciar compras com fornecedores.");
        Console.WriteLine("- Visualizar relatórios de faturamento.");
        break;
    case "2":
        Console.WriteLine("============================================");
        Console.WriteLine("                [2] - Gerente               ");
        Console.WriteLine("    Acesso limitado ao sistema [Nível 2]    ");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("- Aplicar descontos especiais.");
        Console.WriteLine("- Cancelar vendas.");
        Console.WriteLine("- Registro de Ponto Eletrônico.");
        Console.WriteLine("- Consultar preço.");
        Console.WriteLine("- Consultar disponibilidade em estoque.");
        break;
    case "3":
        Console.WriteLine("============================================");
        Console.WriteLine("              [3] - Funcionário             ");
        Console.WriteLine("    Acesso limitado ao sistema [Nível 1]    ");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("- Registro de Ponto Eletrônico.");
        Console.WriteLine("- Consultar preço.");
        Console.WriteLine("- Consultar disponibilidade em estoque.");
        break;
    default:
        Console.WriteLine("============================================");
        Console.WriteLine("              Cargo inválido!               ");
        Console.WriteLine("    Por favor, digite um número válido.     ");
        break;

}
Console.WriteLine("============================================");