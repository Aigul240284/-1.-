Console.Write("Введите число a: ");
string userInput = Console.ReadLine() ?? "";
double userNumber_a = double.Parse(userInput);
Console.Write("Введите число b: ");
userInput= Console.ReadLine() ?? "";
double userNumber_b = double.Parse(userInput);
if (userNumber_a > userNumber_b)
{
    Console.WriteLine("a=" + userNumber_a + " b=" + userNumber_b + " ->" + " max=" + userNumber_a);
}
else
{
    Console.WriteLine("a=" + userNumber_a + " b=" + userNumber_b + " ->" + " max=" + userNumber_b);
}