﻿// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введи число: ");
int anyNum = Convert.ToInt32(Console.ReadLine());
string anyNum1 = Convert.ToString(anyNum);
if (anyNum1.Length > 2)
{
    Console.WriteLine("третья цифра -> " + anyNum1[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}

// Не знаю как сделать не через строки.
// Пробовал могу найти только если из 3 цифр состоит число больше не могу(((