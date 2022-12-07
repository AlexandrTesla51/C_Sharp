// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =Math.Round(( rnd.NextDouble() + rnd.Next(-9, 10)),1);
        }
    }

    return array;
}


void PrintArray(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write(massive[i, j] + "  ");
        }

        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine()!);

GetArray(m, n);
double[,] massive = GetArray(m, n);
PrintArray(massive);