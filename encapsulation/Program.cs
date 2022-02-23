// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ogrenci bir = new ogrenci("atay",50,"ali");
bir.adıGetir();
bir.notuGetir();


class ogrenci {
    string name;
    string surname;
    int note;

    public ogrenci(string surname, int note, string name)
    {
        Surname = surname;
        Note = note;
        Name = name;
    }
    public ogrenci(){}

    public string Name { get => name; set => name = value; }
    public int Note { get => 1; set => note = value; }
    public string Surname { get => surname; set => surname = value; }

    public void adıGetir() {
        Console.WriteLine("Adı: "+Name);
    }
    public void notuGetir() {
        Console.WriteLine("Not: "+Note);
    }
}