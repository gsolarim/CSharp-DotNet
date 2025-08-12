int totalJugador = 25;
int totalDealer = 15;
string message = "";
string switchControl = "menu"; // 21, gato

// Blackjack, Juntar 21 pidiendo cartas o en caso de tener menos
// de 21 igual tener mayor puntuación que el dealer

switch (switchControl)
{
    case "menu":
        Console.WriteLine("Welcome al C A S I N O");
        Console.WriteLine("Escriba '21' para jugar al 21");
        switchControl = Console.ReadLine();
        break;
    case "21":
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
        break;
    default:
        Console.WriteLine("Valor ingresado no válido en el C A S I N O");
        break;
}