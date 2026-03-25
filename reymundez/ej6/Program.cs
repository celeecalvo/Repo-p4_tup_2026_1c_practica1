// 6) Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o 
// tarjeta) si la forma de pago es mediante tarjeta, pedir el número de la misma(inventado),
// verificar que sean 16 dígitos e informar el valor a pagar con un 10% de recargo. 
// (uso de condicionales) 

Console.Write("Ingrese el precio del producto (valor positivo): ");
string? entradaPrecio = Console.ReadLine();

if (entradaPrecio == "" || entradaPrecio == null)
{
    Console.WriteLine("Error: No se ingresó un precio.");
}
else
{
    float precio = float.Parse(entradaPrecio);

    if (precio <= 0)
    {
        Console.WriteLine("Error: El precio debe ser mayor a cero.");
    }
    else
    {

        Console.Write("Seleccione forma de pago (efectivo / tarjeta): ");
        string metodoPago = Console.ReadLine();

        if (metodoPago == "" || metodoPago == null)
        {
            Console.WriteLine("Error: No se seleccionó un método de pago.");
        }
        else
        {
            metodoPago = metodoPago.ToLower();

            if (metodoPago == "tarjeta")
            {
                Console.Write("Ingrese su número de tarjeta: ");
                string numeroTarjeta = Console.ReadLine();

                Console.WriteLine("\n--- Resumen de Compra ---");
                Console.WriteLine($"Precio: ${precio}");
                Console.WriteLine($"Pago: Tarjeta N° {numeroTarjeta}");
            }
            else if (metodoPago == "efectivo")
            {
                Console.WriteLine("\n--- Resumen de Compra ---");
                Console.WriteLine($"Precio: ${precio}");
                Console.WriteLine("Pago: Efectivo");
            }
            else
            {
                Console.WriteLine("Opción de pago no válida.");
            }
        }
    }
}
