using System;
using System.Collections.Generic;
using System.Linq;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Racer> racers = Console.ReadLine().Split(' ').Select(x => new Racer(x)).ToList();
            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();            
            foreach (var r in racers)
            {
                for (int i = 0; i < zones.Length; i++)
                {
                    if (r.HasFuel)
                    {
                        if (checkpoints.Contains(i))
                            r.Fuel += zones[i];
                        else
                            r.Fuel -= zones[i];
                        r.Zone = i;
                    }
                    if (r.Fuel <= 0)
                        r.HasFuel = false;
                }
                if (r.HasFuel)
                    Console.WriteLine($"{r.Name} - fuel left {r.Fuel:F2}");
                else
                    Console.WriteLine($"{r.Name} - reached {r.Zone}");
            }
        }
        class Racer
        {
            public Racer(string name)
            {
                Name = name;
                Fuel = name[0];
                Zone = -1;
                HasFuel = true;
            }
            public string Name { get; set; }
            public double Fuel { get; set; }
            public int Zone { get; set; }
            public bool HasFuel { get; set; }
        }
    }
}
