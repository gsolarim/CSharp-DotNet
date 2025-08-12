int totalJugador = 25;
int totalDealer = 15;
string message = "";

// Blackjack, Juntar 21 pidiendo cartas o en caso de tener menos
// de 21 igual tener mayor puntuación que el dealer

if (totalJugador > totalDealer && totalJugador < 22) 
{
    message = "Venciste al dealer, felicidades!";
}
else if (totalJugador >= 22)
{
    message = "Perdiste vs el dealer, te pasaste de 21.";
}
else if (totalJugador <= totalDealer) 
{
    message = "Perdiste vs el dealer, lo siento.";
}
else 
{
    message = "Condición no válida";
}
Console.WriteLine(message);