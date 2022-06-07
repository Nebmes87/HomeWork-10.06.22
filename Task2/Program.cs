// Напишите программу, которая 
//принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите число a: ");
string number1 = Console.ReadLine();
int a = int.Parse(number1);
Console.WriteLine("Введите число b: ");
string number2 = Console.ReadLine();
int b = int.Parse(number2);
Console.WriteLine("Введите число c: ");
string number3 = Console.ReadLine();
int c = int.Parse(number3);
int max = a;
if (b>max) max=b;
if (c>max) max=c;
Console.WriteLine($"{a}, {b}, {c} -> {max}");