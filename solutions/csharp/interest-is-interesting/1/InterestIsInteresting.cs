static class SavingsAccount
{
    public static float InterestRate(decimal balance) => 
        balance switch
        {
            < 0m => 3.213f,
            < 1000m => 0.5f,
            < 5000m => 1.621f,
            _ => 2.475f
        };
    
    // public static float InterestRate(decimal balance)
    // {
    //     switch(balance)
    //     {
    //         case decimal b when b < 0:
    //             return 3.213f;
    //         case decimal b when b >= 0 && b < 1000:
    //             return 0.5f;
    //         case decimal b when b >= 1000 && b < 5000:
    //             return 1.621f;
    //         case decimal b when b >= 5000:
    //             return 2.475f;
    //         default:
    //             return 0.0f;
    //     }
    // }

    public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        if (balance >= targetBalance)
            return 0;
        int years = 0;
        do
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        } while (balance < targetBalance);
        return years;
    }
}
