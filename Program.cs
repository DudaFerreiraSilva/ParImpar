int numero;
string paridade;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite um número: ");
Console.ResetColor();

numero = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkYellow;
paridade = (numero % 2) == 0 ? "par" : "ímpar";

Console.WriteLine($"{numero} é {paridade}");
Console.ResetColor();