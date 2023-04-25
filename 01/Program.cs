using System;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int videoCardPrice = int.Parse(Console.ReadLine());
            int transitionPrice = int.Parse(Console.ReadLine());
            double elecricityPerDay = double.Parse(Console.ReadLine());
            double profitPerDay = double.Parse(Console.ReadLine());

            double totalExpences = 13 * videoCardPrice + 13 * transitionPrice + 1000;
            double profitSum = profitPerDay - elecricityPerDay;
            double win = 13 * profitSum;
            double days = totalExpences / win;
            Console.WriteLine(totalExpences);
            Console.WriteLine($"{Math.Ceiling(days)}");
        }
    }
}
