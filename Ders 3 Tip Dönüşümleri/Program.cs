// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Implicit Conversion (Bilinçsiz Dönüşüm)Kendi kendine yapar küçük bi veriyi buyuk bir veriye atamak
byte a=5;
sbyte b = 6;
short c = 7;
int d = a + b + c;

long e = d;

float f = e;

string g = " asd";
char h = 'a';
object i = e + g + h;


//Explicit Conversion (Bilinçli Dönüşüm)

int x = 4;
byte y = (byte)x;

int z = 100;
byte t=(byte)z;

float w = 10.3f;
byte v = (byte)w;

//ToString()

int ax = 6;
string yy = ax.ToString();

string zz = 12.5.ToString();

//System.Convert

string s1 = "10", s2 = "20";

int sy1, sy2,tp;

sy1 = Convert.ToInt32(s1);
sy2 = Convert.ToInt32(s2);
tp = sy1 + sy2;

Console.WriteLine(tp);

void ParseMethod(){

    //Parse sadece string degerleri içine alır ve string için kullanılır
    string m1 = "10";
    string m2 = "10.5";
    int r = int.Parse(m1);
    double d1 = double.Parse(m2);
}

ParseMethod();

