int usdBalance = 10;
int rubBalance = 1000;
int euroBalance = 70;
int funtBalance = 50;

// равенство по отношению к условной единице: rub 1 к 1; usd 1 к 60; euro 1 к 70; funt 1 к 100;

int usdRate = 60;
int rubRate = 1;
int euroRate = 70;
int funtRate = 100;
bool isValid = true;

while (isValid)
{
    string message = ReadCommand("Введите команду ");

    switch (message.ToLower())
    {
        case "help":
            HelpCommand();
            break;
        case "balance":
            ShowBalance();

            break;
        case "convert":
            Console.WriteLine(Converter(SelectionCurency(), SelectionCurency()));
            break;
        case "exit":
            Console.WriteLine("программа завершена!!!");
            isValid = false;
            break;
        default:
            Console.WriteLine("Команда " + message + " несуществует ");
            break;
    }
}

double SelectionCurency()
{
    Console.WriteLine("Введите введите номер счета 1.usd 2.rub 3.euro. 4.funt ");
    double numberScore = Convert.ToDouble(Console.ReadLine());
    if(numberScore == 1)
    {
        return usdRate;
    }
    else if (numberScore == 2)
    {
        return rubRate;
    }
    else if (numberScore == 3)
    {
        return euroRate;
    }
    else if (numberScore == 4)
    {
        return funtRate;
    }
    return numberScore;
}

double Converter(double firstRateValut, double secondRateValut)
{
    double ratio = firstRateValut / secondRateValut;
    double result = ratio;
    return result;
}


void HelpCommand()
{
    Console.WriteLine("Введите Help для получение списка команд ");
    Console.WriteLine("Введите Balance, что бы увидеть баланс ваших счетов ");
    Console.WriteLine("Введите Convert, что бы сконвертировать одну валюту в другую ");
    Console.WriteLine("Введите Exit, что бы завершить работу программу ");
}

void ShowBalance()
{
    bool valid = true;
    while (valid)
    {
        string score = ReadCommand("Выберите кошелек 1.usd 2.rub 3.euro. 4.funt для выхода введите end ");

        switch (score)
        {
            case "1":
                Console.WriteLine("На вашем счёте находится " + usdBalance + " usd ");
                break;
            case "2":
                Console.WriteLine("На вашем счёте находится " + rubBalance + " rub ");
                break;
            case "3":
                Console.WriteLine("На вашем счёте находится " + euroBalance + " euro ");
                break;
            case "4": 
                Console.WriteLine("На вашем счёте находится " + funtBalance + " funt ");
                break;
            case "end":
                valid = false;
                break;
            default:
                Console.WriteLine("Такого счета нет ");
                break;
        }

    }
}

string ReadCommand(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}