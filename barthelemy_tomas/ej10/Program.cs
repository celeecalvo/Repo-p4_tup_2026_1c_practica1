List<int> pares = new List<int>();
List<int> impares = new List<int>();

for (int i = 0; i < 101; i++)
{
    if (i % 2 == 0)
    {
        pares.Add(i);
    }
    else
    {
        impares.Add(i);
    }
}

Console.WriteLine("Lista de pares:");
foreach (int par in pares)
{
    Console.Write($"{par}-");
}
Console.WriteLine("\nLista de impares:");
foreach (int impar in impares)
{
    Console.Write($"{impar}-");
}