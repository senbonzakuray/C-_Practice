using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] newArr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
                Console.WriteLine($"The {i}th element of array is {array[i]}");
                Console.WriteLine($"The {i}th element of copied array is {newArr[i]}");
                Console.ReadLine();
            }
        }
    }
}
