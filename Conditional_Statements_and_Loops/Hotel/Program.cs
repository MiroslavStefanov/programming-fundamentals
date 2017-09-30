using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string sMonth = Console.ReadLine();
            int nNumNights = int.Parse(Console.ReadLine());

            decimal mStudioPrice = 0M, mDoublePrice = 0M, mSuitePrice = 0M;

            switch(sMonth)
            {
                case "May":
                case "October":
                    mStudioPrice = 50M;
                    mDoublePrice = 65M;
                    mSuitePrice  = 75M;
                    break;
                case "June":
                case "September":
                    mStudioPrice = 60M;
                    mDoublePrice = 72M;
                    mSuitePrice = 82M;
                    break;
                case "July":
                case "August":
                case "December":
                    mStudioPrice = 68M;
                    mDoublePrice = 77M;
                    mSuitePrice = 89M;
                    break;
            }

            mStudioPrice *= nNumNights;
            mDoublePrice *= nNumNights;
            mSuitePrice *= nNumNights;

            if (nNumNights > 14 && (sMonth == "June" || sMonth == "September"))
                mDoublePrice *= 0.9M;
            if (nNumNights > 14 && (sMonth == "July" || sMonth == "August" || sMonth == "December"))
                mSuitePrice *= 0.85M;
            if (nNumNights > 7 && (sMonth == "September" || sMonth == "October"))
                mStudioPrice *= (nNumNights - 1M) / nNumNights;
            if (nNumNights > 7 && (sMonth == "May" || sMonth == "October"))
                mStudioPrice *= 0.95M;
            Console.WriteLine($"Studio: {mStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {mDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {mSuitePrice:F2} lv.");
        }
    }
}
