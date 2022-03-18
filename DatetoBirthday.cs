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
            DateTime currenttime = DateTime.Now;
            DateTime birthdate = Convert.ToDateTime("1997-10-10");
            Console.WriteLine(currenttime - birthdate);
        }
    }
}
