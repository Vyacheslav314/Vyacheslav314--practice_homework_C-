<<<<<<< HEAD
﻿Console.WriteLine("Что бы завершить цикл введите exit ");
=======
Console.WriteLine("Что бы завершить цикл введите exit ");
>>>>>>> c1c475e4254bbc425ed1df820e8e96e03ab4cbd3

string endCyc = "exit";
int i = 0;
while (true)
{
    i++;
    string endCycle = Console.ReadLine();
    Console.WriteLine(i);
    
    if (endCycle.ToLower() == endCyc)
    {
        
        break ;
                
    }
    
}
