Console.WriteLine("============================================");
Console.WriteLine("            Fila de atendimento"            );
Console.WriteLine("============================================");

Queue<string> fila = new Queue<string>();

fila.Enqueue("Maria");
fila.Enqueue("João");
fila.Enqueue("Pedro");

string pacienteAtual = fila.Dequeue();

Console.WriteLine($"\nPaciente em atendimento: {pacienteAtual}");
Console.WriteLine("\n============================================");
Console.WriteLine("\nFila de espera:");
foreach (var paciente in fila)
{
    Console.WriteLine($" - {paciente}");
}

Console.WriteLine("\n============================================");