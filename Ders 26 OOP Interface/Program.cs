using System;

namespace Ders_26_OOP_Interface
{
    class Program
    {
        /*
        Interface yani arayüzler nesneye dayalı programlamanın önemli özelliklerinden biridir. Sınıfların içermesi gereken metotların imzalarının yer aldığı, özelliklerin tanımlandığı bir taslak gibi düşünebiliriz.
        Kesin belirlenmiş bir kural olmamasıyla beraber interface isimleri "I" ile başlar. I ile başlayan bir isim gördüğümüzde kolaylıkla bunun bir arayüz olduğunu anlarız. Dolayısıyla standartlara bağlı kalmakta fayda var.
        Interface içerisindeki property'lere bir değer ataması yapılmaz, metotların ise gövdesi yazılmaz. Sadece implemente eden sınıfın ne iş yaptığının bir arayüzüdür interface'ler. Ve bir sınıf aynı anda birden fazla arayüzden kalıtım alabilir.
        Peki interface'lere neden ihtiyaç duyarız? Kalıtım alan sınıfın sorumluluğunun çerçevesinin çizilmesine yardımcı olur diyebilir. Aynı sorumluluğu başka bir yoğurt yiyiş tarzıyla yapması gereken bir sınıf geldiğinde aynı interface den kalıtım alır ama yapacağı işi farklı şekilde yapar.
        */
        static void Main(string[] args)
        {
            SmsLogger sl = new SmsLogger();
            sl.WriteLog();
            DatabaseLogger dl = new DatabaseLogger();
            dl.WriteLog();
            LogManager logM = new LogManager(new DatabaseLogger());
            logM.WriteLog();


        }
    }
}
