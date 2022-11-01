void FillArray(int[] collectiion)
{
    int length = collectiion.Length;
    int index = 0;
    while (index < length)
    {
        collectiion[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collectiion, int find)
{
    int count = collectiion.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collectiion[index] == find)
        {
            position = index;
            break;
        }

        index++;
    }

    return position;
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 3);
Console.WriteLine(pos)



int[] arr = {1,5,4,3,2,6,7};