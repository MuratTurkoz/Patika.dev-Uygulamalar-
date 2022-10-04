// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//Rekürsif yinelemeli kod

//3^4=3*3*3*3
int result = 1;
for (int i = 1; i < 5; i++)
{
    result = result * 3;
}
Console.WriteLine(result);
// Islemler islem = new Islemler();
//yada
Islemler islem = new();
int res = islem.Expo(3, 4);
Console.WriteLine(res);
string res1 = "Murat Türköz";
bool res3 = res1.CheckSpaces();

if (res3 == true)
    Console.WriteLine(res1.SetSpaces());

Console.WriteLine(res1.MakeUpperCase());
Console.WriteLine(res1.MakeLowerCase());


int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
dizi.SortArray();
dizi.EkranaYazir();
class Islemler
{

    public int Expo(int sayi, int us)
    {
        if (us < 2)
            return sayi;
        return Expo(sayi, us - 1) * sayi;
    }
    //Expo(3,4)
    //Expo(3,3)*3
    //Expo(3,2)*3*3
    //Expo(3,1)*3*3*3


}
static class Extension
{
    //Extension Method this kullanılır
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }
    public static string SetSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("&", dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazir(this int[] param)
    {
        foreach (var item in param)
        {
            Console.Write(item);
        }

    }
    public static bool IsEven(this int param)
    {
        return param % 2 == 0;

    }
    public static string GetFirstChar(this string param)
    {
        return param.Substring(0, 1);
    }
}
