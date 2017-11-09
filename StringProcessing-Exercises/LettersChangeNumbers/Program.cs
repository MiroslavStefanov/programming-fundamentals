using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (var str in input)
            {
                sum += Proceed(str);
            }
            Console.WriteLine($"{sum:F2}");
        }
        static double Proceed(string str)
        {
            double ans = 0;

            char c0, c1;
            int num;
            ParseInput(str, out c0, out c1, out num);

            if (c0 == Char.ToLower(c0))
                ans = (double)num * (c0 - 'a' + 1);
            else
                ans = (double)num / (c0 - 'A' + 1);

            if (c1 == Char.ToLower(c1))
                ans += (double)(c1 - 'a' + 1);
            else
                ans -= (double)(c1 - 'A' + 1);

            return ans;
        }
        static void ParseInput(string str, out char c0, out char c1, out int num)
        {
            c0 = str[0];
            c1 = str[str.Length - 1];
            num = int.Parse(str.Substring(1, str.Length - 2));
        }
        /*static void FindNumber(string str, out int start, out int len)
        {
            bool bStarted = false;
            start = -1;
            len = 0;
            for(int i = 0; i<str.Length; i++)
            {
                if(!bStarted)
                    if(str[i] >= '0' && str[i] <= '9')
                    {
                        start = i;
                        bStarted = true;
                    }
                if (bStarted)
                    if (str[i] >= '0' && str[i] <= '9')
                        len++;
                    else
                        break;
            }
        }*/
    }
}
