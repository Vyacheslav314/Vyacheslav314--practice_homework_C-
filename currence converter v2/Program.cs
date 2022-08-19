double[] balance = { 15, 1000, 50 };
double[] course = { 60, 1, 70 };
bool isValid = true;

while (isValid)
{
    int firstAcc = 0;
    int secondAcc = 0;
    double firstRate = 0;
    double secondRate = 0;
    string command = ReadString("Введите команду или введите Help, что бы увидеть список команд: ");
    switch (command.ToLower())
    {
        case "help":
            ShowHelp();
            break;
        case "balance":
            ShowBalance();
            break;
        case "convert":
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    int numberScore = ReadCommand("Укажите счёт с которого необходимо перевести средства: 0.usd 1.rub 2.eur ");
                    if (numberScore >= balance.Length)
                    {
                        firstAcc = -1;
                        Console.WriteLine("Указанного кошелька не существует! Попробуйте снова ");
                        goto case "convert";
                    }
                    firstAcc = SelectingAccount(balance, numberScore);
                    firstRate = SelectingCofficient(course, numberScore);
                }
                else if (i == 1)
                {
                    int numberScore = ReadCommand("Укажите счёт на который необходимо перевести средства: 0.usd 1.rub 2.eur ");
                    if (numberScore >= balance.Length)
                    {
                        secondAcc = -1;
                        Console.WriteLine("Указанного кошелька не существует! Попробуйте снова ");
                        goto case "convert";
                    }
                    secondAcc = SelectingAccount(balance, numberScore);
                    secondRate = SelectingCofficient(course, numberScore);
                }
            }

            if (firstAcc == secondAcc)
            {
                Console.WriteLine("Указанные кошельки совпадают! Попробуйте снова ");
                goto case "convert";
            }

            double amount = Convert.ToDouble(ReadCommand("Укажите сумму перевода "));
            double result = CalcelationCoefficient(firstRate, secondRate);
            double resultConvert = 0;
            if (balance[firstAcc] > 0)
            {
                resultConvert = ResultConvert(result, amount);
            }
            ChangingFirstAccount(balance, firstAcc, amount);
            ChangingFinalAccount(balance, secondAcc, resultConvert);
            break;
        case "exit":
            Console.WriteLine(
                "Программа завершена !!!!\nСпасибо что воспользовались нашими услугами!"
            );
            isValid = false;
            break;
        default:
            Console.WriteLine(
                "Команды "
                    + command
                    + " несуществует. Введите Help, что бы увидеть список команд!!! "
            );
            break;
    }
}

void ShowHelp()
{
    Console.WriteLine("Введите Balance, что бы увидеть баланс кошельков ");
    Console.WriteLine("Введите Convert, что бы осуществить перевод валюты между кошельками ");
    Console.WriteLine("Введите Exit, что бы завершить работу программы ");
}

void ChangingFinalAccount(double[] arrBalance, int secondAccount, double resultConv)
{
    for (int i = 0; i < arrBalance.Length; i++)
    {
        if (i == secondAccount)
        {
            arrBalance[i] = arrBalance[i] + resultConv;
        }
    }
}

void ChangingFirstAccount(double[] arrBalance, int firstAccount, double amountСurrency)
{
    for (int i = 0; i < arrBalance.Length; i++)
    {
        if (i == firstAccount)
        {
            if (arrBalance[i] <= 0 || amountСurrency > arrBalance[i])
            {
                Console.WriteLine("На вашем счете недостаточно средств!!! ");
                return;
            }
            arrBalance[i] = arrBalance[i] - amountСurrency;
        }
    }
}

double ResultConvert(double coeff, double amountСurrency)
{
    double resultConv = amountСurrency * coeff;
    return resultConv;
}

double CalcelationCoefficient(double firstRate, double secondRate)
{
    double result = firstRate / secondRate;
    return result;
}

double SelectingCofficient(double[] arrCoef, int numScore)
{
    double coeff = 0;
    for (int i = 0; i < arrCoef.Length; i++)
    {
        if (i == numScore)
        {
            coeff = arrCoef[i];
        }
    }
    return coeff;
}

int SelectingAccount(double[] arrBalance, int numScore)
{
    int balance = 0;
    for (int i = 0; i < arrBalance.Length; i++)
    {
        if (i == numScore)
        {
            balance = i;
        }
    }
    return balance;
}

void ShowBalance()
{
    Console.WriteLine("На вашем счёте находится " + balance[0] + " USD ");
    Console.WriteLine("На вашем счёте находится " + balance[1] + " RUB ");
    Console.WriteLine("На вашем счёте находится " + balance[2] + " EUR ");
}

int ReadCommand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string ReadString(string mess)
{
    Console.Write(mess);
    return Console.ReadLine();
}
