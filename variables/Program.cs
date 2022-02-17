// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte b = 1;          //1 byte
sbyte c = 2;         //1 byte

short s = -4;        //2 byte
ushort us = 4;       //2 byte

Int16 i16 = 5;       //2 byte
Int32 i32 = 6;       //4 byte
Int64 i64 = 7;       //8 byte

int i = -8;          //4 byte
uint ui = 8;         //4 byte
long l = -9;         //8 byte
ulong ul = 9;        //8 byte

float f = 10.11f;     //4 byte
double d = 10.22;     //8 byte
decimal de = 10.33m;  //16 byte

char ch = '1';        //2 byte
string str = "char";  //sınırsız

bool b1 = true;       //true
bool b2 = false;      //false

string now = DateTime.Now.ToString("dd.MM.yyyy");

string birthDay = new DateTime(1997, 4, 5).ToString("dd//MM//yyyy");

Console.WriteLine(birthDay);

