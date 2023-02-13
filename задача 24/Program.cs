// Вид 1

// void Method1()
{
  // Console.WriteLine("Автор Довлетханов Абдулла");
}
// Method1();



// Вид 2
// void Method2(string msg)
{
  // Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");


// вид 3

// int Method3()
{
  // return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

// string Method4(int count, string text)
{
  // int i = 0;
  // string result = String.Empty;
  // while (i < count)
  {
    // result = result + text;
    // i++;
  }
  // return result;
}

// string Method4(int count, string text)
{
  // string result = String.Empty;
  // for(int i = 0; i < count; i++)
  {
    // result = result + text;
  }
  // return result;
}
// string res =  Method4(10, "Миясат");
// Console.WriteLine(res);

// for (int i =2; i<= 10; i++)
{
  // for (int j = 2; j<= 10; j++)
  {
    // Console.WriteLine($"{i} x {j}  = {i * j}");
  }
  // Console.WriteLine();
}

 int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

 void PrintArray(int[] array)
{
   int count = array.Length;

   for (int i = 0; i < count; i++)
  {
     Console.Write($"{array[i]}");
  }
   Console.WriteLine();

}

 PrintArray(arr);

void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;

    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[j] < array[minPosition]) minPosition = j;
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
}

PrintArray(arr);
SelectionSort(arr);