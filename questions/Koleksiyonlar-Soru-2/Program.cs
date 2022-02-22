int[] inputs = new int[20];
Console.WriteLine("***Koleksiyonlar-Soru-2***");
Console.WriteLine("Kontrol etmek istediğiniz 20 sayıyı giriniz.");

//20 adet sayı girilene kadar dönen while
int i = 0;
while (i != 20) {
    try
    {
        Console.Write("({0}/20) ",i+1);
        inputs[i] = Convert.ToInt32(Console.ReadLine());
    }
    catch (System.Exception)
    {
        Console.WriteLine("Geçerli bir sayı giriniz...");
        continue; //Array listesi ile yaptığımız için listeye eklenemeyecek girdilerde i'yi arttırmadan sonraki döngüye geçilmesi gerek
    }
    i++;
}

Array.Sort(inputs);
Console.WriteLine("En Büyük 3 Sayı: "+inputs[19]+" "+inputs[18]+" "+inputs[17]);
Console.WriteLine("Ortalaması: "+(inputs[19]+inputs[18]+inputs[17])/3);
Console.WriteLine("En Küçük 3 Sayı: "+inputs[0]+" "+inputs[1]+" "+inputs[2]);
Console.WriteLine("Ortalaması: "+(inputs[0]+inputs[1]+inputs[2])/3);
Console.WriteLine("Ortalama Toplamları: "+((inputs[0]+inputs[1]+inputs[2])/3+(inputs[19]+inputs[18]+inputs[17])/3));