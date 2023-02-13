// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();

Console.Write("Print nubmer a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Print nubmer b: ");
int b = int.Parse(Console.ReadLine()!);

if (a % b == 0)
{
    Console.WriteLine($"Кратно");
}
else 
{
    int div = a % b;
    Console.WriteLine($"Остаток от деления {div}");
}


