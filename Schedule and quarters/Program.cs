int number = ReadInt("введите число n:");
int index = 1;

while(number >= index)
{
    int result = index * index;
    Console.Write(result + " ");
    index++; 
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
