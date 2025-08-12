Console.WriteLine("Ricardo Pérez ID!");
int altura = 168;
int edad = 89;
string nombre = "Ricardo Pérez";
string informacion = "Nació en Hidalgo, es estudiante de Gastronomía y Astronomía";
var hobby = "deportista";

string tarjetaDeIdentificacion = $"La información de {nombre} es la siguiente" +
    $"\nSu edad es {edad} años\nSu altura es de {altura} cms" +
    $"\nInformación relevante -> {informacion}\nAdemás, su hobby es {hobby}";

Console.WriteLine(tarjetaDeIdentificacion);