int month = DateTime.Now.Month;

Console.WriteLine(month + ". aydasın");

if (month<5) {
    Console.WriteLine("Yaza az kaldı...");
} else if (month<9) {
    Console.WriteLine("Yazdasın :)");
} else {
    Console.WriteLine("Sonraki yılı bekle :(");
}

string message = month<5 ? "Yılın başı" : "Yılın sonu";
Console.WriteLine(message);

message = 5<month && month<9 ? "Yıl ortası" : month<5 ? "Yeni yıldasın" : "Yılın sonu";
Console.WriteLine(message);
