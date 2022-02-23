// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Console.WriteLine("Çalışan sayısı: {0}", Calısan.CalısanSayısı);

Calısan first = new("Ali","Gamer");
Calısan second = new("Yusuf","Player");
Calısan third = new("Mehmet","Math");

Console.WriteLine("Çalışan sayısı: {0}", Calısan.CalısanSayısı);
Console.WriteLine(first.Isim1);

class Calısan {
    private static int calısanSayısı;
    public static int CalısanSayısı { get => calısanSayısı; }
    
    private string Isim;
    private string Department;
    public string Isim1 { get => Isim; set => Isim = value; }
    public string Department1 { get => Department; set => Department = value; }


    public Calısan(string ısim, string department = null)
    {
        Isim = ısim;
        Department = department;
        calısanSayısı++;
    }
    static Calısan() {
        calısanSayısı = 0;
    }
}