string txt = "Hello World";
Console.WriteLine(txt.ToUpper());
Console.WriteLine(txt.ToLower());   

Console.WriteLine("The length of the txt string is: " + txt.Length);

string firstName = "Şükrü ";
string lastName = "Demirci";
string name = string.Concat(firstName, lastName);
Console.WriteLine(name);
Console.WriteLine(name[2]);
Console.WriteLine(name.IndexOf("e"));

DateTime date1 = DateTime.Now;
var date2 = new DateTime(2008, 3, 1, 7, 0, 0);
Console.WriteLine(date1.ToString("yyyy/MM/dd  HH:mm:ss"));
Console.WriteLine(date2.ToString("yyyy/MM/dd  HH:mm:ss"));

Console.WriteLine(Math.Max(5, 10));
Console.WriteLine(Math.Sqrt(64));
Console.WriteLine(Math.Round(9.99));