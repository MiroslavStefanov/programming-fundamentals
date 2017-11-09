using System;
using System.Collections.Generic;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ans = true;
            var dict = new Dictionary<char, char>();
            var input = Console.ReadLine().Split();
            int l = input[0].Length > input[1].Length ? 0 : 1;
            int s = l == 0 ? 1 : 0;
            for (int i = 0; i < input[l].Length; i++)
            {
                if (!dict.ContainsKey(input[l][i]))
                    if (input[s].Length <= i)
                    {
                        ans = false;
                        break;
                    }
                    else if (!dict.ContainsValue(input[s][i]))
                        dict.Add(input[l][i], input[s][i]);
                    else
                    {
                        ans = false;
                        break;
                    }                        
                else if (input[s].Length > i)
                {
                    if (dict[input[l][i]] != input[s][i])
                    {
                        ans = false;
                        break;
                    }
                }

            }
            if (ans)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
