// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Employee employee1 = new();
employee1.name = "Sukru";
employee1.no = 255;

employee1.info();

class Employee {
    public string name;
    public string surname;
    public int no;
    public string department;

    public void info() {
        Console.WriteLine("Empleyee Name: {0}",name);
        Console.WriteLine("Empleyee Name: {0}",no);
    } 
}