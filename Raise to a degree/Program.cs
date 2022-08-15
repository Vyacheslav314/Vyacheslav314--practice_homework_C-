int firstNumber = ReadInt("Введите первое число ");
int secondNumber = ReadInt("Введите второе число ");
int result = firstNumber;

for (int i = 1; i < secondNumber; i++)
{
    result *= firstNumber;
}

Console.Write(result);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}