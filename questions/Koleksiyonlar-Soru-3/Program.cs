Console.Write("***Koleksiyonlar-Soru-3***");
Console.Write("Kontrol edilecek cümle: ");

string sentence = Console.ReadLine();

char[] c = {'a','e','i','ı','o','ö','u','ü'};

List<char> inputsChar = new();

for (int i=0; i<sentence.Length; i++) {
    if (c.Contains(sentence[i])==true && inputsChar.Contains(sentence[i])==false) {
        inputsChar.Add(sentence[i]);
        continue;
    } else if (c.Contains(sentence[i])==false && sentence[i] != ' ') {
        sentence = sentence.Replace(sentence[i],'-');
    }
}

Console.WriteLine(sentence);
inputsChar.Sort();

Console.Write("\nİçerdiği Ünlü Harfler: ");
foreach (var i in inputsChar) {
    Console.Write(i+" ");
}