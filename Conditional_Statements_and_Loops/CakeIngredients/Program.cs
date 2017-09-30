using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string sIngredient;
            int nNumIngredients = 0;
            while(true)
            {
                sIngredient = Console.ReadLine();
                if (sIngredient == "Bake!")
                    break;
                nNumIngredients++;
                Console.WriteLine($"Adding ingredient {sIngredient}.");
            }
            Console.WriteLine($"Preparing cake with {nNumIngredients} ingredients.");
        }
    }
}
