Console.Write("Введите первое число: ");
int firstDigite = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondDigite = int.Parse(Console.ReadLine()!);
if (firstDigite > secondDigite)
{
    Console.Write("Первое число больше второго, а второе меньше первого");
}
else
{
    Console.Write("Второе число больше первого, а первое меньше второго");
}
