using System;

namespace ConsoleApp1
{
    public enum DayOfWeek
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek currentDay = DayOfWeek.Monday;

            Console.WriteLine(currentDay);
        }
    }
}
