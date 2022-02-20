// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Factor (int i) {
    if (i==1) {
        return 1;
    }
    return i*Factor(i-1);
}

Console.WriteLine(Factor(5));

int Fibonacci (int i) {
    if (i==2) {
        return 1;
    } else if (i==1){
        return 0;
    } else {
        return Fibonacci(i-1)+Fibonacci(i-2);
    }
}

Console.WriteLine(Fibonacci(5));
Console.WriteLine(Fibonacci(10));
Console.WriteLine(Fibonacci(11));
Console.WriteLine(Fibonacci(12));