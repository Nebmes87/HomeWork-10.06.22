﻿//  Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
string numberInt = Console.ReadLine();
int number = int.Parse(numberInt);
if (number%2==0)
{
    Console.WriteLine($"Число {number} чётное.");
}
else
{
    Console.WriteLine($"Число {number} не чётное.");
}