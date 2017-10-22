using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            var towns = new List<Town>();
            var groups = new List<Group>();
            string line;
            while(true)
            {
                line = Console.ReadLine();
                if (line == "End")
                    break;
                if(line.Contains("=>"))
                {
                    string[] sep = { " => " };
                    var data = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);                    
                    towns.Add(new Town() { Name = data[0].Trim(), SeatsCount = int.Parse(data[1].Trim().Substring(0, 1)) });
                }
                else
                {
                    string[] sep = { "|" };
                    var data = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        Student st = new Student()
                        {
                            Name = data[0].Trim(),
                            Email = data[1].Trim(),
                            RegistrationDate = DateTime.ParseExact(data[2], "d-MMM-yyyy", new CultureInfo("en-US"), DateTimeStyles.AllowWhiteSpaces)
                        };
                        towns.Last().Students.Add(st);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
            towns = towns.OrderBy(x => x.Name).ToList();
            foreach (var t in towns)
            {
                t.Students = t.Students.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email).ToList();
                int studentCount = t.Students.Count();
                int indx = 0;
                while(studentCount > 0)
                {
                    Group g = new Group() { Town = t };
                    g.Students.AddRange(t.Students.GetRange(indx, Math.Min(t.SeatsCount, studentCount)));
                    studentCount -= t.SeatsCount;
                    indx += t.SeatsCount;
                    groups.Add(g);
                }
            }
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (var g in groups)
            {
                Console.WriteLine(g.Town.Name + " => " + String.Join(", ", g.Students.Select(x=>x.Email)));
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students = new List<Student>();
    }
    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students = new List<Student>();
    }
}
