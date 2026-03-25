int numero_uno;
int numero_dos;
Console.WriteLine("Ingresa el primer numero.");
numero_uno = int.TryParse(Console.ReadLine());
Console.WriteLine("Ingresa el segundo numero.");
numero_dos = int.TryParse(Console.ReadLine());

if (numero_uno > numero_dos)
{
    Console.WriteLine($"El numero mas grande es {numero_uno}");
}
else if (numero_uno = numero_dos)
{
    Console.WriteLine($"Los dos numeros son iguales");
}
else
{
    Console.WriteLine($"El numero mas grande es {numero_dos}");
}
