using System;
using System.Collections.Generic;
using System.IO;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var miner = new Dictionary<string, int>();
            string input, resource = "";
            string[] s = File.ReadAllLines("tests/input01.txt");
            uint i = 0;
            do
            {
                input = s[i];
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
                i++;
            } while (input != "stop");
            foreach (var res in miner)
            {
                File.AppendAllText("tests/output01.txt", res.Key + " -> " + res.Value + Environment.NewLine);
            }
        }
    }
}
