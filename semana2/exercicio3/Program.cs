using System;

class Progr
{
    static void Main()
    {
        int nivel = 8;

        Console.WriteLine("Imprimindo a tabela até o nível " + nivel + ":\n");

        for (int i = 1; i <= nivel; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i * j + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine(); // Aguarda a entrada do usuário antes de fechar o console
    }
}

