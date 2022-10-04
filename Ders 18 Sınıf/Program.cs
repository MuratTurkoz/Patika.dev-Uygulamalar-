using System;

namespace Ders_18_Sınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          class SinifAdi
          {
            [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
            [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
            {
             //Metot Gövdesi
            }
          }
           */
            //Erişim Belirleyiciler
            /*
             public : Her yerden erişilebilir.

             private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

             internal : Sadece bulunduğu proje içerisinden erişilebilir

             protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
            */
            Calisan calisan = new Calisan()
            {
                Ad = "Murat",
                Soyad = "XX",
                No = 7,
                Departman = "Bilgi işlem"
            };
            calisan.calisanBilgileri();
            Console.WriteLine("*********");
            Calisan calisan2 = new Calisan()
            {
                Ad = "burcin",
                Soyad = "XX",
                No = 9,
                Departman = "Bilgi işlem"
            };
            calisan2.calisanBilgileri();

        }
    }
    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

        public void calisanBilgileri()
        {
            Console.WriteLine("Çalışan Ad:{0} Soyad:{1} No:{2} Departman:{3}:", Ad, Soyad, No, Departman);
        }
    }
}
