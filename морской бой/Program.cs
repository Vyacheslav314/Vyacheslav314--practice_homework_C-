string number = ReadInt(
    "Введите 2х значное число где первый элемент это индекс строки а второй индекс столбца "
);
int[,] arrayNumber2D = new int[3, 4];
string subString = string.Empty;
FillRandomNumbers2D(arrayNumber2D);
PrintArray(arrayNumber2D);
int row = 0;
int col = 0;

for (int i = 0; i < number.Length; i++)
{
    if (i == 0)
    {
        subString += number[i];
        row = Convert.ToInt32(subString);
        subString = string.Empty;
    }
    else if (i == 1)
    {
        subString += number[i];
        col = Convert.ToInt32(subString);
    }
}
SearchArrayIndex(arrayNumber2D, row, col);
void SearchArrayIndex(int[,] array, int row, int col)
{
    if (row < arrayNumber2D.GetLength(0) && col < arrayNumber2D.GetLength(1))
    {
        for (int i = 0; i < arrayNumber2D.GetLength(0); i++)
        {
            for (int j = 0; j < arrayNumber2D.GetLength(1); j++)
            {
                if (i == row && j == col)
                {
                    Console.WriteLine(arrayNumber2D[i, j]);
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Такого элемента нет ");
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

string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
