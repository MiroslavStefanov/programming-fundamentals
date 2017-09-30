using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumCalories = 0;
            int[] pnCalories = { 500, 150, 600, 50 };

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                switch(Console.ReadLine().ToLower())
                {
                    case "cheese":
                        nNumCalories += pnCalories[0]; break;
                    case "tomato sauce":
                        nNumCalories += pnCalories[1]; break;
                    case "salami":
                        nNumCalories += pnCalories[2]; break;
                    case "pepper":
                        nNumCalories += pnCalories[3]; break;
                }
            }

            Console.WriteLine($"Total calories: {nNumCalories}");
        }
    }
}
