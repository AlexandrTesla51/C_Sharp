// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76

double[] GetArray(int lenght)
{
    double[] array = new double[lenght];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 10 + rnd.Next(-10, 11), 1);
    }

    return array;
}

void PrintArray(double[] array)
{
    foreach (double el in array)
    {
        Console.Write((el + " "));
    }
}

void DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }

    {
        Console.WriteLine($"Максимальный элемент массива равен:{max} ");
        Console.WriteLine($"Минимальный элемент массива равен: {min}");
        Console.WriteLine($"Разница между максимальным и минимальными элемантами равна: {max-min}");
    }
}

Console.WriteLine("Введите длину массива");
double[] array = GetArray(int.Parse(Console.ReadLine()!));

PrintArray(array);
Console.WriteLine();
DiffMaxMin(array);