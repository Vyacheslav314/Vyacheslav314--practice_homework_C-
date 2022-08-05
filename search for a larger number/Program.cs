Console.WriteLine("Введите первое числ: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.Write("Число " + firstNumber + " Самое большое");
}
else if (firstNumber < secondNumber && secondNumber > thirdNumber)
{
    Console.Write("Число " + secondNumber + " Самое большое");
}
else if (thirdNumber > secondNumber && firstNumber < thirdNumber)
{
    Console.Write("Число " + thirdNumber + " Самое большое");
}
else
{
    Console.Write("Все числа равны");
}
