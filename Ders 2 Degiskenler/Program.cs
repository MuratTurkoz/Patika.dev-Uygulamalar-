// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
byte b = 1;         //1 byte yer kaplar
sbyte c = 2;        //1 byte yer kaplar

short s = 3;        //2 byte yer kaplar
ushort us = 4;      //2 byte yer kaplar

Int16 i16 = 5;      //2 byte yer kaplar
int i = 6;          //2 byte yer kaplar
Int32 i32 = 7;      //4 byte yer kaplar
Int64 i64 = 8;      //8 byte yer kaplar

uint ui = 9;
long l = 10;
ulong ul = 11;

float f = 0.1f;      //4 byte yer kaplar
double d = 0.01;     //8 byte yer kaplar
decimal de = 0.002m; //16 byte yer kaplar

char ch = 'a';        //4 byte yer kaplar
string st = "";       //sınırısız

bool b1 = true;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);


object o = "a";
object o1 = 'm';
object o2 = 12;
object o3 = 5.3;

//String ifadeler

string str1 = string.Empty;
string s1 = "s";
string s2 = "m";
string result = s1 +" "+ s2;

//boolen

bool bool1 = 10 > 3;

//değişken dönüşümleri

string str2 = "20";
int i20 = 20;

string newO=str2+" " +i20.ToString();
// Console.Write(newO);
int resul2 = i20 + Convert.ToInt32(str2);
int result3 = int.Parse(str2);
// Console.Write(result3);

string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dateTime);
string dateTime1 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(dateTime1);
string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);

int degisken = 5;
string degisken = "aa";