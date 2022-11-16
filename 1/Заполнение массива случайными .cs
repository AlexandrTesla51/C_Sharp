int[] massive = GetArray(12); 
PrintArray(massive);

int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }

    return array;
}


void PrintArray(int[] array)
{
    foreach (int el in array)
    {
        Console.Write(el + " ");
    }
}