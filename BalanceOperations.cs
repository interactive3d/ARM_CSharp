using System;

public static class BalanceOperations
{
	public static float myBalance = 1000f;
	public static string currency = "USD";

	public static void ShowMeMyBalance()
	{
        Console.WriteLine("=======================");
		string balanceInfo = myBalance + " " + currency;

        Console.WriteLine(LanguageCommands.ATMessage("balnceIs") + balanceInfo);
        Console.WriteLine("=======================");
        Console.WriteLine(LanguageCommands.ATMessage("anyKey"));
		Console.ReadKey();
		MainOperationMenu.DisplayMainMenu();
    }
}
