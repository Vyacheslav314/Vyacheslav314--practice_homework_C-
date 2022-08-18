int size = ReadCommand("Укажите длину массива ");
int[] array = new int[size];

FillRandomArray(array);
CounterNotEvenElemArray(array);
PrintArray(array);


int CounterNotEvenElemArray(int[] arr)
{
    int sumElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumElem += arr[i];
        }
    }
    Console.WriteLine(sumElem);
    return sumElem;
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
        arr[i] = new Random().Next(-10, 100);
    }
}


int ReadCommand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}