List<uint> inputs = new();
Console.WriteLine("***Asal Sayı Kontrol Uygulaması***");
Console.WriteLine("Kontrol etmek istediğiniz 20 sayıyı giriniz.");
//20 adet pozitif sayı girilene kadar dönen while
while (inputs.Count != 20) {
    try
    {
        Console.Write("({0}/20) ",inputs.Count+1);
        inputs.Add(Convert.ToUInt32(Console.ReadLine())); 
    }
    catch (System.Exception)
    {
        Console.WriteLine("Geçerli bir sayı giriniz...");
    }
}

List<uint> prime = new();
List<uint> nonPrime = new();
int totalPrime = 0;
int totalNonPrime = 0;

//Her bir inputun asallığını kontrol eden foreach döngüsü
foreach (var number in inputs) {
    int count = 0;
    for (int i=2; i<number; i++) {
        if (number%i == 0) {
            count++;
        }
    }
    if (count == 0) {
        prime.Add(number);
        totalPrime += (int)number;
    } else {
        nonPrime.Add(number);
        totalNonPrime += (int)number;
    }
}

prime.Sort();
prime.Reverse();
nonPrime.Sort();
nonPrime.Reverse();

Console.WriteLine("*****Asal Sayılar*****");
foreach (var i in prime) {
    Console.Write(i+" ");
}
Console.WriteLine("\nToplamı: "+totalPrime);
Console.WriteLine("Ortalaması: "+totalPrime/prime.Count);

Console.WriteLine("*****Asal Olmayan Sayılar*****");
foreach (var i in nonPrime) {
    Console.Write(i+" ");
}
Console.WriteLine("\nToplamı: "+totalNonPrime);
Console.WriteLine("Ortalaması: "+totalNonPrime/prime.Count);