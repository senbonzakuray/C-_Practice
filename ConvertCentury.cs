using System;
using System.Numerics;


namespace _02ConvertCentry
{
    internal class Program
    {
        static void Main()
        {
            uint century = uint.Parse(Console.ReadLine());
            uint year = century * 100;
            uint day = year * 365 +24* century;
            uint hour = day * 24;
            uint minute = hour * 60;
            uint second = minute * 60;
            ulong millisecond = Convert.ToUInt64(second) * 1000;
            ulong microsecond = millisecond * 1000;
            ulong nanosecond = microsecond * 1000;
            Console.WriteLine($"{century} centuries = {year} years = {day} days = {hour} hours = {minute} minutes = {second} seconds = {millisecond} milliseconds = {microsecond} microseconds= {nanosecond} nanoseconds ");
        }
    }
}