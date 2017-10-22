using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            for(int i = 0; i<num; i++)
            {
                var input = Console.ReadLine().Split('-');
                products[input[0]] = decimal.Parse(input[1]);
            }
            var customers = new List<Customer>();
            string line = "";
            while(true)
            {
                line = Console.ReadLine();
                if (line == "end of clients")
                    break;
                var name = line.Split('-');
                var product = name[1].Split(',');
                if(products.ContainsKey(product[0]))
                {
                    int indx = Contains(customers, name[0]);
                    Customer cur = indx == -1 ? new Customer() { Name = name[0], Bill = 0m } : customers[indx];
                    if (cur.Cart.ContainsKey(product[0]))
                        cur.Cart[product[0]] += int.Parse(product[1]);
                    else
                        cur.Cart.Add(product[0], int.Parse(product[1]));
                    if(indx==-1)
                        customers.Add(cur);
                }
            }
            customers = customers.OrderBy(x => x.Name).ToList();
            decimal total = 0m;
            foreach (var c in customers)
            {
                Console.WriteLine(c.Name);
                foreach (var p in c.Cart)
                {
                    c.Bill += p.Value * (products[p.Key]);
                    Console.WriteLine($"-- {p.Key} - {p.Value}");
                }
                Console.WriteLine($"Bill: {c.Bill:F2}");
                total += c.Bill;
            }
            Console.WriteLine($"Total bill: {total:F2}");
        }
        public static int Contains(List<Customer> list, string name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name)
                    return i;
            }
            return -1;
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public decimal Bill { get; set; }
        public Dictionary<string, int> Cart = new Dictionary<string, int>();       
    }
}
