Console.WriteLine("================================================");
Console.WriteLine("             Controle de chamados               ");
Console.WriteLine("              First In, First Out               ");
Console.WriteLine("================================================");

Queue<string> chamadosFila = new Queue<string>();

chamadosFila.Enqueue("Impressora não funciona");
chamadosFila.Enqueue("Computador lento");
chamadosFila.Enqueue("Problema no e-mail");

string chamadoAtual = chamadosFila.Dequeue();

Console.WriteLine($"\nChamado em atendimento: {chamadoAtual}");
Console.WriteLine("\n================================================");

Console.WriteLine("\nChamados na fila:");

foreach (var chamado in chamadosFila)
{
    Console.WriteLine($" - {chamado}");
}

Console.WriteLine("\n================================================");

