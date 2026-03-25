int precio = -1;
string metodo = "";
int bandera = 0;
int cantidad = 0;
string tarjeta;
while (precio <= 0)
{
    Console.WriteLine("Ingrese el precio del producto..");
    precio = int.Parse(Console.ReadLine());
    if (precio <= 0)
    {
        Console.WriteLine("Error el precio tiene que ser mayor a 0");
    }
}
while (bandera == 0)
{
    Console.WriteLine("Ingrese el metodo de pago...");
    metodo = Console.ReadLine().ToLower().Trim();
    if (metodo == "tarjeta" || metodo == "efectivo")
    {
        bandera = 1;
    }
    else
    {
        Console.WriteLine("Ingrese un metodo de pago existente (efectivo / tarjeta)");
    }
}
if (metodo == "tarjeta")
{

    while (cantidad != 16)
    {
        Console.WriteLine("Ingrese su tarjeta:");
        tarjeta = Console.ReadLine();
        cantidad = tarjeta.Length;
        if (cantidad == 16)
        {

            Console.WriteLine($"El valor a pagar es de {precio * 1.10} ");

        }
        else
        {
            Console.WriteLine("El numero de la tarjeta es incorrecto.");
        }
    }
}
else
{
    Console.WriteLine($"El monto a pagar es de {precio}");
}