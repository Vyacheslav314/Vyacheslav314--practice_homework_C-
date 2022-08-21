int[,] tetris = new int[,]
{
    { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
};

PrintArray(tetris);
MovementFigures(1, 7);

void MovementFigures(int row, int col)
{
    if (tetris[row, col] == 0)
    {
        tetris[row, col] = 1;
        int comm = Convert.ToInt32(Console.ReadLine());
        PrintArray(tetris);
        bool isValid = true;
        while(isValid)
        {
        switch (comm)
        {
            case 1:
                MovementFigures(row++, col++);
                PrintArray(tetris);
                break;
            case 2:
                MovementFigures(row++, col--);
                
                PrintArray(tetris);
                break;
                case 3:
                isValid = false;
                break;
        }
        }
    }
}

void PrintArray(int[,] tet)
{
    for (int i = 0; i < tet.GetLength(0); i++)
    {
        for (int j = 0; j < tet.GetLength(1); j++)
        {
            if (tet[i, j] == 0)
            {
                Console.Write($" ");
            }
            else
            {
                Console.Write($"+");
            }
        }
        Console.WriteLine();
    }
}
