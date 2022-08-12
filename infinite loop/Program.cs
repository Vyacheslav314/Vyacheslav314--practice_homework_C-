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
            name = EnterName();
            else
            {
                name = NameChange(name);
            }
            break;
        case "setpassword":
            if (password == null)
            {
                password = EnterPassword();
            }
            else
            {
                password = PasswordChange(password);
            }
            break;
        case "writename":
            Verificatin(name, password);
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

string NameChange(string userName)
{
string nameUser = userName;
    int inputAttempt = 1;

    while (inputAttempt <= 3)
    {
        inputAttempt++;
        string inputPassword = ReadInt("Введите пароль: ");
        if (inputPassword == password)
        {
            nameUser = ReadInt("Введите новое имя : ");
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
    return nameUser;
}

string PasswordChange(string userPassword)
{
    string userPass = userPassword;
    int inputAttempt = 1;

    while (inputAttempt <= 3)
    {
        inputAttempt++;
        string inputPassword = ReadInt("Введите пароль: ");
        if (inputPassword == password)
        {
            userPass = ReadInt("Введите новый пароль: ");
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
    return userPass;
}

void Verificatin(string usName, string usPass)
{
    string message = name;
    string password = usPass;
    int inputAttempt = 1;
    if (usName == null)
    {
        Console.WriteLine("Имя пользователя не назначено. Что бы узнать команду для назначения имени введите Help ");
        return;
    }
    if (usPass == null)
    {
        Console.WriteLine("Пароль не назначен. Что бы узнать команду для назначения пароля введите Help ");
        return;
    }
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
}


string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

