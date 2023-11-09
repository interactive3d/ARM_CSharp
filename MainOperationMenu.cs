using System;

public static class MainOperationMenu
{
    public static void DisplayMainMenu()
    {
        Console.WriteLine("=======================");
        Console.WriteLine(LanguageCommands.ATMessage("operWhat"));
        Console.WriteLine("=======================");
        Console.WriteLine(LanguageCommands.ATMessage("operBalance"));
        Console.WriteLine(LanguageCommands.ATMessage("operCash"));
        Console.WriteLine(LanguageCommands.ATMessage("operPin"));
        Console.WriteLine(LanguageCommands.ATMessage("operEnd"));
        string optionSelected = Console.ReadLine();
        if (optionSelected == "1")
        {
            BalanceOperations.ShowMeMyBalance();
        }
        else if (optionSelected == "2")
        {

        }
        else if (optionSelected == "3")
        {
            PinOperations.ChangeThePin();
        }
        else if (optionSelected == "4")
        {

        }
        else { 

        }
    }

}
