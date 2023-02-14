﻿// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] GetArray(int size, int minValue, int maxValue)
{
int[] result = new int[size];

for (int i = 0; i < size; i++)
{
result[i] = new Random().Next(minValue, maxValue + 1);
}

return result;
}

// 1 2 3 4 5 -> 5 2 3 4 1 -> 5 4 3 2 1
void ReverseArray1(int[] inArray)
{
for (int i = 0; i < inArray.Length / 2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - 1 - i];
inArray[inArray.Length - 1 - i] = temp;
}
}

int[] ReverseArray2(int[] inArray)
{
int[] result = new int[inArray.Length];

for (int i = 0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length - 1 - i];
}

return result;
}

Console.Clear();
int[] array = GetArray(5, -10, 10);
Console.WriteLine(String.Join(", ", array));
ReverseArray1(array);
Console.WriteLine(String.Join(", ", array));
int[] revered = ReverseArray2(array);
Console.WriteLine("Revered: " + String.Join(", ", revered));
Console.WriteLine("Array: " + String.Join(", ", array));
