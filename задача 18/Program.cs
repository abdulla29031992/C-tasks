﻿void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while (index < length)
  {
    collection[index] = new Random().Next(1, 10);
    index++;
  }
}

void PrintArray(int[] col)

{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    Console.WriteLine(col[position]);
    position++;
  }
}

int indexof(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = 0;
  while (index < count)
  {
    if(collection[index] == find)
    {
      position = index;
      break;
    }
  }
  return position;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = indexof(array, 4);
Console.WriteLine(pos);

