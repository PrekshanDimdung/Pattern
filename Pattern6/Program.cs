using System;

class Program
{
    static void Main()
    {
        int width = 7;   // *******  → 7 stars
        int height = 6;  // middle rows

        // Top row
        for (int i = 0; i < width; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        // Middle rows
        for (int i = 0; i < height; i++)
        {
            Console.Write("*");         // left star

            for (int j = 0; j < width - 2; j++)
            {
                Console.Write(" ");    // spaces
            }

            Console.Write("*");         // right star
            Console.WriteLine();
        }

        // Bottom row
        for (int i = 0; i < width; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
