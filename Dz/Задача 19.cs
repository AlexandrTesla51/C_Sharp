// Задача 19
//
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//

void Palindrom(string digit)
{
    if (digit[0] == digit[4] && digit[1] == digit[3]) Console.WriteLine("Число является палиндромом");
    else if (digit.Length != 5) Console.WriteLine("Вы ввели неверное число");
    else Console.WriteLine("Число не является палиндромом");
}

Console.WriteLine("Введите пятизначное число");
Palindrom(Console.ReadLine()!);
