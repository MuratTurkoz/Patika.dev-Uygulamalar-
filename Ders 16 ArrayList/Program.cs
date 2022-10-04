using System;
using System.Collections;
using System.Collections.Generic;

namespace Ders_16_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("Ali");
            array.Add(12);
            array.Add('a');
            array.Add(5.12f);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********");
            //AddRange
            List<string> color = new List<string>() { "blue", "dark", "purple" };
            int[] numbers = { 5, 3, 45, 78 };
            array.AddRange(color);
            array.AddRange(numbers);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********");
            //Sort
            // array.Sort();//hata tip uyuşmazlığı
            Console.WriteLine("********");
            //BinarySearch
            //Önce sırakalam yapılması gerek
            array.Clear();
            array.AddRange(numbers);
            array.Sort();
            Console.WriteLine(array.BinarySearch(3));
            Console.WriteLine("********");
            //Reverse aynalama yapar
            array.Reverse();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


        }
    }
}
