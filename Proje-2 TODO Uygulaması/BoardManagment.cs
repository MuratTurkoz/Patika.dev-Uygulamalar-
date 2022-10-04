using System;

namespace Proje_2_TODO_Uygulaması
{
    public class BoardManagement : IBoardManagement
    {
        CardManagment cm = new CardManagment();
        int val = 0;
        public void GetBoardList()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} Line", i == (int)BoardType.DONE ? BoardType.DONE : i == (int)BoardType.INPROGRESS ? BoardType.INPROGRESS : BoardType.TODO);
                Console.WriteLine("************************");
                foreach (Card item in cm.GetCards())
                {
                    if ((int)item.BoardType == i)
                    {
                        Console.WriteLine(item.Title);
                        Console.WriteLine(item.Content);
                        Console.WriteLine(item.Person.Name);
                        Console.WriteLine(item.Size);
                        Console.WriteLine(" ");
                    }
                }
            }
            ShowBoard();
        }
        public void ShowBoard()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            int.TryParse(Console.ReadLine(), out int res);
            val = res;
            ToWork(res);
        }
        public void AddCardToBoard()
        {
            Console.WriteLine("Başlık Giriniz :");
            string title = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz :");
            string content = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int size = int.Parse(Console.ReadLine());
            if (0 < size || size < 6)
            {
                Console.WriteLine("Kişi Seçiniz :");
                string personName = Console.ReadLine();
                Person person = cm.FindPerson(personName);
                if (cm.FindPerson(personName) != null)
                {
                    cm.Create(new Card { Title = title, Content = content, Size = (Size)size, Person = person });
                    ShowBoard();
                }
                else
                {
                    Console.WriteLine("Hatalı isim girdiniz.Kartlar ancak takımdan birine atanabilir.");
                    Console.WriteLine("Lütfen bir seçim yapınız.");
                    Console.WriteLine("Eklemeyi sonlandırmak için : (1)");
                    Console.WriteLine("Yeniden denemek için : (2)");
                    int.TryParse(Console.ReadLine(), out int res);
                    if (res == 1 || res == 2)
                    {
                        if (res == 1)
                            ShowBoard();
                        else
                            AddCardToBoard();
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı büyüklük girdiniz.");
                Console.WriteLine("Lütfen bir seçim yapınız.");
                Console.WriteLine("Eklemeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için : (2)");
                int.TryParse(Console.ReadLine(), out int res);
                if (res == 1 || res == 2)
                {
                    if (res == 1)
                        ShowBoard();
                    else
                        AddCardToBoard();
                }
            }
        }

        public void DeleteCardToBoard()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string val = Console.ReadLine();
            int res = cm.Delete(val);
            if (res == 1)
            {
                Console.WriteLine("Silme başarılı...");
                ShowBoard();
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine(" Yeniden denemek için : (2)");
                int.TryParse(Console.ReadLine(), out int res1);
                if (res1 == 1)
                {
                    ShowBoard();
                }
                else if (res1 == 2)
                {

                    DeleteCardToBoard();
                }
            }



        }
        public void MoveCardToBoard()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string val = Console.ReadLine();

            if (cm.FindCard(val) != null)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");


                Console.WriteLine("Başlık :{0}", cm.FindCard(val).Title);
                Console.WriteLine("İçerik :{0}", cm.FindCard(val).Content);
                Console.WriteLine("Atanan Kişi :{0}", cm.FindCard(val).Person.Name);
                Console.WriteLine("Büyüklük :{0}", cm.FindCard(val).Size);
                Console.WriteLine("Line :{0}", cm.FindCard(val).BoardType);
                Console.WriteLine(" ");
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int.TryParse(Console.ReadLine(), out int res2);
                if (res2 == 1 || res2 == 2 || res2 == 3)
                {
                    cm.Update(cm.FindCard(val), res2);
                    Console.WriteLine("Kart taşıma başarılı...");
                    GetBoardList();
                }
                else
                {
                    Console.WriteLine("Yanlış bir değer girdiniz.Tekrar deneyin");
                }


            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Taşımayı sonlandırmak için : (1)");
                Console.WriteLine(" Yeniden denemek için : (2)");
                int.TryParse(Console.ReadLine(), out int res1);
                if (res1 == 1)
                {
                    ShowBoard();
                }
                else if (res1 == 2)
                {

                    MoveCardToBoard();
                }
            }
        }
        public void ToWork(int res)
        {
            switch (res)
            {
                case 1:
                    GetBoardList();
                    break;
                case 2:
                    AddCardToBoard();
                    break;
                case 3:
                    DeleteCardToBoard();
                    break;
                case 4:
                    MoveCardToBoard();
                    break;
            }
        }
    }
}