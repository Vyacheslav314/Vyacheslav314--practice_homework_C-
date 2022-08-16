int number = ReadInt("Введите первое число ");

Console.WriteLine("Сумма цифр в числе " + number + " равна " + SumElemNumber(number));

int SumElemNumber(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}