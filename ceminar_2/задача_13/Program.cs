void PrintNum3()
{
// Console.WriteLine("Введите число ");
// string N = Console.ReadLine();
// int x = N.Length;
// Console.WriteLine(Length);

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
string N = Convert.ToString(x);


if (N.Length > 2)
{
    Console.WriteLine ("Третья цифра в числе "+ N [2]);

}

else
{
    Console.WriteLine ($"Третьей цифры нет ");
}

}

  
PrintNum3();
