using System;

namespace ChoseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal waterPrice = 0.7M, coffeePrice = 1.0M, beerPrice = 1.7M, teaPrice = 1.2M;
            decimal ans;
            string job = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            string drink;
            switch (job)
            {
                case "Athlete":
                    drink = "Water";
                    ans = waterPrice * quantity; break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    ans = coffeePrice * quantity; break;
                case "SoftUni Student":
                    drink = "Beer";
                    ans = beerPrice * quantity; break;
                default: drink = "Tea";
                    ans = teaPrice * quantity; break;
            }
            Console.WriteLine($"The {job} has to pay {ans:F2}.");
        }
    }
}

