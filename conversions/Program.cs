// See https://aka.ms/new-console-template for more information
Console.WriteLine("Implicit Conversion");

byte a = 1;
sbyte b = 2;
short c = 3;

int d = a+b+c;
Console.WriteLine("d:"+d);

long h = d;
Console.WriteLine("h:"+h);

float i = h;
Console.WriteLine("i:"+i);

string s = "mimar";
char ch = 'a';
object f = s + ch;
Console.WriteLine("f:"+f);

Console.WriteLine("Explicit Conversion");

int x = 5;
byte y = (byte)x;
Console.WriteLine("y:"+y);

float fl = 5.1f;
byte by = (byte)fl;
Console.WriteLine("by:"+by);

string str = fl.ToString();
Console.WriteLine("str:"+str);

string metin = "222";
int rakam;

rakam = Int32.Parse(metin);
Console.WriteLine("rakam:"+rakam);




