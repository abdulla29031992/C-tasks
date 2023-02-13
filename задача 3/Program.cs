Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Миясат")
{
  Console.WriteLine("Ура, это же Миясат");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}
