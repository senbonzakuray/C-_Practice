using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting24
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 0;i <= 24; i+=1 )
            {
                Console.WriteLine(i +" ");
            }
            for (int i = 0; i <= 24; i += 2)
            {
                Console.WriteLine(i+" ");
            }
            for (int i = 0; i <= 24; i += 3)
            {
                Console.WriteLine(i+" ");
            }
            for (int i = 0; i <= 24; i += 4)
            {
                Console.WriteLine(i+" ");
            }
        }
    }
}
