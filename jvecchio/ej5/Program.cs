Console.Write("Ingrese un día de la semana: ");
string dia = Console.ReadLine()!;


dia = dia.Trim();

if (dia.Equals("sabado", StringComparison.OrdinalIgnoreCase) ||
    dia.Equals("domingo", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Es fin de semana");
}
else if (dia.Equals("lunes", StringComparison.OrdinalIgnoreCase) ||
         dia.Equals("martes", StringComparison.OrdinalIgnoreCase) ||
         dia.Equals("miercoles", StringComparison.OrdinalIgnoreCase) ||
         dia.Equals("jueves", StringComparison.OrdinalIgnoreCase) ||
         dia.Equals("viernes", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("No es fin de semana");
}
else
{
    Console.WriteLine("Día inválido");
}
