using System;
using System.Threading;

namespace HomeTask_004_MainPart
{
    class Program
    {
        static void Main(string[] args)
        {
            // User input function
            GetUserInput();

        }

        public static void GetUserInput() {
            bool isUeserWantQuit = false;

            while (!isUeserWantQuit)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hi, Please select hometask (2-3) or type exit for exit from program", Environment.NewLine);
                string userInput = Console.ReadLine();

                // logic for user input
                switch (userInput)
                {
                    case "2":
                        ConsoleCalculator();
                        break;
                    case "3":
                        FindElementRange();
                        break;
                    case "exit":
                        Console.WriteLine("Alright, goodbye :)");
                        Thread.Sleep(500);
                        isUeserWantQuit = true;
                        break;
                    default:
                        Console.WriteLine("You've entered wrong number or made mistake, please repeat your choise...");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        public static void ConsoleCalculator() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi, Enter first value....");
            double firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter second value....");
            double secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, select ariphmetic operation (You can choose * / + - % or you can type \"square root\" ot \"elevate\" for first,second or both values)");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine("You choose addition...");
                    Console.WriteLine($"{firstValue} + {secondValue} = {firstValue + secondValue}");
                    Console.WriteLine("Thank you for using my program hit enter to exit....");
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine("You choose subtraction...");
                    Console.WriteLine($"{firstValue} - {secondValue} = {firstValue - secondValue}");
                    Console.WriteLine("Thank you for using my program hit enter to exit....");
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine("You choose multiplication...");
                    Console.WriteLine($"{firstValue} * {secondValue} = {firstValue * secondValue}");
                    Console.WriteLine("Thank you for using my program hit enter to exit....");
                    Console.ReadLine();
                    break;
                case "/":
                    Console.WriteLine("You choose division...");
                    Thread.Sleep(500);
                    if (secondValue == 0)
                    {
                        Console.WriteLine($"Second value is {secondValue}. This program cant devide by zero.. but you always can find something on stackoverflow...");
                        Thread.Sleep(300);
                        Console.WriteLine("Thank you for using my program hit enter to exit....");
                        Console.ReadLine();
                        break;
                    } else
                    {
                        Console.WriteLine($"{firstValue} / {secondValue} = {firstValue / secondValue}");
                        Console.WriteLine("Thank you for using my program hit enter to exit....");
                        Console.ReadLine();
                        break;
                    }
                case "%":
                    Console.WriteLine("You choose remainder of the division...");
                    Thread.Sleep(500);
                    if (secondValue == 0)
                    {
                        Console.WriteLine($"Second value is {secondValue}. This program cant devide by zero.. but you always can find something on stackoverflow...");
                        Thread.Sleep(300);
                        Console.WriteLine("Thank you for using my program hit enter to exit....");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{firstValue} % {secondValue} = {firstValue % secondValue}");
                        Console.WriteLine("Thank you for using my program hit enter to exit....");
                        Console.ReadLine();
                        break;
                    }
                case "square root":
                    Console.WriteLine("You choose square root...");
                    Thread.Sleep(500);
                    Console.WriteLine("Please select for which value you can find it (Type 1,2 or both)...");
                    string choise = Console.ReadLine();
                    // Implemets logic for choosing value for square root
                    switch (choise)
                    {
                        case "1":
                            Console.WriteLine($"Square root for first value is {Math.Sqrt(firstValue)}");
                            break;
                        case "2":
                            Console.WriteLine($"Sware root for second value is {Math.Sqrt(secondValue)}");
                            break;
                        case "both":
                            Console.WriteLine($"Sware root for first value is {Math.Sqrt(firstValue)}");
                            Thread.Sleep(200);
                            Console.WriteLine($"Sware root for second value is {Math.Sqrt(secondValue)}");
                            break;
                        default:
                            Console.WriteLine("Wrong Input");
                            Thread.Sleep(500);
                            break;
                    }
                    Console.WriteLine("Thank you for using my program hit enter to exit....");
                    Console.ReadLine();
                    break;
                case "elevate":
                    Console.WriteLine("You choose elevate...");
                    Thread.Sleep(500);
                    Console.WriteLine("Please select the degree to which the number must be raised");
                    int userPowChoise = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please select for which value you can find it (Type 1,2 or both)...");
                    string choiseInElevatePart = Console.ReadLine();
                    // Implemets logic for choosing value for square root
                    switch (choiseInElevatePart)
                    {
                        case "1":
                            Console.WriteLine($"Fisrt value in {userPowChoise} degree is {Math.Pow(userPowChoise, firstValue)}");
                            break;
                        case "2":
                            Console.WriteLine($"Second value in {userPowChoise} degree is {Math.Pow(userPowChoise, secondValue)}");
                            break;
                        case "both":
                            Console.WriteLine($"Fisrt value in {userPowChoise} degree is {Math.Pow(userPowChoise, firstValue)}");
                            Thread.Sleep(200);
                            Console.WriteLine($"Second value in {userPowChoise} degree is {Math.Pow(userPowChoise, secondValue)}");
                            break;
                        default:
                            Console.WriteLine("Wrong Input");
                            Thread.Sleep(500);
                            break;
                    }
                    Console.WriteLine("Thank you for using my program hit enter to exit....");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    Thread.Sleep(500);
                    break;
            }
        }
        public static void FindElementRange() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hi please select Write a program to determine if a user-specified number from " +
                "0 to 100 falls within the numerical range [0 - 14] [15 - 35] [36 - 50] [51 - 100]. " +
                "If yes, please indicate in which interval. If the user specifies a number that is not included in any of the available numerical ranges, a corresponding message is displayed.", Environment.NewLine,Environment.NewLine);
            Console.WriteLine("Please type a value from 0 to 100...");
            int userValue = int.Parse(Console.ReadLine());

            // Finding numbers in a range
            if (userValue == 0 && userValue <= 14) { Console.WriteLine($"Your Value {userValue} is located in [0 - 14] range"); }
            else if (userValue >= 15 && userValue <= 35) { Console.WriteLine($"Your Value {userValue} is located in [15 - 35] range"); }
            else if (userValue >= 36 && userValue <= 50) { Console.WriteLine($"Your Value {userValue} is located in [36 - 50] range"); }
            else if (userValue >= 51 && userValue <= 100) { Console.WriteLine($"Your Value {userValue} is located in [51 - 100] range"); }
            else {Console.WriteLine("Value is out of Range");}

            Console.WriteLine("Thank you for using my program. Hit enter for exit");
            Console.ReadKey();
        }
    }
}
