﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

// Console.Write("Введите трехзначное число: ");
// int Wnumber = Convert.ToInt32(Console.ReadLine());
// int GetTwoNum(int number)
// {
// int firstnum = number / 10;
// int secondnum = firstnum % 10;
// return secondnum;
// }
// int result  = GetTwoNum(Wnumber);
// Console.Write(result);



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//456 -> 5
//782 -> 8
//918 -> 1

// Console.Write("Введите число - ");
// int newNumber = Convert.ToInt32(Console.ReadLine());

// int findThirdDigit(int Number)
// {
//     while (Number / 100 > 9)
//     {
//         Number = Number / 10;
//     }
//     int thirdDigit = Number%10;
//     return thirdDigit;
// }

// int result = 0;

// if (newNumber / 100 > 0)
// {
//     result = findThirdDigit(newNumber);
//     Console.Write("Третья цифра - "+ result);
  
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }




//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введи цифру  ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNum) {
 if (dayNum == 6 || dayNum == 7) {
  Console.WriteLine("Выходной");
 }
 else if (dayNum < 1 || dayNum > 7) {
   Console.WriteLine("Число не относится к дню недели");
 }
 else Console.WriteLine("Не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);