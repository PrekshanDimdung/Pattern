using System;

class Pattern3
{
    static void Main()
    {
        int n = 7; // height of upper part (middle longest line)

        // Upper part
        for (int i = 1; i <= n; i++)
        {
            for (int s = 1; s <= n - i; s++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Lower part
        for (int i = n - 1; i >= 1; i--)
        {
            for (int s = 1; s <= n - i; s++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
