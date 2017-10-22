using System;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            int[] holydays = { 1, 1, 3, 3, 1, 5, 6, 5, 24, 5, 6, 9, 22, 9, 1, 11, 24, 12, 25, 12, 26, 12 };
            int count = 0;
            for(DateTime day = startDate; day.CompareTo(endDate)<=0; day = day.AddDays(1.0))
            {
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                    continue;
                bool isHolyday = false;
                for(int i = 0; i<holydays.Length/2; i++)
                {
                    if(day.Day == holydays[2*i] && day.Month == holydays[2*i+1])
                    {
                        isHolyday = true;
                        break;
                    }
                }
                if (!isHolyday) count++;
            }
            Console.WriteLine(count);
        }
    }
}
