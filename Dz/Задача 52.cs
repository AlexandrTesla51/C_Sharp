// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(11);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }
}

void SumColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }

        Console.WriteLine($"Среднее арифметическое {j + 1}го столбца равно: {sum / array.GetLength(0)}");
    }

    Console.WriteLine();
}

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите столбцов строк массива");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

GetArray(m, n);
int[,] massive = GetArray(m, n);
PrintArray(massive);
Console.WriteLine();
SumColumns(massive);