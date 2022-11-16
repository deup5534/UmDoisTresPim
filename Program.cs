Console.Clear();
Console.WriteLine("Vamos lá... cite os números inteiros entre 1 e 40 inclusive, substituindo os múltiplos de 4 pela palavra pim. ");
Console.ReadKey();
Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
for (int numero = 1; numero <=40; numero++)
Console.Write(numero % 4 == 0 ? "pim\n" : $"{numero,2} ");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("você ganhou... 50 reais!!! hihiiii");
Console.ResetColor();

