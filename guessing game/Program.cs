Console.WriteLine("Введите число от 0 до 10 ");
int number = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int value = rnd.Next(0, 10);
int numberAttempts = 3;
int index = 0;

while (index != numberAttempts)
{
    if (number > value)
    {
        Console.WriteLine(number + " Больше загаданного числа");
        number = Convert.ToInt32(Console.ReadLine());
    }
    else if (number < value)
    {
        Console.WriteLine(number + " меньше загаданного числа");
        number = Convert.ToInt32(Console.ReadLine());
    }
    else 
    {
        Console.WriteLine("Поздравляю это правельный ответ ");
        break;
    }     
    index++;
    if (index == numberAttempts)
    {
        Console.WriteLine("Превышенно количество попыток ");
        break ;
    }   
}


