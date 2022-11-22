// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }

    return array;
}

void PrintSum(int[] array)
{
    foreach (int el in array)
    {
        Console.Write(el + " ");
    }
    
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }

    Console.WriteLine();
    Console.Write($"Сумма нечетных элементов массива равна: {sum}");
}

Console.WriteLine("Введите длину массива");
int lenght = int.Parse(Console.ReadLine()!);
int[] array = GetArray(lenght);

PrintSum(array);