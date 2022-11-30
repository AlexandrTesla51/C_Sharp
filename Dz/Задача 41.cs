// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
// чисел больше  0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] Array(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"Введите {i + 1}е число");
        array[i] = int.Parse(Console.ReadLine()!);
    }

    return array;
}

void Summ(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += 1;
    }
    Console.WriteLine($"Количество ненуливых чисел равна {sum}");
}


Console.WriteLine("Введите каколичество вводимых чисел");
int number = int.Parse(Console.ReadLine()!);
int[] massive = Array(number);
Summ(massive);