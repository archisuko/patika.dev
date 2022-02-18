int tekToplam = 0;
int ciftToplam = 0;

for (int i=0; i<100; i++)
{
    if (i%2 == 1) {
        tekToplam += i;
    } else {
        ciftToplam += i;
    }
    if (i==50) break;
}
Console.WriteLine(tekToplam);
Console.WriteLine(ciftToplam);

for (int i=0;; i++)
{
    if (i==5)
        break;
    Console.WriteLine(i);
}

for (int i=0; i<10; i++)
{
    if (i==5)
        continue;
    Console.WriteLine(i);
}

Console.WriteLine("**********************");

int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac ++;
}
Console.WriteLine(toplam);

char c = 'a';
while (c <= 'z')
{
    Console.Write(c);
    c ++;
}

string[] isim = {"sukru","mehmet","yusuf"};

foreach (var item in isim)
{
    Console.WriteLine(item);
}
