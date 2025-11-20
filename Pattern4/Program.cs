using System;

class Program
{
    static void Main()
    {
        int n = 7; //number of rows

        for (int i = 1; i <= n; i++)
        {
            //spaces
            for (int s = 1; s <= n - i; s++)
            {
                Console.Write(" ");
            }

            //stars
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
