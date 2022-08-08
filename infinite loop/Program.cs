Console.WriteLine("Что бы завершить цикл введите exit ");
string endCyc = "exit";
int i = 0;
while (true)
{
    i++;
    string endCycle = Console.ReadLine();
    Console.WriteLine(i);

    if (endCycle.ToLower() == endCyc)
    {

        break;

    }

}
