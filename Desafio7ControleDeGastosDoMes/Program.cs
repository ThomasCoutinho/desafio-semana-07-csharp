Console.WriteLine("============================================");
Console.WriteLine("         Controle de Gastos do Mês          ");
Console.WriteLine("============================================");

var gastos = new List<double>();

gastos.Add(150.00);
gastos.Add(250.00);
gastos.Add(400.00);
gastos.Add(80.00);

Console.WriteLine("Gastos do mês:");
foreach (var gasto in gastos)
{
    Console.WriteLine($" - R$ {gasto:F2}");
}
Console.WriteLine("============================================");

double totalGastos = gastos.Sum();
Console.WriteLine($"\nO total dos gastos deste mês foi de R${totalGastos:F2}.");

double mediaGastos = gastos.Average();
Console.WriteLine($"\nA média dos gastos deste mês foi de R$ {mediaGastos:F2}.");

Console.WriteLine("\n============================================");

if (mediaGastos > 200)
{
    Console.WriteLine("Gastos elevados, procure economizar!");
}
else
{
    Console.WriteLine("Gastos controlados, continue assim.");
}
Console.WriteLine("============================================");
