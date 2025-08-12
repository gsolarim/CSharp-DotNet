// Programa que calcula el área de un rectángulo

// Declaración de variables
// int LadoA;
// int LadoB;
// int Resultado;
double LadoA;
double LadoB;
double Resultado;

Console.WriteLine("Calcula el Área de un Rectángulo!!");
Console.WriteLine("Ingrese el valor del Lado A:");
// LadoA = Convert.ToInt32(Console.ReadLine());
LadoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del Lado B:");
// LadoB = Convert.ToInt32(Console.ReadLine());
LadoB = Convert.ToDouble(Console.ReadLine());

Resultado = LadoA * LadoB;
Console.WriteLine("El Lado A es: " + LadoA + "\nEl Lado B es: " + LadoB + "\nEl Resultado es: " + Resultado);