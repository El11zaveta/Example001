﻿Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}