Console.WriteLine("ingresa un número entero");
Console.Write("-> ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("ingresa otro número entero diferente");
Console.Write("-> ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine();

if (firstNumber != secondNumber)
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine($"El mayor de los dos números que ingresaste es el {firstNumber}");
    }
    else
    {
        Console.WriteLine($"El mayor de los dos números que ingresaste es el {secondNumber}");
    }
}
else
{
    Console.WriteLine("ingresaste dos números iguales");
}

Console.ReadKey();