using System;

namespace _05._Puppy_Care
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodKilos = int.Parse(Console.ReadLine())*1000;
            string input= Console.ReadLine();
            int gramEatenFood = 0;
            int sumEatenFood=0;
            while (input!= "Adopted")
            {
                gramEatenFood = int.Parse(input);
                sumEatenFood+= gramEatenFood;
                input = Console.ReadLine();
            }
            if (input== "Adopted")
            {
                if (sumEatenFood<=foodKilos)
                {
                    Console.WriteLine($"Food is enough! Leftovers: {foodKilos-sumEatenFood} grams.");
                }
                else
                {
                    Console.WriteLine($"Food is not enough. You need {sumEatenFood-foodKilos} grams more.");
                }
            }
        }
    }
}
