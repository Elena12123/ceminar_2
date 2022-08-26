void PrintSecondNum()
{
    int x = new Random().Next (100, 1000);
    Console.WriteLine($"{x}");
    int a = x%100;
    int b = a/10;
    Console.WriteLine($"второе число {b}");
}

PrintSecondNum();
