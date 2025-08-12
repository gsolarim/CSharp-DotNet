//bool valor1 = true;
//bool valor2 = true;
//bool valor3 = false;

var (valor1, valor2, valor3) = (true, true, false);

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultAndOr);

bool resultNot = !valor1;
Console.WriteLine(resultNot);

bool resultXor = (valor1 ^ valor2) ^ valor3;
Console.WriteLine(resultXor);

// Operadores Lógicos en C#
/*
&&
||
!
^
*/