using System;
using System.Runtime.ConstrainedExecution;

namespace _06._Gold_Mine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int locationsCount = int.Parse(Console.ReadLine());         
            double expectedAvrPerDay = 0;
            int days = 0;
            double actualGoldPerDay = 0;
            double actualGoldSum = 0;
            for (int i = 1; i <= locationsCount; i++)
            {
                expectedAvrPerDay = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                actualGoldSum = 0;
                for (int day = 1; day <=days; day++)
                {
                    actualGoldPerDay = double.Parse(Console.ReadLine());
                    actualGoldSum += actualGoldPerDay;
                }
                double actulaAvrGold = actualGoldSum / days;
                if (actulaAvrGold>=expectedAvrPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {actulaAvrGold:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedAvrPerDay-actulaAvrGold:f2} gold.");
                }
            }

        }
    }
}
