Console.Clear();
    Console.WriteLine("Super maquina de descobrir qual é o maior valor- Versão 1.5 de luxo");
 Console.WriteLine();

    Console.WriteLine("insira três numeros em uma sequencia aleatoria:");
            Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Numero I:");
            int n1 = Convert.ToInt32(Console.ReadLine()); Thread.Sleep(2000);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Numero II:");
            int n2 = Convert.ToInt32(Console.ReadLine()); Thread.Sleep(2000);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Numero III:");
            int n3 = Convert.ToInt32(Console.ReadLine()); Thread.Sleep(2000);
            Console.ResetColor();

 Console.WriteLine();

int Maiornumero;

if (n1 > n2 && n1 > n3)
        {
            Maiornumero = n1;
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"O maior numero é o I, no caso, o numero {Maiornumero}");
                Console.ResetColor();
        }
        else if (n2 > n1 && n2 > n3)
        {
            Maiornumero = n2;
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"O maior numero é o II, no caso, o numero {Maiornumero}");
                Console.ResetColor();
        }
        else
        {
            Maiornumero = n3;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"O maior numero é o III, no caso, o numero {Maiornumero}");
                Console.ResetColor();
        }



