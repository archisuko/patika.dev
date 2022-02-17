// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 100 + 50;

int sum1 = 100 + 50;        // 150 (100 + 50)
int sum2 = sum1 + 250;      // 400 (150 + 250)
int sum3 = sum2 + sum2;     // 800 (400 + 400)

int y = 10;
y += 5;
Console.WriteLine(y);
y -= 5;
Console.WriteLine(y);
y *= 5;
Console.WriteLine(y);
y /= 5;
Console.WriteLine(y);
y %= 3;
Console.WriteLine(y);

bool t = true;
bool f = false;

if (t && x>y) {
    Console.WriteLine("Güzel...");
}
if (f || x>y) {
    Console.WriteLine("İdare eder...");
}

bool sonuc;

sonuc = x == y;
Console.WriteLine(sonuc);
sonuc = x != y;
Console.WriteLine(sonuc);
sonuc = x > y;
Console.WriteLine(sonuc);
sonuc = x < y;
Console.WriteLine(sonuc);
sonuc = x >= y;
Console.WriteLine(sonuc);
sonuc = x <= y;
Console.WriteLine(sonuc);
