﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> не
// 12821 -> да
// 23432 -> да


Console.Clear();


Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);


void CheckPalindromicNumber(int number)


{
  if (number >= 10000)
  {
    int div1 = number / 10000;
    int rem1 = number % 10;

    if (div1 == rem1)
    {
      number = number / 10;
      int div2 = (number / 100) % 10;
      int rem2 = number % 10;
      if (div2 == rem2)
        Console.WriteLine("Да");
    }
    else
      Console.WriteLine("Нет");

  }
  else
    Console.WriteLine("Некорректное число!");
}

