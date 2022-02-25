static class Features {
    public static void numaraKaydet(List<Person> rehber) {
        Console.Write("Lütfen isim giriniz    : ");
        string name = Console.ReadLine().ToUpper();
        Console.Write("Lütfen soyisim giriniz : ");
        string surname = Console.ReadLine().ToUpper();
        Console.Write("Lütfen numara giriniz  : ");
        int number;
        //Geçerli bir numara girilene kadar döner
        while (int.TryParse(Console.ReadLine(),out number)==false){
            Console.WriteLine("Geçerli bir numara giriniz...");
            Console.Write("Lütfen numara giriniz  : ");
            continue;
        }
        Person person = new(name, surname, number);
        rehber.Add(person);
        Console.WriteLine("\n"+name+" "+surname+" eklendi.");
    }
    public static void numaraSil(List<Person> rehber) {
        Console.Write("\nAramak istediğiniz kişinin bilgisi: ");
        string search = Console.ReadLine();
        List<int> result;
        try {
            result = Features.aramaYap(rehber, int.Parse(search));
        } catch {
            result = Features.aramaYap(rehber, search.ToUpper());
        }
        Console.WriteLine("Silmek istediğiniz kişinin sıra numarası veya iptal için 0 giriniz.");
        //Konsoldan sayı girdisi olana kadar dönen while
        while (int.TryParse(Console.ReadLine(),out int n)) {
            if (n == 0) { //Eğer girdi 0 veya sonuç listesinden büyük ise sistemi durdurur
                break;
            } else if ((n-1)>result.Count) {
                Console.WriteLine("Geçerli bir sayı giriniz...");
            } else {
                int i = result[n-1];
                Console.WriteLine(rehber[i].Name+" kişisi silindi.");
                rehber.RemoveAt(i);
                break;
            }   
        }
    }
    public static void rehberListele(List<Person> rehber) {
        for (int i=0; i<rehber.Count; i++) {
            Console.WriteLine("-{0}-----",i+1);
            Console.WriteLine("İsim    : {0}", rehber[i].Name);
            Console.WriteLine("Soyisim : {0}", rehber[i].Surname);
            Console.WriteLine("Numara  : {0}", rehber[i].Number);
        }   
    }
    //name veya surname girişi ile arama
    //Sonuçların integerlarının bulunduğu liste döndürür
    public static List<int> aramaYap(List<Person> rehber, string search) {
        List<int> results = new();
        int n = 1;
        for (int i=0; i<rehber.Count; i++) {
            if (rehber[i].Name==search || rehber[i].Surname==search) {
                Console.WriteLine("-{0}-----",n);
                Console.WriteLine("İsim    : {0}", rehber[i].Name);
                Console.WriteLine("Soyisim : {0}", rehber[i].Surname);
                Console.WriteLine("Numara  : {0}", rehber[i].Number);
                results.Add(i);
                n++;
            }
        }
        if (results.Count == 0) {
            Console.WriteLine("Sonuç bulunamadı...");
        }
        return results;
    }
    //Overload ile numara girişi ile arama
    //Sonuçların integerlarının bulunduğu liste döndürür
    public static List<int> aramaYap(List<Person> rehber, int search) {
        List<int> results = new();
        int n = 1;
        for (int i=0; i<rehber.Count; i++) {
            if (rehber[i].Number == search) {
                Console.WriteLine("-{0}-----",n);
                Console.WriteLine("İsim    : {0}", rehber[i].Name);
                Console.WriteLine("Soyisim : {0}", rehber[i].Surname);
                Console.WriteLine("Numara  : {0}", rehber[i].Number);
                results.Add(i);
                n++;
            }
        }
        return results;
    }
}