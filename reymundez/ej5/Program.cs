// 5) Pedir el nombre del día al usuario y decirle si es fin de semana o no.  En caso de error, 
// indicarlo. Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” 
//  / “   lunes" y debería funcionar. TIP para investigar: Trim() y StringComparison.OrdinalIgnoreCase 

Console.WriteLine("Ingrese el nombre del día:");
string dia = Console.ReadLine()!.Trim();

if (dia == null || dia == "")
{
    Console.WriteLine("Error: No se ingresó el nombre del día.");
}
else if (dia.Equals("Sábado", StringComparison.OrdinalIgnoreCase) || dia.Equals("Domingo", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Es fin de semana.");
}
else if (dia.Equals("Lunes", StringComparison.OrdinalIgnoreCase) || dia.Equals("Martes", StringComparison.OrdinalIgnoreCase)
|| dia.Equals("Miércoles", StringComparison.OrdinalIgnoreCase) || dia.Equals("Jueves", StringComparison.OrdinalIgnoreCase)
|| dia.Equals("Viernes", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("No es fin de semana.");
}
else
{
    Console.WriteLine("Error: Nombre de día no válido.");
}