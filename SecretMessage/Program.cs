string message = "Какой чудесный день ";
string password = "123qwe";
int inputAttempt = 1;



    
while (inputAttempt <= 3)
{
    inputAttempt++;
    Console.Write("Введите пароль ");
    string inputPassword = Console.ReadLine();
    if (inputPassword == password)
{
    Console.WriteLine(message);
    break ;
}
else if (inputPassword != password)
{
    Console.WriteLine("Вы ввели неверный пароль. Попробуйте еще раз: ");
}
if (inputAttempt > 3)
{
    Console.WriteLine("Превышенно колличество попыток ");
}
}
    

    
