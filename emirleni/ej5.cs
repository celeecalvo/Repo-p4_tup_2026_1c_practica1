Console.WriteLine("ingresa el nombre de un día de la semana");
Console.Write("-> ");
string dayName = Console.ReadLine().Trim();

Console.WriteLine();

if (String.Equals(dayName, "lunes", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("es día de semana.");
else if (String.Equals(dayName, "martes", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("es día de semana.");
else if (String.Equals(dayName, "miércoles", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("es día de semana.");
else if (String.Equals(dayName, "jueves", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("es día de semana.");
else if (String.Equals(dayName, "viernes", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("es día de semana.");
else if (String.Equals(dayName, "sábado", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("ya es fin de semana.");
else if (String.Equals(dayName, "domingo", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("ya es fin de semana.");
else
    Console.WriteLine("El nombre de día que ingresaste no es correcto");

Console.ReadKey();
