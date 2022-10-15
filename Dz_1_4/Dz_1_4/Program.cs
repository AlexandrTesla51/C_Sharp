Console.Write("Введите число: ");
int digit = int.Parse(Console.ReadLine()!);
int count = 1;
    while (count <= digit)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
        }
        count++;
    }


    
