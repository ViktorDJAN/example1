Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
   Console.WriteLine("Ну привет моя дорогая МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}