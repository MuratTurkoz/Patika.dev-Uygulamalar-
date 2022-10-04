using System;
using System.Collections.Generic;
using System.Globalization;

namespace Proje_1
{
    public class KisiManager : IKisiManager
    {
        KisiDatabase kisiDatabase = new KisiDatabase();

        //Kisi Oluşturma...
        public void Create()
        {
            Console.WriteLine(" Lütfen isim giriniz             : ");
            string name = Console.ReadLine();
            Console.WriteLine(" Lütfen soyisim giriniz          :");
            string surName = Console.ReadLine();
            Console.WriteLine(" Lütfen telefon numarası giriniz :");
            string telNo = Console.ReadLine();
            kisiDatabase.Create(new Kisi { Name = name, Surname = surName, TelNo = telNo });
            ConsoleMenu();
        }
        //Kisi Silme...
        public void Delete()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string val = Console.ReadLine();
            List<Kisi> kisiler = FindOfKisi(val);
            if (kisiler.Count > 0)
            {
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y / n)", kisiler[0].Name);
                string cevap = Console.ReadLine();
                if (cevap == "y")
                {
                    kisiDatabase.Remove(kisiler[0]);


                    ConsoleMenu();
                }
                else if (cevap == "n")
                {
                    ConsoleMenu();
                }
                else
                {
                    Console.WriteLine("Lütfen doğru bir harfe basın");
                    Delete();

                }

            }
            else
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string val2 = Console.ReadLine();
                if (val2 == "1")
                {
                    ConsoleMenu();
                }
                else if (val2 == "2")
                {
                    Delete();
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz...");
                    Delete();
                }
                // Console.WriteLine();
            }
            // kisiler.Remove(kisiler[0]);
        }
        //Kisi Güncelleme...
        public void Update()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string val = Console.ReadLine();
            List<Kisi> kisiler = FindOfKisi(val);


            if (kisiler.Count > 0)
            {
                Console.WriteLine("Lütfen yeni telefon numarasını giriniz:");
                string telNo = Console.ReadLine();
                Console.WriteLine("{0} isimli kişi rehberden güncelleniyor, onaylıyor musunuz ?(y / n)", kisiler[0].Name);
                string cevap = Console.ReadLine();
                if (cevap == "y")
                {
                    kisiDatabase.Update(kisiler[0], telNo);
                    ConsoleMenu();
                }
                else if (cevap == "n")
                {
                    ConsoleMenu();
                }
                else
                {
                    Console.WriteLine("Lütfen doğru bir harfe basın");
                    Update();

                }

            }
            else
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string val2 = Console.ReadLine();
                if (val2 == "1")
                {
                    ConsoleMenu();
                }
                else if (val2 == "2")
                {
                    Update();
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz...");
                    Update();
                }
            }
        }
        //Tüm kişileri Getir
        public void GetKisiler()
        {
            foreach (var item in kisiDatabase.List())
            {
                Console.WriteLine("İsim: {0}", item.Name);
                Console.WriteLine("Soyİsim: {0}", item.Surname);
                Console.WriteLine("Telefon Numarası: {0}", item.TelNo);
                Console.WriteLine("-");
            }
            ConsoleMenu();
        }

        //Kisiye göre Kisileri Getirme
        public void GetKisiler(List<Kisi> kisiler)
        {
            if (kisiler.Count == 0)
            {
                Console.WriteLine("Eşleşme sağlanamadı.Lütfen tekrar deneyin.");
                GetMenu5();
            }
            else
            {
                foreach (Kisi item in kisiler)
                {

                    Console.WriteLine("İsim: {0}", item.Name);
                    Console.WriteLine("Soyİsim: {0}", item.Surname);
                    Console.WriteLine("Telefon Numarası: {0}", item.TelNo);
                    Console.WriteLine("-");
                    ConsoleMenu();
                }
            }


        }

        //Menu 5

        public void GetMenu5()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int.TryParse(Console.ReadLine(), out int result);
            Console.WriteLine("Lütfen bir arama yapmak isteğiniz kelimeyi giriniz.");
            string val = Console.ReadLine();

            if (result == 1)
            {
                GetNameByKisiler(val);
            }
            else if (result == 2)
            {
                GetTelByKisiler(val);
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli bir sayı giriniz.");
                ConsoleMenu();
            }
        }
        //ConsoleMenu
        public void ConsoleMenu()
        {
            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int.TryParse(Console.ReadLine(), out int result);

            if (0 < result && result < 6)
            {
                if (result == 4)
                {
                    Console.WriteLine("Telefon Rehberi");
                    Console.WriteLine("**********************************************");
                    GetKisiler();
                }
                else if (result == 5)
                {
                    GetMenu5();
                }
                else if (result == 1)
                {
                    Create();
                }
                else if (result == 2)
                {
                    Delete();
                }
                else if (result == 3)
                {
                    Update();
                }

            }
            else
            {
                Console.WriteLine("Lütfen İstenilen bir değer giriniz");
                Console.WriteLine("********************");
                ConsoleMenu();
            }
        }
        //Telefona Göre Kişi Getirme
        public void GetTelByKisiler(string telNo)
        {
            GetKisiler(FindOfKisi(telNo));

        }
        //İsme Göre Kişi Getirme

        public void GetNameByKisiler(string nameOrSurName)
        {

            GetKisiler(FindOfKisi(nameOrSurName));
        }
        //Kişi Bulma

        public List<Kisi> FindOfKisi(string vals)
        {
            List<Kisi> rehber = new List<Kisi>();
            foreach (var item in kisiDatabase.List())
            {
                if (item.Name.ToLower() == vals.ToLower() || item.Surname.ToLower() == vals.ToLower() || item.TelNo == vals)
                {
                    rehber.Add(item);
                }
            }
            return rehber;
        }

    }
}