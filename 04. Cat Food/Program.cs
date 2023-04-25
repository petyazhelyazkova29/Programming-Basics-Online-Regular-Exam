using System;

namespace _04._Cat_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int catsCount = int.Parse(Console.ReadLine());
            double eatenFood = 0;
            int smallCatsCount = 0;
            int bidCatsCount = 0;
            int giantCatsCount = 0;
            double food = 0;

            for (int i = 1; i <= catsCount; i++)
            {
                eatenFood = double.Parse(Console.ReadLine());
                if (eatenFood<200)
                {
                    smallCatsCount++;
                    food += eatenFood;
                }
                else if (eatenFood<300)
                {
                    bidCatsCount++;
                    food += eatenFood;
                }
                else
                {
                    giantCatsCount++;
                    food += eatenFood;
                }
            }
            double priceFood = (food / 1000) * 12.45;
            Console.WriteLine($"Group 1: {smallCatsCount} cats.");
            Console.WriteLine($"Group 2: {bidCatsCount} cats.");
            Console.WriteLine($"Group 3: {giantCatsCount} cats.");
            Console.WriteLine($"Price for food per day: {priceFood:f2} lv.");
        }
    }
}
