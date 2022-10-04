using System;
using System.Collections.Generic;

namespace Ders_17_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            List<List<int>> num = new List<List<int>>();
            for (int i = 0; i < num.Count; i++)
            {
                for (int j = 0; j < num.Count; j++)
                {
                    val += num[i][j];
                }
            }
            // Console.WriteLine("Hello World!");
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(1, "ali");
            users.Add(5, "saffet");
            users.Add(8, "veli");
            Console.WriteLine(users[1]);

            foreach (KeyValuePair<int, string> item in users)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("************");

            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************");
            //Count
            Console.WriteLine(users.Count);
            //Contains
            Console.WriteLine(users.ContainsKey(5));
            Console.WriteLine(users.ContainsValue("5"));
            Console.WriteLine("************");

            //Remove
            users.Remove(5);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************");

            //Keys
            foreach (var item in users.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************");

            //Values
            foreach (var item in users.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
