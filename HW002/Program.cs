//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите три числа:");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numС = Convert.ToInt32(Console.ReadLine());

int max = numA;
if (numB > max) max=numB;
if (numС > max) max=numС;
  Console.WriteLine("Максимальное число: "+ max);

