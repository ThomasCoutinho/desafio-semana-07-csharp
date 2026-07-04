Console.WriteLine("============================================");
Console.WriteLine("             Sistema de Frete               ");
Console.WriteLine("============================================");

Console.Write("\nDigite o valor compra: ");
var valorCompra = Convert.ToDouble(Console.ReadLine());

double valorFrete = CalcularFrete(valorCompra);

double valorTotal = valorCompra + valorFrete;

Console.WriteLine("\n============================================");
Console.WriteLine($"Valor do frete: R$ {valorFrete:F2}");
Console.WriteLine($"Valor total da compra: R$ {valorTotal:F2}");
Console.WriteLine("============================================");

static double CalcularFrete(double valorCompra)
{
    if (valorCompra >= 300)
    {
        return 0.00;
    }
    else if (valorCompra >= 200 && valorCompra <= 299.99)
    {
        return 15.00 ;
    }
    else
    {
        return 30.00;
    }
}