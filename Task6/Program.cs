int n = new Random().Next(10, 100);
Console.WriteLine($"Дано число {n}");
string s = n.ToString();

int a = int.Parse(s[0].ToString());
int b = int.Parse(s[1].ToString());

if (a > b)
{
    Console.WriteLine($"Наибольшая цифра {a}");
}
else
{
    Console.WriteLine($"Наибольшая цифра {b}");
}
