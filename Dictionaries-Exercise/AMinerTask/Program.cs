using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var miner = new Dictionary<string, int>();
            string input, resource = "";
            do
            {
                input = Console.ReadLine();
                if (resource == "")
                    resource = input;
                else
                {
                    if (!miner.ContainsKey(resource))
                        miner.Add(resource, int.Parse(input));
                    else
                        miner[resource] += int.Parse(input);
                    resource = "";
                }
            } while (input != "stop");
            foreach (var res in miner)
            {
                Console.WriteLine(res.Key + " -> " + res.Value);
            }
        }
    }
}
