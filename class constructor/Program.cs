// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Employee employee2 = new("Ali","Atay",789,"Game");

employee2.info();

class Employee {
    public string name;
    public string surname;
    public int no;
    public string department;

    public void info() {
        Console.WriteLine("Empleyee Name: {0}",name);
        Console.WriteLine("Empleyee Name: {0}",no);
    } 

    public Employee(string Name,string Surname,int No,string Department) {
        name = Name;
        surname = Surname;
        no = No;
        department = Department;
    }
}