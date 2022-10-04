using System;

namespace Proje_2_TODO_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            // Console.WriteLine("*******************************************");
            // Console.WriteLine("(1) Board Listelemek");
            // Console.WriteLine("(2) Board'a Kart Eklemek");
            // Console.WriteLine("(3) Board'dan Kart Silmek");
            // Console.WriteLine("(4) Kart Taşımak");
            // int.TryParse(Console.ReadLine(), out int res);
            BoardManagement bm = new BoardManagement();
            bm.ShowBoard();
            // Database dt = new Database();

            // foreach (Person item in dt.GetListPerson())
            // {

            //     Console.WriteLine(item.Name + " " + item.Team);
            // }
        }
    }
}
