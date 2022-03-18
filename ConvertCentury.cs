using System;
using System.Numerics;


namespace _02ConvertCentry
{
    internal class Program
    {
        static void Main()
        {
            int cent = int.Parse(Console.ReadLine());
            int year = cent * 100;
            double day = year * 365.24;
            double hour = day * 24;
            double minute = hour * 60;
            double second = minute * 60;
            double microsecond = second * 1000;
            double nanosecond = microsecond * 1000;
            Console.WriteLine($"{cent} centuries = {year} years = {day} days = {hour} hours = {minute} minutes = {second} seconds = {microsecond} milliseconds = {nanosecond} nanoseconds ");
        }
    }
}


