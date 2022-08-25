string separatedNumbers = ReadCommand("Введите числа через запятую: ");
int countComma = CommaCounter(separatedNumbers);
string[] substring = new string[countComma];
int count = 0;

WritingStringArray(substring, separatedNumbers);
PrintArray(substring);

int CommaCounter(string number)
{
    int count = 1;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] == ',')
        {
            count++;
        }
    }
    return count;
}

for (int i = 0; i < substring.Length; i++)
{
    if (Convert.ToInt32(substring[i]) > 0)
    {
        count++;
    }
}

Console.WriteLine($"Елементов в троке больше 0 ==> {count} ");

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void WritingStringArray(string[] array, string number)
{
    int startIndex = 0;
    for (int i = 0; i < separatedNumbers.Length; i++)
    {
        if (separatedNumbers[i] != ',')
        {
            substring[startIndex] += separatedNumbers[i];
        }
        else
        {
            startIndex++;
        }
    }
}

string ReadCommand(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
