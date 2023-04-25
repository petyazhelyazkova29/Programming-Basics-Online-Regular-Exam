using System;

namespace _03._Football_Souvenirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;

            if (team == "Argentina")
            {
                if (souvenir== "flags")
                {
                    price = 3.25;
                }
                else if (souvenir== "caps")
                {
                    price = 7.20;
                }
                else if (souvenir== "posters")
                {
                    price = 5.10;
                }
                else if (souvenir== "stickers")
                {
                    price = 1.25;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team== "Brazil")
            {
                if (souvenir == "flags")
                {
                    price = 4.20;
                }
                else if (souvenir == "caps")
                {
                    price = 8.50;
                }
                else if (souvenir == "posters")
                {
                    price = 5.35;
                }
                else if (souvenir == "stickers")
                {
                    price = 1.20;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team== "Croatia")
            {
                if (souvenir == "flags")
                {
                    price = 2.75;
                }
                else if (souvenir == "caps")
                {
                    price =6.90;
                }
                else if (souvenir == "posters")
                {
                    price = 4.95;
                }
                else if (souvenir == "stickers")
                {
                    price = 1.10;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team== "Denmark")
            {
                if (souvenir == "flags")
                {
                    price = 3.10;
                }
                else if (souvenir == "caps")
                {
                    price = 6.50;
                }
                else if (souvenir == "posters")
                {
                    price = 4.80;
                }
                else if (souvenir == "stickers")
                {
                    price = 0.90;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }
            double sum = price * count;
            if (team== "Argentina" || team== "Brazil" || team == "Croatia" || team== "Denmark")
            {
                if (souvenir== "flags" || souvenir == "caps" || souvenir == "posters" || souvenir == "stickers")
                {
                    Console.WriteLine($"Pepi bought {count} {souvenir} of {team} for {sum:f2} lv.");
                }
            }
        }
    }
}
