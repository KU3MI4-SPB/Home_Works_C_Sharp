﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

IntNum:
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100) 
{
    Console.WriteLine("Нет третьей цифры, попробуйте ввести цисло снова");
    goto IntNum;
} 
else 
{
    while (num > 999) 
    {
        num /= 10;
    }
}

int num3 = num % 10;
Console.WriteLine($"Третья цифра в числе: {num3}");