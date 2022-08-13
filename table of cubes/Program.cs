int number = ReadInt("Введите число n: ");

for(int i = 1; i <= number; i++)
{
int resultCubes = i * i * i;
Console.Write(resultCubes + " ");
}

int ReadInt(string message)
{
    Console.Write(message);   
    return Convert.ToInt32(Console.ReadLine());
}
