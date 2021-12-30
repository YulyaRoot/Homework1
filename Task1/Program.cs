Console.Write("Введите число: ");
string strA = Console.ReadLine();
int a = int.Parse(strA);
Console.Write("Введите второе число: ");
string strB = Console.ReadLine();
int b = int.Parse(strB);

if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом {b}");
}
else 
{
    Console.WriteLine($"Число {a} не является квадратом {b}");
}
