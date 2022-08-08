int number = ReadInt("Введите число от 0 до 10 ");
int value = new Random().Next(0, 10);
int numberAttempts = 3;
int index = 1;

while (index <= numberAttempts)
{
    index++;
    if (number > value)
    {
        Console.WriteLine(number + " Больше загаданного числа." + " Поробуйте еще раз: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    if (number < value)
    {
        Console.WriteLine(number + " меньше загаданного числа." + " Поробуйте еще раз: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    if (number == value) 
    {
        Console.WriteLine("Поздравляю это правельный ответ ");
        break;
    }
    if (index == numberAttempts)
    {
        Console.WriteLine("Превышенно количество попыток ");
        break;
    }  
}

int ReadInt(string message)
{
    Console.WriteLine(message);   
    return Convert.ToInt32(Console.ReadLine());
}