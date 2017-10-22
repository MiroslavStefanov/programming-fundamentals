using System;
using System.Collections.Generic;
using System.Linq;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new SortedDictionary<string, Student>();
            string line;
            while(true)
            {
                line = Console.ReadLine();
                if (line == "end of dates")
                    break;
                var name = line.Split(' ');
                bool bContains = group.ContainsKey(name[0]);
                Student cur = bContains? group[name[0]] : new Student() { Name = name[0] };
                if (name.Length > 1)
                {
                    var attends = name[1].Split(',');                    
                    for (int i = 0; i < attends.Length; i++)
                        cur.Attends.Add(DateTime.ParseExact(attends[i], "dd/MM/yyyy", null));
                }  
                if(!bContains)
                    group.Add(name[0], cur);
            }
            while(true)
            {
                line = Console.ReadLine();
                if (line == "end of comments")
                    break;
                var name = line.Split('-');
                if(group.ContainsKey(name[0]))
                    group[name[0]].Comments.Add(name[1]);
            }
            foreach (var st in group)
            {
                Console.WriteLine(st.Key);
                Console.WriteLine("Comments:");
                foreach (var cm in st.Value.Comments)
                    Console.WriteLine("- " + cm);
                st.Value.Attends = st.Value.Attends.OrderBy(x=>x).ToList();
                Console.WriteLine("Dates attended:");
                foreach (var date in st.Value.Attends)
                    Console.WriteLine("-- " + date.ToString("dd/MM/yyyy"));
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments = new List<string>();
        public List<DateTime> Attends = new List<DateTime>();
    }
}
