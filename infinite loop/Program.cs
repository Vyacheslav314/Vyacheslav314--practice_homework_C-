string name = null;
string password = null;
bool isValid = true;

while (isValid)
{
    string message = ReadInt("Введите команду, либо введите Help, что бы увидеть список команд: ");

    switch (message.ToLower())
    {
        case "help":
            HelpCommand();
            break;
        case "setname":
            if (name == null)
            {
                name = EnterName();
            }
            else
            {
                Console.WriteLine("Ваше имя записано ");
            }
            break;
        case "setpassword":
            if (password == null)
            {
                password = EnterPassword();
            }
            else
            {
                Console.WriteLine("Ваш пароль уже создан ");
            }
            break;
        case "writename":
            if (name == null)
            {
                Console.WriteLine("Имя пользователя не назначено. Что бы узнать команду для назначения имени введите Help ");
                break;
            }
            if (password == null)
            {
                Console.WriteLine("Пароль не назначен. Что бы узнать команду для назначения пароля введите Help ");
                break;
            }
            Verificatin(name, password);
            break;
        case "changeuser":
            if (name != null && password != null)
            {
                Verificatin(name, password);
                Console.WriteLine("Введите новые данные ");
                name = EnterName();
                password = EnterPassword();
            }
            else
            {
                Console.WriteLine("Имя пользователя или пароль не назначены ");
            }
            break;

        case "exit":
            Console.WriteLine("программа завершена!!!");
            isValid = false;
            break;
        default:
            {
                Console.WriteLine("Команда " + message + " несуществует ");
                break;
            }
    }
}


void Verificatin(string usName, string usPass)
{
    string message = name;
    string password = usPass;
    int inputAttempt = 1;

    while (inputAttempt <= 3)
    {
        inputAttempt++;
        string inputPassword = ReadInt("Введите пароль ");

        if (inputPassword == password)
        {
            Console.WriteLine("Здравствуйте " + message);
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


string EnterPassword()
{
    string pass = ReadInt("Создайте пароль ");
    return pass;
}


string EnterName()
{
    string setUserName = ReadInt("Введите ваше имя: ");
    return setUserName;
}


void HelpCommand()
{
    Console.WriteLine("Введите SetName что бы указать имя пользователя: ");
    Console.WriteLine("Введите SetPassword что бы создать пароль: ");
    Console.WriteLine("Введите Exit что бы завершить программу: ");
    Console.WriteLine("Введите WriteName что бы показать имя пользователя: ");
    Console.WriteLine("Введите ChangeUser что сменить имя и пароль: ");
}


string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

