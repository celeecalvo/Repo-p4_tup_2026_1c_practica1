
Console.WriteLine("ingresa el precio del producto:");
Console.Write("-> ");
double precioProducto = double.Parse(Console.ReadLine());

if (precioProducto <= 0)
    Console.WriteLine("El precio debería ser mayor que cero");
else
{
    Console.WriteLine("pagas con efectivo o tarjeta?");
    Console.Write("-> ");
    string formaPago = Console.ReadLine().Trim();

    if (String.Equals(formaPago, "efectivo", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine();
        Console.WriteLine("tenes un 10% de descuento");
        Console.WriteLine($"Precio final: {(precioProducto * 0.9):C}");
    }
    else if (String.Equals(formaPago, "tarjeta", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine();
        Console.WriteLine("ingresa el número de tu tarjeta:");
        Console.Write("-> ");
        string numeroTarjeta = Console.ReadLine().Trim();

        if (numeroTarjeta.Length != 16)
            Console.WriteLine("Numero de tarjeta inválido");
        else
        {
            Console.WriteLine();
            Console.WriteLine("hay un 10% de recargo.");
            Console.WriteLine($"Precio final: {(precioProducto * 1.1):C}");
        }
    }
}

Console.ReadKey();
