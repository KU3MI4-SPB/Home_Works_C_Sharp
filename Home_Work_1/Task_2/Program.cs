﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

InputNums:
Console.WriteLine("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num == num2)
{
    Console.WriteLine("Числа одинаковые, пожайлуста введите три разных числа");
    goto InputNums;
}
else
    if (num == num3)
{
    Console.WriteLine("Числа одинаковые, пожайлуста введите три разных числа");
    goto InputNums;
}

int max = Math.Max(Math.Max(num, num2), num3);
int min = Math.Min(Math.Min(num, num2), num3);

Console.WriteLine($"Меньшее число - {min}, а большее число - {max}");