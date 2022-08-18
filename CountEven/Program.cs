int size = ReadCommand("Укажите длину массива ");
int[] array = new int[size];

FillRandomArray(array);
CounterEvenArray(array);
PrintArray(array);


int CounterEvenArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
    return count;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void FillRandomArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}


int ReadCommand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}