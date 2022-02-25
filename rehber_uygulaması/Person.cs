class Person {
    string name;
    string surname;
    int number;
    public Person(string name, string surname, int number)
    {
        this.Name = name;
        this.Surname = surname;
        this.Number = number;
    }
    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Number { get => number; set => number = value; }
}