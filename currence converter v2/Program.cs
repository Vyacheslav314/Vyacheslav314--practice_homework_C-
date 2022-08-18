// под индексом 0 находится сумма средств на счете. под индексом 1 находится коэффициэнт по отношению к условной единице
double[] usd = { 15, 60 };
double[] rub = { 1000, 1 };
double[] eur = { 50, 70 };
double[] gbp = { 66, 100 };
double[] byn = { 200, 5 };

ShowBalance();

double firstAcc = 0;
double secondAcc = 0;

for (int i = 0; i <= 2; i++)
{
    if(i == 0)
    {
    int firstScore = ReadCommand("Укажите кошелёк C который необходимо перевести средства: 1.usd 2.rub 3.eur 4.gbp 5.byn ");
    firstAcc = SelectingAccount(firstScore);
    }
    else if(i == 1)
    {
        int secondScore = ReadCommand("Укажите кошелёк на который необходимо перевести средства: 1.usd 2.rub 3.eur 4.gbp 5.byn ");
    secondAcc = SelectingAccount(secondScore);
    }
    
}

//double CalcelationCofficient()

double SelectingAccount(int score)
{
    if(score == 1)
    {
       return usd[0];
    }
    else if (score == 2)
    {
        return rub[0];
    }
    else if (score == 3)
    {
        return eur[0];
    }
    else if (score == 4)
    {
        return gbp[0];
    }
    else if (score == 5)
    {
        return byn[0];
    }
    return score;
}


void ShowBalance()
{
    Console.WriteLine("На вашем счёте находится " + usd[0] + " USD ");
    Console.WriteLine("На вашем счёте находится " + rub[0] + " RUB ");
    Console.WriteLine("На вашем счёте находится " + eur[0] + " EUR ");
    Console.WriteLine("На вашем счёте находится " + gbp[0] + " GBP ");
    Console.WriteLine("На вашем счёте находится " + byn[0] + " BYN ");
}

int ReadCommand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
