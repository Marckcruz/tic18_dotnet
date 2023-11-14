using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Números divisíveis por 3 ou 4 entre 0 e 30:");

        for (int i = 0; i <= 30; i++)
        {
            if (i % 3 == 0 || i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine(); 
    }
}
