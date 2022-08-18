double usdBalance = 10;
double rubBalance = 1000;
double euroBalance = 70;
double gbpBalance = 50;

// равенство по отношению к условной единице: rub 1 к 1; usd 1 к 60; euro 1 к 70; funt 1 к 100;

int usdRate = 60;
int rubRate = 1;
int euroRate = 70;
int gbpRate = 100;
bool isValid = true;


while (isValid)
{
    string message = ReadCommand("Введите команду, либо введите Help что бы увидеть список команд: ");

    switch (message.ToLower())
    {
        case "help":
            HelpCommand();
            break;
        case "balance":
            ShowBalance();

            break;
        case "convert":
            int fromAccount = TakeScore();
            int onAccount = PutScore();
            double amountTransferred = Amount();
            double coefficient = RatioConverter(fromAccount, onAccount);
            double amountFinalCurrency = Math.Round(ConvertAmount(amountTransferred, coefficient), 2);
            ChangesBalanceFirstWallet(fromAccount, amountTransferred);
            ChangesBalanceFinalWallet(onAccount, amountFinalCurrency);
            Console.WriteLine("Вы хотите перевести " + amountFinalCurrency + " В конечной валюте! ");
            Console.WriteLine("Если вы ещё не закончили с переводами снова введите convert: ");
            
            
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

void ChangesBalanceFinalWallet(int onAcc, double amountCurrency)
{
    if (onAcc == usdRate)
    {
        if (usdBalance != 0)
        {
        usdBalance = usdBalance + amountCurrency;
        }
    }
    else if (onAcc == rubRate)
    {
        if (rubBalance != 0)
        {
        rubBalance = rubBalance + amountCurrency;
        }
    }
    else if (onAcc == euroRate)
    {
        if (euroBalance != 0)
        {
        euroBalance = euroBalance + amountCurrency;
        }
    }
    else if (onAcc == gbpRate)
    {
        if (gbpBalance != 0)
        {
        gbpBalance = gbpBalance + amountCurrency;
        }
    }
}

void ChangesBalanceFirstWallet(int fromAcc, double amountTransf)
{
    if (fromAcc == usdRate)
    {
        if (usdBalance >= amountTransf)
        {
            usdBalance = usdBalance - amountTransf; 
        }
        else
        {
            Console.WriteLine("На вашем счёте недостачно средств "); 
        }
    }
    else if (fromAcc == rubRate)
    {
        if (rubBalance >= amountTransf)
        {
            rubBalance = rubBalance - amountTransf; 
        }
        else
        {
            Console.WriteLine("На вашем счёте недостачно средств "); 
        }
    }
    else if (fromAcc == euroRate)
    {
        if (euroBalance >= amountTransf)
        {
            euroBalance = euroBalance - amountTransf; 
        }
        else
        {
            Console.WriteLine("На вашем счёте недостачно средств "); 
        }
    }
    else if (fromAcc == gbpRate)
    {
        if (gbpBalance >= amountTransf)
        {
            gbpBalance = gbpBalance - amountTransf; 
        }
        else
        {
            Console.WriteLine("На вашем счёте недостачно средств "); 
        }
    }
}

double ConvertAmount(double amount, double coef)
{
    double result = amount * coef;
    return result;
}

double Amount()
{
    double amount = Convert.ToDouble(ReadCommand("Сколько вы хотите перевести "));
    return amount;
}

int PutScore()
{
    Console.WriteLine("Введите номер счета на который хотите перевести средства: 1.usd 2.rub 3.euro. 4.funt ");
    int numberScore = Convert.ToInt32(Console.ReadLine());
    if (numberScore == 1)
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
        return gbpRate;
    }
    return numberScore;
}

int TakeScore()
{
    Console.WriteLine("Введите номер счета на который хотите перевести средства: 1.usd 2.rub 3.euro. 4.funt ");
    int numberScore = Convert.ToInt32(Console.ReadLine());
    if (numberScore == 1)
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
        return gbpRate;
    }
    return numberScore;
}

double RatioConverter(double firstRateValut, double secondRateValut)
{
    double ratio = firstRateValut / secondRateValut;
    return ratio;
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
                Console.WriteLine("На вашем счёте находится " + gbpBalance + " funt ");
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
