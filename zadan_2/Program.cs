Console.Write("Введите первое число: ");
string userInput = Console.ReadLine() ?? "";
double userNumber_a = double.Parse(userInput);
Console.Write("Введите второе число: ");
userInput = Console.ReadLine() ?? "";
double userNumber_b = double.Parse(userInput);
Console.Write("Введите третье число: ");
userInput = Console.ReadLine() ?? "";
double userNumber_c = double.Parse(userInput);
double max = userNumber_a;
if (userNumber_b > max) max = userNumber_b;
if (userNumber_c > max) max = userNumber_c;
{
    Console.WriteLine(userNumber_a + ", " + userNumber_b + ", " + userNumber_c + " -> " + max);
}
