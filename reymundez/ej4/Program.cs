// 4) Pedir dos números al usuario por teclado y decir qué número es el mayor. () 
Console.WriteLine("Ingresar el 1 numero: ");
string num1 = Console.ReadLine();
Console.WriteLine("Ingresar el 2 numero: ");
string num2 = Console.ReadLine();

if (num1 == "" || num2 == "" || num1 == null || num2 == null)
{
    Console.WriteLine("Error: No se ingresaron ambos números.");

}
else if (int.Parse(num1) > int.Parse(num2))
{
    Console.WriteLine($"El numero mayor es: {num1}");
}
else if (int.Parse(num2) > int.Parse(num1))
{
    Console.WriteLine($"El numero mayor es: {num2}");
}
else
{
    Console.WriteLine("Los numeros son iguales");
}
