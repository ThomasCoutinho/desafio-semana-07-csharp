Console.WriteLine("============================================");
Console.WriteLine("              Sistema de Login              ");
Console.WriteLine("============================================");

string login = "admin";
string senha = "123456";

Console.Write("\nDigite o usuário: ");
string loginDig = Console.ReadLine();
Console.Write("Digite a senha: ");
string senhaDig = Console.ReadLine();
Console.WriteLine("\n============================================");

if (loginDig == login && senhaDig == senha)
{
    Console.WriteLine("Login realizado com sucesso!");
}
else
{
    Console.WriteLine("Usuário ou senha incorretos!");
}
Console.WriteLine("============================================");