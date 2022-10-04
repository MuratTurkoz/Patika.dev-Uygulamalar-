using System;

namespace Ders_22_Struct_Yapı__Kavramı
{
    /* Struct'lar yani yapılar sınıflara çok benzerler. Struct ile yapıp sınıf ile yapamayacağız bir işlem yoktur diyebiliriz. Peki o halde struct yani yapılara neden ihtiyaç duyulur?
     Class kullanmanızı gerektirecek kadar komplex olmayan yapılarınız varsa ve verileri kapsüllemek işinizi görecekse yapıları tercih edebilirsiniz.
     Yapıların özellikleri:
     Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
     Diğer struct ya da sınıflardan kalıtım almazlar.
     Interface'lerden kalıtım alabilirler.
     new anahtar sözcüğü ile nesneleri yaratılabilir.
     Sınıflar gibi metot, property ve field'lardan oluşurlar.
     Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
     Static üye barındırabilirler.*/

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ShortEdge = 3;
            rectangle.LongEdge = 4;
            Console.WriteLine("Dikdörtgen Alan Hesabı: {0}", rectangle.Area());
            Rectangle_Struct rectangle_Struct = new Rectangle_Struct();

            rectangle_Struct.ShortEdge = 3;
            rectangle_Struct.LongEdge = 4;
            Console.WriteLine("Dikdörtgen Alan Hesabı: {0}", rectangle_Struct.Area());
            // Rectangle_Struct rectangle_Struct2;
            // rectangle_Struct2.ShortEdge = 3;
            // rectangle_Struct2.LongEdge = 4;
            // Console.WriteLine("Dikdörtgen Alan Hesabı: {0}", rectangle_Struct2.Area());

        }
    }
    class Rectangle//referans tipi
    {
        public int ShortEdge { get; set; }
        public int LongEdge { get; set; }
        public long Area()
        {
            return this.ShortEdge * LongEdge;
        }
        Rectangle()
        {
            ShortEdge = 3;
            LongEdge = 4;
        }
    }
    struct Rectangle_Struct : Ia//değer tipi
    {
        public int ShortEdge { get; set; }
        public int LongEdge { get; set; }
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public long Area()
        {
            return this.ShortEdge * LongEdge;
        }
        // public Rectangle(int shortEdge, int longEdge)
        // {
        //     ShortEdge = shortEdge;
        //     LongEdge = longEdge;
        // }
    }
    interface Ia
    {
        public int MyProperty { get; set; }
    }
}
