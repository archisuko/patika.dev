List<Person> rehber = new();
while(true) {
    Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek \n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak");
    Console.Write("\nYapmak istediğiniz işlem numarası: ");
    switch (Console.ReadLine()) {
        case "1":
            Features.numaraKaydet(rehber);
            break;
        case "2":
            Features.numaraSil(rehber);
            break;
        case "3":
            Features.numaraSil(rehber);
            Features.numaraKaydet(rehber);
            break;
        case "4":
            Console.WriteLine("-----Rehber-----");
            Features.rehberListele(rehber);
            break;
        case "5":
            Console.Write("\nAramak istediğiniz kişinin bilgisi: ");
            string search = Console.ReadLine();
            try {
                Features.aramaYap(rehber, int.Parse(search));
            } catch {
                Features.aramaYap(rehber, search.ToUpper());
            }
            break;
        default:
            Console.WriteLine("Geçerli bir işlem numarası giriniz.");
            break;
    }
}