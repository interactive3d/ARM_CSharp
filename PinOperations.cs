using System;

static class PinOperations
{
    static string defaultPin = "1234";
    static string cardSavedPin = "1234";
    static int numberOfPinAttempts = 0;
    static string[] possiblePinChar = {"0", "1","2", "3", "4", "5", "6", "7", "8", "9"};

    public static void PinAskingProcess (){
        Console.Write("Please type your PIN number: ");
        string tempPin = Console.ReadLine();
        CheckThePin(tempPin);
    }

	public static void CheckThePin(string tempPin)
	{
       if (tempPin != cardSavedPin)
       {
            numberOfPinAttempts++; // increate the 
            Console.WriteLine("Pin is incorrect");
            Console.WriteLine("=======================");
            if (numberOfPinAttempts < 3)
            {
                PinAskingProcess();
            }
            else
            {
                Console.WriteLine("To many attempts");
                Console.WriteLine("Card has been locked");
                Console.WriteLine("=======================");
            }
        }
       else
        {
            // pin is correct
            Console.WriteLine("PIN is correct");
            Console.WriteLine("=======================");
            // move to operation class
        }
    }


    public static void ChangeThePin()
    {
        Console.WriteLine("Type your new PIN: ");
        string newPin = Console.ReadLine();
        if (newPin.Length != 4) {
            // pin is either to short or to long
            Console.WriteLine("Pin need to consist of 4 digits only");
            Console.WriteLine("Do you still want to change the PIN (Y/N): ");
            string wantToContinue = Console.ReadLine();
            if (wantToContinue == "Y" || wantToContinue == "y")
            {
                ChangeThePin();
            }
            else
            {
                Console.WriteLine("Back to operations"); // back to the main operation menu
                Console.WriteLine("=======================");
            }
        }
        else
        {
            // check condition either pin consist only number
            if (Convert.ToInt32(newPin) != null)
            {
                // this will be fine
                cardSavedPin = newPin;
                Console.WriteLine("New PIN was succesfully saved");
                Console.WriteLine("=======================");
            }
            else
            {
                // display that only numbers are possible
            }
        }
    }
}
