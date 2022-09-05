using System;
using System.Threading;

namespace TextREPL
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyChoice;
            bool Done = false;

            PrintTitle();
            Console.WriteLine("\n \n \nBefore While loop");
            Continue();

            while (!Done)
            {
                PrintTitle();
                PrintChoices();
                MyChoice = GetChoice();
                PrintTitle();
                Console.WriteLine(":> " + MyChoice);
                Console.WriteLine(":> " + MyChoice.Substring(0, 1));
                Console.WriteLine("Selected :" + MyChoice);
                Continue();
                switch (MyChoice.Substring(0, 1))
                {
                    case "A":
                        Console.WriteLine("In Case A");
                        //WaitProcess();
                        Continue();
                        break;
                    case "a":
                        Console.WriteLine("In Case a");
                        //WaitProcess();
                        Continue();
                        break;
                    case "B":
                        Console.WriteLine("In Case B"); 
                        //WaitProcess();
                        Continue();
                        break;
                    case "b":
                        Console.WriteLine("In Case b"); 
                        //WaitProcess();
                        Continue();
                        break;
                    case "X":
                        WaitProcess();
                        Done = true;
                        break;
                    case "x":
                        WaitProcess();
                        Done = true;
                        break;
                    default:
                        //Exception Handling
                        PrintTitle();
                        Console.WriteLine("\n \n \n Umm... Please try A B or X");
                        Thread.Sleep(2000);
                        //Continue();
                        break;
                }
            };
            PrintTitle();
            Console.WriteLine("\n\n\n Thank you!");
            //End of Main

            static void PrintTitle()
            {
                Console.Clear();
                Console.WriteLine("\n \n \n******");
                Console.WriteLine("*");
                Console.WriteLine("* TextREPL");
                Console.WriteLine("*");
                Console.WriteLine("******");
            }

            static void PrintChoices()
            {
                Console.WriteLine("\n \n \nPlease enter your choice:\n");
                Console.WriteLine("(A) Choice");
                Console.WriteLine("(B) Good");
                Console.WriteLine("(X) Exit\n");
            }

            static void WaitProcess()
            {
                // Would like to display the choice being processed...
                //Console.WriteLine("\n Thank You - Processing..." + MyChoice);
                Console.WriteLine("\n\n\n Processing...");
                Thread.Sleep(2000);
            }
        }

        private static void Continue()
        {
            Console.WriteLine("\n Press a Key to Continue.");
            Console.ReadKey();
        }

        private static string GetChoice()
        {
            string GetChoice = Console.ReadLine();
            Console.WriteLine(":> Inside GetChoice()");
            return GetChoice;
        }
    }
}
