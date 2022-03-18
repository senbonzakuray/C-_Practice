using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber > 3)
            {
                Console.WriteLine("It's outside of the range!");
            }
            if (correctNumber < 1 )
            {
                Console.WriteLine("It's outside of the range!");
            }
            if (correctNumber > guessedNumber)
            {
                Console.WriteLine("Too Low!");
            }
            if (correctNumber < guessedNumber)
            {
                Console.WriteLine("Too High!");
            }
            if (correctNumber == guessedNumber)
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}
