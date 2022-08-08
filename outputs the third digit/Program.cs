int number = ReadInt("Введите число: ");
int res = NumberLength(number);
int result = ShowToThird(number, res);

if (res >= 3)
{
    Console.WriteLine("третье цифра в числе " + result);
}
else
{
    Console.Write("В это числе нет третьей цифры");
}

int NumberLength(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int ShowToThird(int num, int len)
{
    while (len > 3)
    {
        num = num / 10;
        len--;

    }
    return num % 10;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
