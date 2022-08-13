int number = ReadInt("введите пятизначное число: ");
int temp = number;
int number1 = 0;
int sum = 0;
int index = 0;

while(number != 0)
{
    number1 = number % 10;
    number = number / 10;
    sum = sum * 10 + number1;
    index++;
    
}
if(index > 5 || index < 5)
{
    Console.Write("Число не пятизначное ");
}
else if(sum == temp)
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