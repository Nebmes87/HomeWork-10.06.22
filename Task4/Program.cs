// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string numberInt = Console.ReadLine();
int number = int.Parse(numberInt);
int i = 1;
while (i<=number)
{
    if (i%2==0)
    {
        Console.Write($"{i} ");
    }
    i++;
}

// или

Console.WriteLine();
Console.Write("Введите число: ");
string numberStr = Console.ReadLine();
int num = int.Parse(numberStr);
int ind = 2;
while (ind <= num)
{
    Console.Write($"{ind} ");
    ind += 2;
}