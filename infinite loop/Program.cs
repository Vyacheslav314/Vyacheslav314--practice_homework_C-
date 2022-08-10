string message = ReadInt("Введите help  что увидеть список команд: ");
string userName = null;
string password = null;

while (true)
{
    if (message == "Help")
    {
        HelpCommand();
    }
    if (message == "SetName")
    {
        userName = SetName();
    }
    if (message == "SetPassword")
    {
        password = SetPassword();
    }
    if (message == "WriteName")
    {
        Verificatin(userName, password);
    }
    if (message == "Exit")
    {
        Console.WriteLine("программа завершена!!!");
        break;
    }
    else
    {
        message = ReadInt("Введите следующую команду: ");
    }
}


void Verificatin(string str, string str1)
{
    string message = str;
    string password = str1;
    int inputAttempt = 1;

    while (inputAttempt <= 3)
    {
        inputAttempt++;
        string inputPassword = ReadInt("Введите пароль ");
        if (inputPassword == password)
        {
            Console.WriteLine(message);
            break;
        }
        if(str == null)
        {
          Console.WriteLine("Имя пользователя не назначено. Что бы узнать команду для назначения имени введите Help ");
          break;   
        }
        if(str1 == null)
        {
            Console.WriteLine("Пароль не назначен. Что бы узнать команду для назначения пароля введите Help ");
            break;
        }
        else if (inputPassword != password && inputAttempt <= 3)
        {
            Console.WriteLine("Вы ввели неверный пароль. Попробуйте еще раз: ");
        }
        if (inputAttempt > 3)
        {
            Console.WriteLine("Превышенно колличество попыток ");
        }
    }
}

string SetPassword()
{
    string pass = ReadInt("Создайте пароль ");
    return pass;
}

string SetName()
{
    string setUserName = ReadInt("Введите ваше имя: ");
    return setUserName;
}

void HelpCommand()
{
    Console.WriteLine("Введите SetName что бы указать имя пользователя: ");
    Console.WriteLine("Введите SetPassword что бы внести пароль: ");
    Console.WriteLine("Введите exit что бы завершить программу: ");
    Console.WriteLine("Введите WriteName что бы показать имя пользователя: ");
}



string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

