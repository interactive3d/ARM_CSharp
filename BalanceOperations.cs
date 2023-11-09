using System;

public static class BalanceOperations
{
	public static float myBalance = 1000f;
	public static string currency = "USD";

	public static void ShowMeMyBalance()
	{
        Console.WriteLine("=======================");
		Console.WriteLine("You current balance is: " + myBalance + " " + currency);
        Console.WriteLine("=======================");
        Console.WriteLine("Press any key to return to main menu");
		Console.ReadKey();
		MainOperationMenu.DisplayMainMenu();
    }
}
