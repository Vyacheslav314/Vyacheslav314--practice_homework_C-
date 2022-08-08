int dayNumber = ReadInt("Введите цифру от 1 до 7: ");
bool dayWeekend = Weekend(dayNumber);

if (dayWeekend)
{
    Console.Write("Этот день выходной ");
}
else if (dayNumber <= 5)
{
    Console.Write("Этот день не выходной ");
}
else
{
    Console.Write("Нет такого дня ");
}

bool Weekend(int a)
{
    bool boolean = true;
    if (a == 6 || a == 7)
    {
        boolean = true;
    }
    else
    {
        boolean = false;
    }
    return boolean;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
