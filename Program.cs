using System.Threading.Tasks.Sources;

int numero;
 
 Console.ForegroundColor = ConsoleColor.DarkMagenta;
 Console.Write("Digite um número: ");
 numero = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkRed;
if (numero < 0 )
{
Console.WriteLine("Voce digitou um numero negativo.");
}
Console.ResetColor();

