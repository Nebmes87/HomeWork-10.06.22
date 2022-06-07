// Напишите программу, которая 
//на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число a: ");
string number1 = Console.ReadLine();
int a = int.Parse(number1);
Console.WriteLine("Введите число b: ");
string number2 = Console.ReadLine();
int b = int.Parse(number2);
if (a>b)
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {a}, min = {b}");
}
else
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {b}, min = {a}");
}