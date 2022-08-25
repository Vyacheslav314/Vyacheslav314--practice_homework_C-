double b1 = ReadCommand("Введите точку b1: ");
double b2 = ReadCommand("Введите точку b2: ");
double k1 = ReadCommand("Введите точку k1: ");
double k2 = ReadCommand("Введите точку k2: ");
double x = (b2 - b1) / (k1 - k2);
if(k1 != k2)
{
double y = k1 * x + b1;
double y1 = k2 * x + b2;

Console.WriteLine(y1);
Console.WriteLine(y);
}
else
{
    Console.Write("Прямыe не пересекаются!!!");
}


double ReadCommand(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}