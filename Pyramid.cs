using System;


namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            {
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 0; j <= size - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j < i * 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


            }
        }
    }
}
