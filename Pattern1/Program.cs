using System;
class Pattern1
{
    static void Main()
    {
        for (int i = 1; i <= 8; i++)
        {
            for (int j = i; j <= 8; j++)
            {
                Console.Write("*");   
            }
            Console.WriteLine();      
        }
    }
}
