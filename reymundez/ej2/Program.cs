//2) Pedir por parámetro un nombre de persona y el nombre de una ciudad (no hace falta que 
// sean reales o comprobarlos) y mostrar por consola el siguiente mensaje “Hola ” <nombre> 
// ” bienvenido a ” <ciudad>”. Utilizar Interpolación. 

Console.WriteLine("Ingresar su nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingresar el nombre de una ciudad:");
string ciudad = Console.ReadLine();
Console.WriteLine($"Hola {nombre}, bienvenido a {ciudad}.");