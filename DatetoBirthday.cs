using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateToBirthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currenttime = DateTime.Today;
            DateTime birthdate = Convert.ToDateTime("1997-10-10");
            double diff = (currenttime - birthdate).TotalDays;
            Console.WriteLine($"I lived {diff} days.");
            int NextAnniversary = Convert.ToInt32(10000 - diff % 10000);
            Console.WriteLine($"There are {NextAnniversary} days to next Anniversary.");
        }
    }
}
