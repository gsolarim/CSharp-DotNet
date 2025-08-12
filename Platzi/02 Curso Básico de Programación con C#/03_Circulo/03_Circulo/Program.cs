Console.WriteLine("Bienvenido, calculemos círculos!");
// pi * radio * radio
var radio = 0d;
var resultado = 0d;

const double Pi = 3.14;

const double SiempreSeEscribeAsi = 200.0d;

Console.WriteLine("Ingrese el valor del radio: ");
radio = Convert.ToDouble(Console.ReadLine());

// resultado = Math.PI * radio * radio;
resultado = Pi * radio * radio;

Console.WriteLine("El área del círculo es de: " + resultado);