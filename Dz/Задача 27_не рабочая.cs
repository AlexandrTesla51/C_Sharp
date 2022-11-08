// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//// 452 -> 11
//// 82 -> 10
//// 9012 -> 12

int Sum(string digit)
{
    int count = digit.Length;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        sum = digit[i] + sum;
        Console.WriteLine(digit[i]);
        
    }

    return sum;
}

Console.WriteLine("Введите число: ");
string digit = Console.ReadLine();
Console.WriteLine($"Сумма цифр в числе {digit} равна {Sum(digit)}");