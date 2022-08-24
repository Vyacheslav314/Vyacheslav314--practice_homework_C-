string separatedNumbers = ReadCommand("Введите числа через запятую: ");
string[] substring = new string[separatedNumbers.Length];
int[] numbers = new int[substring.Length];
int startIndex = 0;
int numberlength = 0;
int count = 0;

for (int i = 0; i < separatedNumbers.Length; i++)
{
    numberlength++;
    if (separatedNumbers[i] != ',')
    {
        for (int j = startIndex; j < numberlength; j++)
        {
            
            substring[startIndex] += Convert.ToString(separatedNumbers[i]);
            j++;
        }
    }
    if(separatedNumbers[i] == ',')
    {
    startIndex = i;
    }
}

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(substring[i]);

}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0) count++;
}

PrintArray(substring);

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ".");
    }
}


string ReadCommand(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
