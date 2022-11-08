// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//// 452 -> 11
//// 82 -> 10
//// 9012 -> 12

int Sum(int digit)
{
    int sum = 0;
    if (digit == 0) sum = 1;
   else while (digit > 0)
    {
        sum = digit % 10 + sum;
        digit = digit / 10;
    }

    return sum;
}

Console.WriteLine("Введите число: ");
int digit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр