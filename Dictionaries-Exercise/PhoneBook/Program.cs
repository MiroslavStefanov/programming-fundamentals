using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();
            string input = "";
            while(input != "END")
            {
                input = Console.ReadLine();
                var data = input.Split();
                switch (input[0])
                {
                    case 'A':
                        {                            
                            if (!phoneBook.ContainsKey(data[1]))
                                phoneBook.Add(data[1], data[2]);
                            else
                                phoneBook[data[1]] = data[2];
                        }
                        break;
                    case 'S':
                        {
                            if (!phoneBook.ContainsKey(data[1]))
                                Console.WriteLine($"Contact {data[1]} does not exist.");
                            else
                                Console.WriteLine($"{data[1]} -> {phoneBook[data[1]]}");
                        }
                        break;
                    default:
                        {
                            if(input == "ListAll")
                                foreach (var phone in phoneBook)
                                {
                                    Console.WriteLine($"{phone.Key} -> {phone.Value}");
                                }
                        }
                        break;
                }
            }
        }
    }
}
