using System;

class Prog
{
    static void Main()
    {
        Console.WriteLine("Os primeiros números da série de Fibonacci até ultrapassar 100:");

        int limite = 100;
        int fib1 = 0, fib2 = 1, fib3;

        while (fib1 <= limite)
        {
            Console.WriteLine(fib1);
            fib3 = fib1 + fib2;
            fib1 = fib2;
            fib2 = fib3;
        }

        Console.ReadLine(); // Aguarda fib1 entrada do usuário antes de fechar o console
    }
}

