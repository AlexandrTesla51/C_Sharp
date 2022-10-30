// Задача 23
//
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int digit)
{
    for (int i = 1; i <= digit; i++)
    {
        double result = Math.Pow(i, 3);
        Console.WriteLine($"Куб числа равен {result}");
    }
}

Console.WriteLine("Введите число");
int digit = int.Parse(Console.ReadLine());
Cube(digit);