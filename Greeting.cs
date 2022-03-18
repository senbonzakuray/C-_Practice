using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    internal class Program
    {
        static void Main()
        {
            DateTime CurrentTime = DateTime.Now;
            int CurrentHour = CurrentTime.Hour;
            int Morning = 6;
            int Afternoon = 13;
            int Evening = 18;
            int Night = 23;

            if (CurrentHour >= Morning && CurrentHour < Afternoon)
            {
                Console.WriteLine("Good Morning!");
            }
            if (CurrentHour >= Afternoon && CurrentHour < Evening)
            {
                Console.WriteLine("Good Afternoon!");
            }
            if (CurrentHour >= Evening && CurrentHour < Night)
            {
                Console.WriteLine("Good Evening!");
            }
            if (CurrentHour >= Night || CurrentHour < Morning)
            {
                Console.WriteLine("Good Night!");
            }
        }
    }
}
