// Дополнительно.
// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.


void SimpleDigit(int digit)
{
    for (int i = 2; i < digit - 1; i++)
    {
        for (int j = 2; j < digit - 1; j++)
        {
            if (i % j != 0) Console.WriteLine($"{i}");
        }
    }
}

Console.WriteLine("Введите число");
int digit = int.Parse(Console.ReadLine()!);
Console.ReadLine();
SimpleDigit(digit);