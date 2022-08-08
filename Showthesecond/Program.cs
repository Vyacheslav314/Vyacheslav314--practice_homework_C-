int number = ReadInt("Введите число от 100 до 999: ");

Console.Write(ShowToSecond(number));

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
