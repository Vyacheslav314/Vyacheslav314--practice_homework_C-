Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.Write("Первое число " + firstNumber + " Больше чем " + "Второе число " + secondNumber);
}
else if(firstNumber < secondNumber)
{
     Console.Write("Второе  число " + secondNumber + " Больше чем " + "Первое число " + firstNumber);
}
else
{
     Console.Write("Второе число " + secondNumber + " Равно " + "Первому числу " + firstNumber);
}