int[] array = { 1, 5, 7, 8 };

PrintArray(array);
Console.WriteLine();
PrintArray(AddToArray(array));
Console.WriteLine();
PrintArray(RemoveFromArray(array));

int[] RemoveFromArray(int[] arr)
{
    int[] newArray = new int[arr.Length - 1];
    int number = ReadCommand("Укажите индекс который нужно удалить ");
    for (int i = 0; i < number; i++)
    {
        newArray[i] = arr[i];
    }
    for (int j = number + 1; j < newArray.Length + 1; j++)
    {
        newArray[j - 1] = arr[j];
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] AddToArray(int[] arr)
{
    int[] newArray = new int[arr.Length + 1];
    int number = ReadCommand("Введите число которое хотите добавить в массив ");
    for (int i = 0; i < newArray.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (i >= j)
            {
                newArray[i] = arr[j];
            }
        }
        newArray[arr.Length] = number;
    }
    return newArray;
}

int ReadCommand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
