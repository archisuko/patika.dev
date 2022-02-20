

int x = 5;
int y = 7;
Console.WriteLine(x*y);

int Carpma(int i, int j) {
    return i*j;
}
Console.WriteLine(Carpma(x, y));
Console.WriteLine(x);
Console.WriteLine(y);

int artıCarpma(ref int i,ref int j) {
    i++;
    j++;
    return i*j;
}
Console.WriteLine(artıCarpma(ref x,ref y));
Console.WriteLine(x);
Console.WriteLine(y);