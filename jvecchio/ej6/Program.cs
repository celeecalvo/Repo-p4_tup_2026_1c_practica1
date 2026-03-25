Console.Write("Ingrese el precio del producto: ");
double precio = double.Parse(Console.ReadLine()!);

if (precio <= 0)
{
    Console.WriteLine("El precio debe ser positivo");
    return;
}


Console.Write("Ingrese forma de pago (efectivo/tarjeta): ");
string formaPago = Console.ReadLine()!.Trim();

if (formaPago.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
{

    Console.Write("Ingrese número de tarjeta (16 dígitos): ");
    string tarjeta = Console.ReadLine()!.Trim();

    if (tarjeta.Length == 16)
    {
        double total = precio * 1.10;
        Console.WriteLine($"Pago con tarjeta. Total con recargo: {total}");
    }
    else
    {
        Console.WriteLine("Número de tarjeta inválido");
    }
}
else if (formaPago.Equals("efectivo", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"Pago en efectivo. Total: {precio}");
}
else
{
    Console.WriteLine("Forma de pago inválida");
}
