Console.Write("Введите число: ");
string strA = Console.ReadLine();
int a = int.Parse(strA);
Console.Write("Введите второе число: ");
string strB = Console.ReadLine();
int b = int.Parse(strB);
int r = a % b;

if (r == 0)
{
    Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine("Число не кратно");
    Console.WriteLine($"Остаток {r} ");
}

