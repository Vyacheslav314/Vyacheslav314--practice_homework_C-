int number = ReadInt("Введите первое число ");
int size = ElemDigitsInNumber(number);
int[] array = new int[size];
FillInArray(array, number);

Console.WriteLine(SumElemArray(array));

int SumElemArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

void FillInArray(int[] arr, int numb)
{

    for (int i = 0; i < arr.Length; i++)
    {
        int partNumber = numb % 10;
        numb /= 10;
        arr[i] = partNumber;
    }
}

int ElemDigitsInNumber(int num)
{
    int digit = 0;
    while (num > 0)
    {
        num /= 10;
        digit++;
    }
    return digit;
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}