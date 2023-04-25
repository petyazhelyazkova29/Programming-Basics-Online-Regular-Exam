using System;
using System.Transactions;

namespace _02._AND_Processors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plannedCount = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int timeToWork = days * 8 * workers;
            double actualCoint = timeToWork / 3; //Math.Floor

            if (Math.Floor(actualCoint)>=plannedCount)
            {
                Console.WriteLine($"Profit: -> {(Math.Floor(actualCoint)-plannedCount)*110.10:f2} BGN");
            }
            else
            {
                Console.WriteLine($"Losses: -> {(plannedCount - Math.Floor(actualCoint))*110.10:f2} BGN");
            }
        }
    }
}
