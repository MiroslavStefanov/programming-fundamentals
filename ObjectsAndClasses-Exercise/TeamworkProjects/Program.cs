using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var teams = new Dictionary<string, Team>();
            var creators = new HashSet<string>();
            var members = new HashSet<string>();
            for(int i = 0; i<num; i++)
            {
                var data = Console.ReadLine().Split('-');                
                if (!teams.ContainsKey(data[1]))
                {
                    if(!creators.Contains(data[0]))
                    {
                        teams.Add(data[1], new Team() { Name = data[1], Creator = data[0] });
                        creators.Add(data[0]);
                        members.Add(data[0]);
                        Console.WriteLine($"Team {data[1]} has been created by {data[0]}!");
                    }
                    else
                        Console.WriteLine($"{data[0]} cannot create another team!");
                }
                else
                    Console.WriteLine($"Team {data[1]} was already created!");                
            }
            string line;
            string[] sep = { "->" };
            while(true)
            {
                line = Console.ReadLine();
                if (line == "end of assignment")
                    break;
                var data = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                if(teams.ContainsKey(data[1]))
                {
                    if(!members.Contains(data[0]))
                    {
                        teams[data[1]].Members.Add(data[0]);
                        members.Add(data[0]);
                    }
                    else
                        Console.WriteLine($"Member {data[0]} cannot join team {data[1]}!");
                }
                else
                    Console.WriteLine($"Team {data[1]} does not exist!");
            }
            teams = teams.OrderByDescending(x => x.Value.Members.Count).ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);
            bool bPrintDisbandMessage = true;
            foreach (var t in teams)
            {
                if(t.Value.Members.Count > 0)
                {
                    Console.WriteLine(t.Key);
                    Console.WriteLine("- " + t.Value.Creator);
                    t.Value.Members = t.Value.Members.OrderBy(x => x).ToList();
                    foreach (var mem in t.Value.Members)
                        Console.WriteLine("-- " + mem);
                }
                else
                {
                    if(bPrintDisbandMessage)
                    {
                        Console.WriteLine("Teams to disband:");
                        bPrintDisbandMessage = false;
                    }
                    Console.WriteLine(t.Key);
                }
            }
            if (bPrintDisbandMessage)
                Console.WriteLine("Teams to disband:");
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members = new List<string>();
    }
}
