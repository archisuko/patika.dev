List<int> notlar = new List<int>();
notlar.Add(245);
notlar.Add(5);
notlar.Add(76);

List<string> mevsim = new List<string>();
mevsim.Add("kış");
mevsim.Add("sonbahar");
mevsim.Add("yaz");
mevsim.Add("ilkbahar");

Console.WriteLine(notlar.Count);
Console.WriteLine(mevsim.Count);

foreach (var i in mevsim) {
    Console.WriteLine(i);
}
foreach (var i in notlar) {
    Console.WriteLine(i);
}

Console.WriteLine("*******************");

mevsim.Remove("yaz");

for (int i=0; i<100; i++) {
    if (notlar.Contains(i)==true) {
        Console.WriteLine("{0} listede bulunuyor.",i);
        break;
    } else {
        Console.WriteLine("{0} listede yok.",i);
    }
}

List<allUsers> all = new();

allUsers admin1 = new();
admin1.canDelete = true;
admin1.laugh = "hahahahah";

allUsers user1 = new();
user1.canDelete = false;
user1.laugh = "xdxdxddxd";

all.Add(admin1);
all.Add(user1);

foreach (var i in all) {
    Console.WriteLine(i.laugh);
}

public class allUsers {
    public bool canDelete;
    public string laugh;
}

