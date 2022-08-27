int row = ReadInt("Введите колчиство строк ");
int colums = ReadInt("Введите количетсво столбцов ");
double[,] array = new double[row, colums];
FillRandomNumbers2D(array);
Console.WriteLine();
PrintArray(array);


void PrintArray(double[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillRandomNumbers2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (10.0 - (-10.0)) + (-10.0), 1);
        }
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
