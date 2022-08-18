int size = ReadCommand("Укажите длину массива ");
double[] array = new double[size];

FillRandomArray(array);
DiffernceMiAndMaxElemArray(array);
PrdobleArray(array);


double DiffernceMiAndMaxElemArray(double[] arr)
{
    double minElem = arr[0];
    double maxElem = arr[0];
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (minElem > arr[i])
        {
            minElem = arr[i];
        }
        else if (maxElem < arr[i])
        {
            maxElem = arr[i];
        }
    }
    double diffMinMax = maxElem - minElem;
    Console.WriteLine(diffMinMax);
    return Math.Round(diffMinMax, 2);
}


void PrdobleArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void FillRandomArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * (10.0 - (-10.0)) + (-10.0), 2);
    }
}


int ReadCommand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}