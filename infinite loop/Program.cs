Console.WriteLine("Что бы завершить цикл введите exit ");
string endCycle = Console.ReadLine();

while (endCycle != "exit")
{
    endCycle = Console.ReadLine();
    if (endCycle == "exit")
    {
        Console.WriteLine("УСПЕХ!!!!! ");
    }
    
}