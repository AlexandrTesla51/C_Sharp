// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Expo(int a, int b)
{
    double expo = Math.Pow(a, b);
    return expo;
}
Console.WriteLine("Введите число для возведения в степень: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите показатель степени, в которую нужно возвесть введенное число: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {a} в степени {b} равно: {Expo(a,b)}");
