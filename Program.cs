using System;
using System.Collections.Generic;   

namespace PracticeTests
{
    class Numbers
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            // The program title!
            Console.Title = "The Calculator";
            // The program itself
            Console.WriteLine("Hello! Welcome to my calculator! Press ENTER to start.");
           
            string programEndConfirmation = "Y";
            while (programEndConfirmation != "N")
            {
            numbersAndStuff();
            Console.WriteLine("Do you want to retry? (Y/N)");
            programEndConfirmation = Console.ReadLine();     
            }
            // The end of code
            Console.WriteLine("\nWell, this is the end. Press any key to bye bye!");
            Console.ReadKey();
        }
        static void numbersAndStuff()
        {
            int num01 = 0;
            string equation = "+";
            int num02 = 0;
            int finAnswer = 0;
            string mathInputLoop = "Y";
                while (mathInputLoop != "N")
                {
                    Console.WriteLine("Insert the first number!");
                    num01 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Insert another number!");
                    num02 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Now insert your operation (+,-,*,/)");
                    equation = Console.ReadLine();
                    Console.WriteLine("Do you want to reinput? (Y/N)");
                    mathInputLoop = Console.ReadLine();
                }
                    Console.WriteLine("----------------------");
                    if (equation == "+")
                    {
                        finAnswer = num01 + num02;
                    }
                    else if (equation == "-")
                    {
                        finAnswer = num01 - num02;
                    }
                    else if (equation == "*")
                    {
                        finAnswer = num01 * num02;
                    }
                    else if (equation == "/")
                    {
                        finAnswer = num01 / num02;
                    }
                    Console.WriteLine("Your number is " + finAnswer + "!");
                }   
        }
    }