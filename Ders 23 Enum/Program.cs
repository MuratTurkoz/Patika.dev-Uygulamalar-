﻿using System;

namespace Ders_23_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);
            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.normal)
            {
                Console.WriteLine("Bekleyelim");
            }
            else if (sicaklik >= (int)HavaDurumu.sicak)
            {
                Console.WriteLine("Çok Sıcak");
            }

        }
    }
    enum Gunler
    {
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    };
    enum HavaDurumu
    {
        soguk = 5,
        normal = 20,
        sicak = 25,
        coksicak = 30,
    }
}
