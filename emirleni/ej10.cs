List<int> pares = new List<int>();
List<int> multiplo3 = new List<int>();

for (int i = 1; i < 101; i++)
{
    if (i % 2 == 0)
        pares.Add(i);

    if (i % 3 == 0)
        multiplo3.Add(i);
}

Console.WriteLine("Lista de numeros pares:");
foreach (var num in pares)
{
    Console.WriteLine(num);
}

Console.WriteLine("\nLista de multiplos de 3:");
foreach (var num in multiplo3)
{
    Console.WriteLine(num);
}
Console.ReadKey();
