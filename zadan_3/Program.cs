Console.Write("Введите число: ");
string b = Console.ReadLine() ?? "";
int a = int.Parse(b);

if (a %2 == 0)
{
    Console.WriteLine(a + " -> " + "да");
}
else
{
    Console.WriteLine(a + " -> " + "нет");
}