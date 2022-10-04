using System;

namespace Ders_14_String_Metotlar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());


            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddSeconds(2));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddMinutes(2));
            Console.WriteLine(DateTime.Now.AddMilliseconds(2));

            //Datetime Format
            Console.WriteLine("---------------------");
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));
            //Math Kütüphanesi
            Console.WriteLine("---------------------");
            Console.WriteLine(Math.Abs(-24));
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Tan(30));
            //
            Console.WriteLine("---------------------");
            Console.WriteLine(Math.Ceiling(22.3));//Yukarı yuvarlar 23
            Console.WriteLine(Math.Round(22.3));//En yakın tamsayıya yuvarlar
            Console.WriteLine(Math.Floor(22.7));//Aşağıya yuvarlar 22
                                                //
            Console.WriteLine("---------------------");
            Console.WriteLine(Math.Min(2, 6));
            Console.WriteLine(Math.Max(2, 6));
            //
            Console.WriteLine("---------------------");
            Console.WriteLine(Math.Pow(3, 4));//81
            Console.WriteLine(Math.Sqrt(9));//3
            Console.WriteLine(Math.Log(10));
            Console.WriteLine(Math.Exp(10));// e ye göre log
            Console.WriteLine(Math.Log10(10));//10 tabanında


        }
    }
}
