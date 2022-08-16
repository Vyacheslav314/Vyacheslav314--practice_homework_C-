int size = ReadInt("Укажите длину массива ");
int[] array = new int[size];

FillingArray(array, size);
PrintArray(array);

void PrintArray(int[] arr1)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(arr1[i] + " ");
    }
}

void FillingArray(int[] arr, int sizeArray)
{
    for (int i = 0; i < sizeArray; i++)
    {
        arr[i] = ReadInt("Введите слeдующий элемент массива ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}