Console.Write("Введите первое число: ");
int firstDigit = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondDigit = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int thirdDigit = int.Parse(Console.ReadLine()!);

int Max = 0;
if (firstDigit > Max)
{
    Max = firstDigit;
}

if (secondDigit > Max)
{
    Max = secondDigit;
}

if (thirdDigit > Max)
{
    Max = thirdDigit;
}

Console.Write($"Максимальное число равно {Max}");