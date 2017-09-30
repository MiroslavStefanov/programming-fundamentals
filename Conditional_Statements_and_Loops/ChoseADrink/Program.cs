using System;

namespace ChoseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string job = Console.ReadLine();
            string drink;
            switch(job)
            {
                case "Athlete":
                    drink = "Water"; break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee"; break;
                case "SoftUni Student":
                    drink = "Beer"; break;
                default: drink = "Tea"; break;
            }
            Console.WriteLine(drink);
        }
    }
}
