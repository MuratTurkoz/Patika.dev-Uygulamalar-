using System;
using System.Collections.Generic;

namespace Ders_15_Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //List<T> class
            //System.Collections.Generic
            //T=> object türünde
            List<int> numberList = new List<int>() { 5, 3, 6, 9, 12, 78, 87, 983, 21 };
            List<string> colorList = new List<string>() { "white", "pink", "red", "blue" };


            foreach (int item in numberList)
            {
                Console.WriteLine(item);
            }
            foreach (string item in colorList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********");
            numberList.ForEach(x => Console.WriteLine(x));
            colorList.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("***********");

            //Listeden eleman çıkarma

            numberList.Remove(983);
            colorList.Remove("white");
            //Index ile sayı çıkarma
            numberList.RemoveAt(5);
            colorList.RemoveAt(2);
            numberList.ForEach(x => Console.WriteLine(x));
            colorList.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("***********");
            //Sayı listesinden arama
            if (numberList.Contains(5))
                Console.WriteLine("Yes");
            //Eleman ile indexe erişme

            Console.WriteLine(numberList.BinarySearch(21));

            Console.WriteLine("***********");
            //Diziyi Liste çevirme

            string[] animals = { "dog", "cat", "monkey", "bird" };
            List<string> animalList = new List<string>(animals);
            animalList.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("***********");

            //Listeyi  temizleme
            animalList.Clear();

            //Liste içinde nesne tutma
            List<Users> userList = new List<Users>() { new Users { Name = "Murat", SurName = "Türköz", Old = 35 }, new Users { Name = "Burçin", SurName = "Türköz", Old = 35 } };

            userList.ForEach(x => Console.WriteLine(x.Name + " " + x.SurName + " " + x.Old));

        }
    }
    class Users
    {
        private string name;
        private string surName;
        private int old;

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public int Old { get => old; set => old = value; }
    }
}
