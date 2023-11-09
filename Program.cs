using System;

namespace ATM
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            PinOperations.PinProcess();
        }



        #region Maths - M0LA15
        private static void LA15Task1()
        {
            int[] source = { 50, 56, -30, 99, 8, -200}; // array of the possible numbers
            int number = source[0];
            for (int i = 1; i < source.Length; i++)
            {
                if (source[i] < number)
                {
                    number = source[i];
                }
            }
            Console.WriteLine(number);
        }

        private static void LA15Task2()
        {
            
        }

        private static void LA15Task3()
        {
            
        }

        private static void LA15Task4()
        {
            
        }
        #endregion
        #region StringTasks M07LA14
        static string myString = "Please find this word. Be happy when you find it!";
        static string textToCovert = "She said \'yes\'!";
        static string textToReplace = "Today is Monday";
        static string textToSpell = "Don\'t Worry. Be happy!";
        static void LA14All()
        {
            LA14Task1();
            LA14Task2();
            LA14Task3();
            LA14Task4();
            LA14Task5();
            LA14Task6();
            LA14Task7();
            LA14Task8();
            LA14Task9();
        }
        static void LA14Task1()
        {
            int locationOfTheString = myString.IndexOf("find");
            Console.WriteLine($"Word find is on position: {locationOfTheString}");
        }
        static void LA14Task2()
        {
            int lastTimeOfTheString = myString.LastIndexOf("find");
            Console.WriteLine($"Word find last time is presented on position: {lastTimeOfTheString}");
        }
        static void LA14Task3()
        {
            int searchForBe = myString.IndexOf("Be");
            Console.WriteLine($"Word \"Be\" is on position: {searchForBe}");
        }
        static void LA14Task4()
        {
            string newTrimmed = myString.Substring(12,20);
            Console.WriteLine(newTrimmed);
        }
        static void LA14Task5()
        {
            string convertedText = textToCovert.ToUpper();
            Console.WriteLine(convertedText);
        }
        static void LA14Task6()
        {
            string convertedText = textToCovert.ToLower();
            Console.WriteLine(convertedText);
        }
        static void LA14Task7()
        {
            Console.WriteLine("Before: " + textToReplace);
            string replacedText = textToReplace.Replace("Monday", "Tuesday");
            Console.WriteLine("After: " + replacedText);
        }
        static void LA14Task8()
        {
            // display each characted in separate line
            for (int i = 0; i < textToSpell.Length; i++) {
                Console.WriteLine(textToSpell[i]);
            }
        }
        static void LA14Task9()
        {
            // display each word in separate line
            string[] wordsFromText = textToSpell.Split(" "); // this array will store the words
            for (int i = 0; i < wordsFromText.Length; i++)
            {
                Console.WriteLine($"{wordsFromText[i]}");
            }
        }
        #endregion

    }
    class DisplayMessages
    {
        public DisplayMessages()
        {

        }
        
        static string[] country = { "EN", "PL" }; // this is the list of possible languages;
        static string currentLanguage = country[0];

        public static List<string> currentCommands = new List<string>();
        public static List<string> commandsEN = new List<string> 
        {
            "Welcome to the ATM",
            "Please insert your card to the machine",
            "Please type your PIN and press Enter",
            "PIN is Correct",
            "PIN is Incorrect",
            "What would you like to do:",
            "1. Check the balance",
            "2. Withdraw",
            "3. Deposit",
            "4. Change PIN",
            "5. Finish",
            "Pin changed successfully",
            "Could not change the PIN",

        };
        public static List<string> commandsPL = new List<string> 
        { 

        };


        public static void ChangeLanguage(string code)
        {
            int index = Array.IndexOf(country, code);  // check if the code exist as element of the country array
            if (index !=-1) // if that exist then gets it ID
            {
                currentLanguage = country[index]; // assign the id of the country[ID] to currentLanguage
                switch(currentLanguage)
                {
                    case "EN":
                        currentCommands = commandsEN;
                        break;
                    case "PL":
                        currentCommands = commandsPL;
                        break;
                }
            }
            else
            {
                currentLanguage = country[0]; // change to default English
            }
        }
    }

}