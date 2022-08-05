Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("Число " + number + " Является четным ");
}
else
{
    Console.Write("Число " + number + " Не является четным ");

}