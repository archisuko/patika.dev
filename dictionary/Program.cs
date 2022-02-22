
Dictionary<int,string> school = new();

school.Add(25,"Ali");
school.Add(23,"Mehmet");
school.Add(18,"Şükrü");

foreach (var i in school) {
    Console.WriteLine(i);
}

Console.WriteLine(school.Count);
Console.WriteLine(school.ContainsKey(25));
Console.WriteLine(school.ContainsValue("Mehmet"));

foreach (var i in school.Values) {
    Console.WriteLine(i);
}
foreach (var i in school.Keys) {
    Console.WriteLine(i);
}