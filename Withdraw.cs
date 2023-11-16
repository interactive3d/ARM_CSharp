using System;

public static class Withdraw
{
	
	public static void WithdrawMoney()
	{
		float currentBallance = BalanceOperations.myBalance;
		Console.WriteLine("How much would you like to withdraw");
        float amountToWithDraw = 0f;

        try
        {
            amountToWithDraw = (float)Convert.ToDouble(Console.ReadLine());
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        if (amountToWithDraw > currentBallance)
        {
            Console.WriteLine("Not enough money on the account");
        } else
        {
            currentBallance -=amountToWithDraw; // store balance as property
            ChangeValueToChash((int) amountToWithDraw);
        }
    }
    public static void ChangeValueToChash(int totalCash)
    {
        int bills100 = totalCash / 100;
        totalCash = totalCash - (bills100 * 100);
        int bills50 = totalCash / 50;
        totalCash = totalCash - (bills50 * 50);
        int bills20 = totalCash / 20;
        totalCash = totalCash - (bills20 * 20);
        int bills10 = totalCash / 10;
        totalCash = totalCash - (bills10 * 10);
        int bills5 = totalCash / 5;
        totalCash = totalCash - (bills5 * 5);
        int bills2 = totalCash / 2;
        totalCash = totalCash - (bills2 * 2);
        int bills1 = totalCash / 1;
        totalCash = totalCash - (bills1 * 1);
        Console.WriteLine(
            $"Withdraw in following " +
            $"\n\t$100 \t* \t{bills100}" +
            $"\n\t$50 \t* \t{bills50}" +
            $"\n\t$20 \t* \t{bills20}" +
            $"\n\t$10 \t* \t{bills10}" +
            $"\n\t$5 \t* \t{bills5}" +
            $"\n\t$2 \t* \t{bills2}" +
            $"\n\t$1 \t* \t{bills1}"
            );
    }
}
