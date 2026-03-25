Console.WriteLine("Ingresa el nombre del dia...");
string dia;
dia = Console.ReadLine();
switch (dia.ToLower().Trim())
{
    case "lunes":
    case "martes":
    case "miercoles":
    case "jueves":
    case "viernes":
        Console.WriteLine("No es finde semana");
        break;
    case "sabado":
        Console.WriteLine("Es finde semana");
        break;
    case "domingo":
        Console.WriteLine("Es finde semana");
        break;
    default:
        Console.WriteLine("Ese dia no existe.");
        break;
}
