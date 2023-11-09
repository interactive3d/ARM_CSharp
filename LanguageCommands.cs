using System;
using System.Collections.Generic;

public class LanguageCommands
{
    public LanguageCommands()
    {
    }

    public static string[] country = { "EN", "PL" }; // this is the list of possible languages;
    public static string currentLanguage = country[0];

    
    public void ChooseDifferentLanguage(){
        Console.WriteLine("=======================");
        Console.WriteLine("Please choose one of the following languages:");
        Console.WriteLine("=======================");
        Console.WriteLine("1. English");
        Console.WriteLine("2. Polish");
        string languageSelected = Console.ReadLine();
        switch (languageSelected)
        {
            case "1":
                ChangeLanguage("EN");
                break;
            case "2":
                ChangeLanguage("PL");
                break;
            default:
                ChangeLanguage("EN");
                break;
        }
    }

    public static void ChangeLanguage(string code)
    {
        int index = Array.IndexOf(country, code);  // check if the code exist as element of the country array
        if (index != -1) // if that exist then gets it ID
        {
            currentLanguage = country[index]; // assign the id of the country[ID] to currentLanguage
            switch (currentLanguage)
            {
                case "EN":
                    Console.WriteLine("Language changed to English");
                    break;
                case "PL":
                    Console.WriteLine("Zmieniono język na polski");
                    break;
            }
        }
        else
        {
            currentLanguage = country[0]; // change to default English
        }
    }
    public void DeclareCommands()
    {
        var atmCommandsEN = new Dictionary<string, string>()
        {
            {"welcome", "Welcome to the ATM"},
            {"typePin", "Please type your PIN number: "},
            {"pinOK", "PIN is correct" },
            {"pinWRONG", "PIN is incorrect" },
            {"newPINType", "Type your new PIN: " },
            {"newPin4D", "Pin need to consist of 4 digits only" },
            {"newPinContinue", "Do you still want to change the PIN (Y/N): " },
            {"backToMain", "Back to operations" },
            {"newPinSuccess", "New PIN was succesfully saved" },
            {"operWhat", "What would you like to do?" },
            {"operBalance", "1. Check balance" },
            {"operCash", "2. Withdraw cash" },
            {"openPin", "3. Change Pin" },
            {"operEnd", "4. Finish for today" },
            {"", "" },
            {"", "" },
            {"", "" },
            {"", "" },
            {"", "" },
            {"", "" },
            {"", "" },
            {"", "" },
        };
        var atmCommandsPL = new Dictionary<string, string>()
        {
            {"", "" },
        };
    }
}
