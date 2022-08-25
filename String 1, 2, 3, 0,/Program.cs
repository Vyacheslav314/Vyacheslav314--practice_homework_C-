string separatedNumbers = ReadCommand("Введите числа через запятую: ");
string[] substring = new string[separatedNumbers.Length];
int startIndex = 0;
int count = 0;

WritingStringArray(substring, separatedNumbers);

for (int i = 0; i < substring.Length; i++)
{
    if(Convert.ToInt32(substring[i]) > 0)
    {
        count++;
    }
}
Console.WriteLine(count);

void WritingStringArray(string[] Array, string number)
{
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
