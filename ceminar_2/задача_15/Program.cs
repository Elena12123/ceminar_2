void PrintDenX()

{
Console.WriteLine("Ведите число от 1 до 7 ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1|| num == 2|| num == 3|| num == 4||num == 5 )
{
    Console.WriteLine("нет");
}

if (num == 6|| num == 7)
{
    Console.WriteLine("да");
}

if (num <1|| num >7)
{
    Console.WriteLine("В неделе только 7 дней");
}
}
PrintDenX();


