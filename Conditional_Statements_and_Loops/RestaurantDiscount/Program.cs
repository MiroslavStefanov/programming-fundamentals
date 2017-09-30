using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pdDisconts = { 0.95, 0.9, 0.85 };
            decimal[] pmHallPrices = { 2500M, 5000M, 7500M };
            decimal[] pmPackagePrices = { 500M, 750M, 1000M };

            int nNumPeople = int.Parse(Console.ReadLine());
            string sPackage = Console.ReadLine();

            string sHallName = "";
            decimal mPricePerPerson;

            int nHallIndx = -1;
            if (nNumPeople <= 50)
            {
                nHallIndx = 0;
                sHallName = "Small Hall";
            }
            else if (nNumPeople <= 100)
            {
                nHallIndx = 1;
                sHallName = "Terrace";
            }
            else if (nNumPeople <= 120)
            {
                nHallIndx = 2;
                sHallName = "Great Hall";
            }

            if(nHallIndx == -1)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            int nPackageIndx = -1;
            switch(sPackage)
            {
                case "Normal": nPackageIndx = 0;  break;
                case "Gold": nPackageIndx = 1; break;
                case "Platinum": nPackageIndx = 2; break;
            }

            mPricePerPerson = ((decimal)pdDisconts[nPackageIndx] * (pmHallPrices[nHallIndx] + pmPackagePrices[nPackageIndx]))/nNumPeople;
            Console.WriteLine($"We can offer you the {sHallName}\nThe price per person is {mPricePerPerson:F2}$");
        }
    }
}
