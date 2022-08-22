int[] array = { 1, 5, 7, 8 };
int number = ReadCommand(
    "Введите 1 что бы добавить элемент массива. Введите 2 что удалить элемнт массива "
);

PrintArray(array);

switch (number)
{
    case 1:
        int addedElem = ReadCommand("Введите число которое хотите добавить в массив ");
        PrintArray(AddToArray(array, addedElem));
        break;
    case 2:
        int delIndex = ReadCommand("Укажите индекс массива который нужно удалить ");
        PrintArray(RemoveFromArray(array, delIndex));
        break;
}

int[] RemoveFromArray(int[] arr, int index)
{
    int[] newArray = new int[arr.Length - 1];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < index)
        {
            newArray[i] = arr[i];
        }
        else if (i >= index)
        {
            newArray[i] = arr[i + 1];
        }
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

int[] AddToArray(int[] arr, int addElem)
{
    int[] newArray = new int[arr.Length + 1];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < arr.Length)
        {
            newArray[i] = arr[i];
        }
    }
    newArray[arr.Length] = addElem;
    return newArray;
}

int ReadCommand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
