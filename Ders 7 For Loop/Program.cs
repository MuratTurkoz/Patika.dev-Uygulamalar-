// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Ekranda girilen sayıya kadar olan tek sayılarını ekrana yazdır
Console.WriteLine("Lütfen bir sayı giriniz");
int sayac = int.Parse(Console.ReadLine());
for (int i = 0; i < sayac; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}
//1 ile 100 arasıdaki tek ve çift sayıların kendi içinde toplamlarını ekran yazdır
int ciftToplam = 0;
int tekToplam = 0;
for (int i = 0; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;

    }
}
Console.WriteLine("Çift Toplam:{0}", ciftToplam);
Console.WriteLine("Tek Toplam:{0}", tekToplam);
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Hi");
        continue;
    }
    Console.WriteLine(i);
}
for (; ; )
{
    Console.WriteLine("Sonsuz Döngü");
}
