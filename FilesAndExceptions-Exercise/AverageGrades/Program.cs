using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = File.ReadAllLines("tests/input02.txt");
            int num = int.Parse(s[0]);
            var students = new SortedDictionary<string, List<Student>>();
            for (int i = 0; i < num; i++)
            {
                Student st = Student.Read(s[i+1]);
                if (!students.ContainsKey(st.Name))
                    students.Add(st.Name, new List<Student>());
                students[st.Name].Add(st);
            }
            foreach (var student in students)
            {
                var grades = student.Value.OrderByDescending(x => x.Average).ToArray();
                double a;
                for (int i = 0; i < grades.Length; i++)
                {
                    a = grades[i].Average;
                    if (a >= 5.0)
                        File.AppendAllText("tests/output02.txt", $"{student.Key} -> {a:F2}" + Environment.NewLine);
                }
            }
        }
    }
    public class Student
    {
        private string name;
        private List<double> grades = new List<double>();

        public string Name
        {
            get { return name; }
            //set { name = value; }
        }
        public double Average
        {
            get { return grades.Average(); }
        }
        public static Student Read(string input)
        {
            Student ret = new Student();
            var data = input.Split();
            ret.name = data[0];
            for (int i = 1; i < data.Length; i++)
                ret.grades.Add(double.Parse(data[i]));
            return ret;
        }
    }
}

