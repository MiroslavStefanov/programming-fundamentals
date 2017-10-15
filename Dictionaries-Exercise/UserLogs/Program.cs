using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var logs = new SortedDictionary<string, Dictionary<string, uint>>();
            string input;
            while(true)
            {
                input = Console.ReadLine();
                if (input == "end")
                    break;
                var elems = input.Split();
                string IP = elems[0].Substring(3), user = elems[2].Substring(5);
                if(logs.ContainsKey(user))
                {
                    if (logs[user].ContainsKey(IP))
                        logs[user][IP]++;
                    else
                        logs[user].Add(IP, 1);
                }
                else
                {
                    logs.Add(user, new Dictionary<string, uint>());
                    logs[user].Add(IP, 1);
                }
            }
            foreach (var user in logs)
            {
                Console.WriteLine(user.Key + ": ");
                foreach (var ip in user.Value)
                {
                    Console.Write(ip.Key + " => " + ip.Value);
                    if (ip.Key != user.Value.Last().Key)
                        Console.Write(", ");
                    else
                        Console.WriteLine(".");
                }
            }
        }
    }
}
