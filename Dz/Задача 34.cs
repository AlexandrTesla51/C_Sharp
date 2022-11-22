// Урок 5
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2");

int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }

    return array;
}

void PrintArray(int[] array)
{
    int sum = 0;
    foreach (int el in array)
    {
        Console.Write(el + " ");
        if(el%2==0) sum += 1;
    }
    Console.WriteLine();
    Console.Write($"Колличество четных элементов в массиве равна: {sum}");
}

Console.WriteLine("Введите длину массива");
int lenght = int.Parse(Console.ReadLine()!);
int[] array = GetArray(lenght);

PrintArray(array);