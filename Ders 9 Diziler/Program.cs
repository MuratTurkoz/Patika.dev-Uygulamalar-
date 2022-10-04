// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] color = new string[5];
string[] animals = { "Dog", "Cat", "Bird", "Monkey" };

int[] dizi;
dizi = new int[5];

dizi[3] = 10;

color[0] = "blue";
Console.WriteLine(animals[3]);
Console.WriteLine(color[0]);
Console.WriteLine(dizi[3]);

Console.WriteLine("Lütfen dizinin eleman sayısını giriniz");
int diziUz = int.Parse(Console.ReadLine());

//Ortalama hesaplayan Program

int[] res = new int[diziUz];

for (int i = 0; i < diziUz; i++)
{
    Console.WriteLine("Lütfen dizinin {0} terimini giriniz", i + 1);
    res[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
foreach (int item in res)
{
    sum += item;

}

Console.WriteLine("Dizi ortalama:{0}", (sum / res.Count()));





