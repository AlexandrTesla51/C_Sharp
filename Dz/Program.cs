string[] NewArray(string[] array)
{
    string[] massive = new string[6];
    int j = 0;
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i].Length <= 3)
        {
            massive[j] = array[i];
            j++;
        }
    }

    return massive;
}

void PrintArray(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write(massive[i] + " ");
    }
}

string[] array = { "hello", "23", "Sun", "12", "Ti", "Veles" };


PrintArray(NewArray(array));