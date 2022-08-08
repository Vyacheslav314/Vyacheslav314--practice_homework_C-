int number = ReadInt("Введите число от 100 до 999: ");
int result = ShowToSecond(number);

if (number > 100 && number < 1000)
{
    Console.Write(result);
}
else
{
    Console.Write("Введено некорректное число: ");
}

int ShowToSecond(int num)
{
    int div = num / 10;
    int remainderDiv = div % 10;
    return remainderDiv;
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
