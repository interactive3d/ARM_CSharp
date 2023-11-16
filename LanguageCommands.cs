using System;
using System.Collections.Generic;

public static class LanguageCommands {

    public static string[] country = { "EN", "PL" }; // this is the list of possible languages;
    public static string currentLanguage = country[0];


    
    public static Dictionary<string, string> atmCommandsEN = new Dictionary<string, string>()
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
        {"operPin", "3. Change Pin" },
        {"operEnd", "4. Finish for today" },
        
        {"pinToMany","To many attempts"},
        {"pinLocked","Card has been locked"},
        {"anyKey","Press any key to return to main menu"},
        {"balnceIs","You balance is: "},
        {"",""},
    };
    public static Dictionary<string, string> atmCommandsPL = new Dictionary<string, string>()
        {
            {"welcome", "Witamy w naszym banku"},
            {"typePin", "Wpisz swój number PIN: "},
            {"pinOK", "PIN jest poprawny" },
            {"pinWRONG", "PIN jest błędny" },
            {"newPINType", "Wpisz swój nowy PIN: " },
            {"newPin4D", "Pin może zawierać tylko 4 cyfry" },
            {"newPinContinue", "Do you still want to change the PIN (Y/N): " },
            {"backToMain", "Powrót do menu Operacji" },
            {"newPinSuccess", "Zapisano nowy numer PIN" },
            {"operWhat", "Wybierz typ operacji: " },
            {"operBalance", "1. Sprawdź stan konta" },
            {"operCash", "2. Pobrać gotówkę" },
            {"operPin", "3. Zmienić PIN" },
            {"operEnd", "4. Zakończyć" },
            {"pinToMany","Za duża ilość prób"},
            {"pinLocked","Karta została zablokowana"},
            {"anyKey","Naciśnij dowolny klawisz aby powrócić do menu głównego"},
            {"balnceIs","Środki na koncie: "},
            {"",""},
        };
    public static Dictionary<string, string> currentCommands = new Dictionary<string, string>();
    public static string ATMessage(string msgCode)
    {
        /// based on the selected language a directory of command need to be selected
        /// currentLanguage
        /// 
        string theMessage = "";
        if (currentCommands.ContainsKey(msgCode))
        {
            theMessage = currentCommands[msgCode];
        }
        return theMessage;
    }
    public static void ChooseDifferentLanguage(){
        Console.WriteLine("=======================");
        Console.WriteLine("Please choose one of the following languages:");
        Console.WriteLine("=======================");
        Console.WriteLine("1. English");
        Console.WriteLine("2. Polski");
        string languageSelected = Console.ReadLine();
        switch (languageSelected)
        {
            case "1":
                Console.WriteLine("Language changed to English");
                // currentCommands.Clear();
                currentCommands = atmCommandsEN.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                break;
            case "2":
                Console.WriteLine("Zmieniono język na polski");
                //currentCommands.Clear();
                currentCommands = atmCommandsPL.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                break;
            default:
                break;
        }
        Console.WriteLine("=======================");
    }
}