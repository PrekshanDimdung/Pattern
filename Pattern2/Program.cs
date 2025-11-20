using System;

class Pattern2
{
    static void Main()
    {
        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
