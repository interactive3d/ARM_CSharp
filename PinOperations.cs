﻿using System;
using System.Linq.Expressions;

static class PinOperations
{
    static string defaultPin = "1234";
    static string cardSavedPin = "1234";
    static int numberOfPinAttempts = 0;
    static string[] possiblePinChar = {"0", "1","2", "3", "4", "5", "6", "7", "8", "9"};

    public static void PinAskingProcess (){
        Console.Write(LanguageCommands.ATMessage("typePin"));
        string tempPin = Console.ReadLine();
        CheckThePin(tempPin);
    }

	public static void CheckThePin(string tempPin)
	{
       if (tempPin != cardSavedPin)
       {
            numberOfPinAttempts++; // increate the 
            Console.WriteLine(LanguageCommands.ATMessage("pinWRONG"));
            Console.WriteLine("=======================");
            if (numberOfPinAttempts < 3)
            {
                PinAskingProcess();
            }
            else
            {
                Console.WriteLine(LanguageCommands.ATMessage("pinToMany"));
                Console.WriteLine(LanguageCommands.ATMessage("pinLocked"));
                Console.WriteLine("=======================");
            }
        }
       else if (tempPin == cardSavedPin)
        {
            // pin is correct
            Console.WriteLine(LanguageCommands.ATMessage("pinOK"));
            Console.WriteLine("=======================");
            Console.ReadKey();
            // move to operation class
        }
    }


    public static void ChangeThePin()
    {
        Console.WriteLine(LanguageCommands.ATMessage("newPINType"));
        string newPin = Console.ReadLine();
        if (newPin.Length != 4) {
            // pin is either to short or to long
            Console.WriteLine(LanguageCommands.ATMessage("newPin4D"));
            Console.WriteLine(LanguageCommands.ATMessage("newPinContinue"));
            string wantToContinue = Console.ReadLine();
            if (wantToContinue == "Y" || wantToContinue == "y")
            {
                ChangeThePin();
            }
            else
            {
                Console.WriteLine(LanguageCommands.ATMessage("backToMain")); // back to the main operation menu
                Console.WriteLine("=======================");
            }
        }
        else if (newPin.Length == 4) {
            // check condition either pin consist only number
            try 
            {
                int a = Convert.ToInt32(newPin);
                // this will be fine
                cardSavedPin = a.ToString();
                Console.WriteLine(LanguageCommands.ATMessage("newPinSuccess"));
                Console.WriteLine("=======================");
                PinAskingProcess();
                //Console.ReadKey();
                MainOperationMenu.DisplayMainMenu();
            }
            catch (FormatException e) 
            {
                Console.WriteLine(LanguageCommands.ATMessage("newPin4D"));
            }
        }
    }
}
