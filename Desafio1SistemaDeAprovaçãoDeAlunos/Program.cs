Console.WriteLine("============================================");
Console.WriteLine("       Sistema de Aprovação de Alunos       ");
Console.WriteLine("============================================");

Console.Write("\nDigite o nome do aluno: ");
var nomeAluno = Console.ReadLine();

Console.Write("\nDigite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n============================================");
double mediaFinal = calcularMedia(nota1, nota2);

if (mediaFinal >= 7)
{
    Console.WriteLine($"Aluno {nomeAluno} APROVADO! Média: {mediaFinal:F2}.");
}
else if (mediaFinal >= 5 && mediaFinal < 7)
{
    Console.WriteLine($"Aluno {nomeAluno} em RECUPERAÇÃO! Média: {mediaFinal:F2}.");
}
else
{
    Console.WriteLine($"Aluno {nomeAluno} REPROVADO! Média: {mediaFinal:F2}.");
}
Console.WriteLine("============================================");

static double calcularMedia(double n1, double n2)
{
    return (n1 + n2) / 2;
}