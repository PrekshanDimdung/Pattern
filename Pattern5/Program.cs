using System;
class Pattern5
{
    static void Main()
    {
        int n = 8;
        for (int i = 1; i <= n; i++)
        {
            for(int k = 1; k<=i; k++)
                Console.Write("*");
            
            Console.Write(" ");
            for(int k = 1; k<=i; k++)
             Console.Write("*");
            
            Console.WriteLine(" ");
        }
    }
}
