// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение  этого элемента или же указание, что такого элемента нет.
//  Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(21);
        }
    }

    return array;
}


void PrintArray(int[,] massive)
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

void PostitionOfElement(int[,] massive, int row, int col)
{
   
    if (row < massive.GetLength(0) && col < massive.GetLength(1))
    {
        Console.WriteLine();
        Console.WriteLine($"Элемента массива равен: {massive[row, col]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }
}

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine()!);



GetArray(m, n);
int[,] massive = GetArray(m, n);
PrintArray(massive);
Console.WriteLine();
Console.WriteLine("Введите номер строки элемента");
int row = int.Parse(Console.ReadLine()!) - 1;
Console.WriteLine("Введите номер столбца");
int col = int.Parse(Console.ReadLine()!) - 1;
PostitionOfElement(massive, row, col);