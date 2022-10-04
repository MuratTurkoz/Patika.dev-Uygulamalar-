// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 2;
int b = 3;
Console.WriteLine(a + b);
int Topla(int a, int b)
{
    return a + b;
}
Metotlar mm = new Metotlar();
mm.EkranaYazdir(Topla(2, 3).ToString());
//referans tipi:Kopya üretir deger değiştiri Bellekte sayı hala aynıdır

mm.EkranaYazdir(mm.ArttirTopla(2, 3).ToString());
//referans tipi:Bellekteki yerini değiştirir kopyasını değil
mm.EkranaYazdir(mm.ArttirTopla(ref a, ref b).ToString());

MetotOut mo = new MetotOut();
mo.Topla(3, 5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);



// Console.WriteLine(Topla(2, 3));


class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirTopla(int a, int b)
    {
        a += 1;
        b += 1;
        return a + b;
    }
    public int ArttirTopla(ref int a, ref int b)
    {
        a += 1;
        b += 1;
        return a + b;
    }
}
class MetotOut
{
    void TryParseMethod()
    {
        string sayi = "999";
        bool res = int.TryParse(sayi, out int outSayi);
        if (res == true)
        {
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

}
class MethodOverLoad
{
    public int ArttirTopla(int a, int b)
    {
        a += 1;
        b += 1;
        return a + b;
    }
    public int ArttirTopla(ref int a, ref int b)
    {
        a += 1;
        b += 1;
        return a + b;
    }



}


