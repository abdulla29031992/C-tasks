// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


Console.Clear();

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
int b = 7;
int c = 23;
int res1 = a % b;
int res2 = a % c;
if ( res1 ==0 && res2 == 0)
{
    Console.Write("Кратно ");
}
else 
{
    Console.Write("Не кратно ");
}
