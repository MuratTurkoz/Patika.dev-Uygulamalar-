// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


try
{
    //kod blogu
    int a = int.Parse(Console.ReadLine());

    int b = int.Parse(Console.ReadLine());

    int c = a+b;

    Console.WriteLine(c);
}
catch(Exception ex)
{
    //Hata oldugunda çalışıcak blok
    Console.WriteLine("Bir Hata Oluştu: "+ ex.Message.ToString());
}
finally
{
    //her zaman çalışacak blok
    Console.WriteLine("İşlem tamamlandı.");
}
double am = 4.1;

MathF.Round((float)am, 0);
Console.WriteLine(MathF.Round((float)am, 1));
Console.WriteLine(4.1.ToString());





try
{
    int a = 300000000;
}
catch (ArgumentNullException ex)
{

    Console.WriteLine("Boş bir değer girdiniz: "+ ex);
}
catch (FormatException ex)
{

    Console.WriteLine("Veri tipi uygun değil: "+ ex);
}
catch (OverflowException ex)
{

    Console.WriteLine("Küçük ya da büyük bir değer girdiniz: "+ ex);
}


