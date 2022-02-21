Questions homework = new();

homework.checkEven();
Console.WriteLine();
homework.checkDivide();
Console.WriteLine();
homework.firstToEnd();
Console.WriteLine();
homework.checkSentence();

class Questions {
    public void checkEven() {
        
        Console.WriteLine("*****Çift Sayı Kontrol Uygulaması*****");
        Console.Write("Kaç sayı kontrol etmek istersiniz: ");
        
        //Pozitif bir sayı girilmediği sürece dönen while
        uint n;
        while (!uint.TryParse(Console.ReadLine(),out n)) {
            Console.WriteLine("Geçerli bir sayı giriniz...");
        }
        //*****

        List<uint> list = new();

        //n adet pozitif sayı girmesini sağlayan döngü
        for (int i=0; i<n; i++) {
            Console.Write("Sayı giriniz: ");
            uint input;
            //Geçerli bir sayı girilmediği sürece dönen while
            while (!uint.TryParse(Console.ReadLine(),out input)) {
                Console.WriteLine("Geçerli bir sayı giriniz...");
            } 
            //*****
            if (input%2 == 0 && list.Contains(input)==false) {
                list.Add(input);
            };
        }

        Console.Write("Çift Sayılar: ");

        foreach (var i in list) {
            Console.WriteLine(i);
        }
    }
    public void checkDivide() {
        
        Console.WriteLine("*****Bölünebilirlik Kontrol Uygulaması*****");
        Console.Write("Kaç sayı kontrol etmek istersiniz: ");

        //Pozitif bir sayı girilmediği sürece dönen while
        uint n;
        while (!uint.TryParse(Console.ReadLine(),out n)) {
            Console.WriteLine("Geçerli bir sayı giriniz...");
        }
        //*****

        Console.Write("Kontrol etmek istediğiniz sayı: ");

        //Geçerli bir sayı girilmediği sürece dönen while
        uint m;
        while (!uint.TryParse(Console.ReadLine(),out m)) {
            Console.WriteLine("Geçerli bir sayı giriniz...");
        }
        //*****

        List<uint> list = new();

        //n adet pozitif sayı girmesini sağlayan döngü
        for (int i=0; i<n; i++) {
            Console.Write("Sayı giriniz: ");
            uint input;
            //Geçerli bir sayı girilmediği sürece dönen while
            while (!uint.TryParse(Console.ReadLine(),out input)) {
                Console.WriteLine("Geçerli bir sayı giriniz...");
            } 
            //*****
            list.Add(input);
        }

        Console.WriteLine("{0} sayısına tam bölünen girdileriniz:",m);

        foreach (var i in list) {
            if (i%m == 0) {
                Console.WriteLine(i);
            }
        }   
    }
    public void firstToEnd() {
        Console.WriteLine("*****Girdiğiniz Diziyi Tersten Yazan Uygulama*****");
        Console.Write("Kaç eleman girmek istersiniz: ");
        
        //Pozitif bir sayı girilmediği sürece dönen while
        uint n;
        while (!uint.TryParse(Console.ReadLine(),out n)) {
            Console.WriteLine("Geçerli bir sayı giriniz...");
        }
        //*****
        
        Console.WriteLine("Elemanları giriniz:");
        List<string> inputs = new();
        for (int i=0; i<n; i++) {
            inputs.Add(Console.ReadLine());
        }
        
        inputs.Reverse();
        string result = string.Join(" ",inputs);
        Console.WriteLine(result);
    }
    public void checkSentence() {
        Console.WriteLine("*****Cümledeki Kelime ve Harf Sayısı Kontrolü*****");
        string n = Console.ReadLine();
        string[] sentence = n.Split(" ");
        string charCount = string.Join("",sentence);
        Console.WriteLine("Kelime sayısı: "+sentence.Length);
        Console.WriteLine("Harf sayısı: "+charCount.Length);
    }
}
