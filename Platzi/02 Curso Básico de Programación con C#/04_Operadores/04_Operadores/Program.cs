// Programa que calcula el área de un rectángulo

// Declaración de variables
// int LadoA;
// int LadoB;
// int Resultado;
var LadoA = 0d;
var LadoB = 0d;
var Resultado = 0d;

Console.WriteLine("Calcula el Área de un Rectángulo!!");
Console.WriteLine("Ingrese el valor del Lado A:");
// LadoA = Convert.ToInt32(Console.ReadLine());
LadoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del Lado B:");
// LadoB = Convert.ToInt32(Console.ReadLine());
LadoB = Convert.ToDouble(Console.ReadLine());

// Operaciones
LadoA++;
LadoA = LadoA + 1;
LadoA--;

Resultado = (LadoA * LadoB) / 2;
Console.WriteLine("El Lado A es: " + LadoA + "\nEl Lado B es: " + LadoB + "\nEl Resultado es: " + Resultado);

var Modulo = 0d;
Modulo = LadoA % LadoB;
Console.WriteLine("El Módulo de A y B es: " + Modulo);