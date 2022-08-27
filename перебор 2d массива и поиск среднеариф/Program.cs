int row = ReadInt("Введите колчиство строк ");
int colums = ReadInt("Введите количетсво столбцов ");
int[,] array = new int[row, colums];
FillRandomNumbers2D(array);
Console.WriteLine();
PrintArray(array);
ArifmeticMiddleColums(array);
Console.WriteLine();


void ArifmeticMiddleColums(int[,] array)
{
    double sumCol = 0;
    double arifmeticMiddle = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumCol += array[j, i];
        }
        arifmeticMiddle = sumCol / array.GetLength(1);
        Console.Write(
            $"Средне арифметическое столбца c индексом {i}: {Math.Round(arifmeticMiddle, 1)}\n"
        );
        sumCol = 0;
    }
}
void PrintArray(int[,] array1)
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

void FillRandomNumbers2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
