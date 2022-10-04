using System;

namespace Ders_13_String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string vals = "Dersimiz C# hoş geldiniz";
            string vals2 = "dersimiz C# ";


            //Lenght dizinin uzunluğunu verir
            Console.WriteLine(vals.Length);
            //toUppper ToLower harfleri büyütür küçültür
            Console.WriteLine(vals.ToUpper());
            Console.WriteLine(vals.ToLower());
            //Concat Birleştime yapar
            Console.WriteLine(string.Concat(vals, "Merhaba!"));
            //Compare CompareTo Kıyaslama
            Console.WriteLine(vals.CompareTo(vals2));
            //Compare
            Console.WriteLine(string.Compare(vals, vals2, true));
            Console.WriteLine(string.Compare(vals, vals2, false));
            //Contains
            Console.WriteLine(vals.Contains(vals2));
            //StartsWith ve EndsWith
            Console.WriteLine(vals.StartsWith("Dersimiz"));
            Console.WriteLine(vals.EndsWith("Merhaba!"));
            //IndexOf
            Console.WriteLine(vals.IndexOf("C"));
            Console.WriteLine(vals.IndexOf("w"));
            //Insert istediğin indexten başlayarak terim ekleme yapar
            Console.WriteLine(vals.Insert(0, "Wow "));
            //LastIndexOf 
            Console.WriteLine(vals.IndexOf("i"));
            //Padright PadLeft
            Console.WriteLine(vals.PadLeft(30, '%'));
            Console.WriteLine(vals + vals.PadLeft(30, '%'));
            Console.WriteLine(vals.PadRight(30, '*'));
            Console.WriteLine(vals + vals.PadRight(30, '*'));
            //Remove
            Console.WriteLine(vals.Remove(5, 3));
            Console.WriteLine(vals.Remove(0, 1));
            //Replace karakter değiştir
            Console.WriteLine(vals.Replace('C', '&'));
            //Split keser
            Console.WriteLine(vals.Split(' ')[1]);
            //SubString 
            Console.WriteLine(vals.Substring(4, 6));
        }
    }
}
