int number = ReadInt("введите число для проверки его на палиндром: ");
int temp = number;
int number1 = 0;
int sum = 0;

while(number != 0)
{
    number1 = number % 10;
    number = number / 10;
    sum = sum * 10 + number1;
    
}

if(sum == temp)
{
    Console.Write("палиндром");
}
else
{
    Console.Write("Не палиндром");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}