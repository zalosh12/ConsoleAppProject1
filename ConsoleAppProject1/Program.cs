using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleAppProject1
{
    internal class Program
    {
        static List<int> Series = new List<int>();
        public static void Main(string[] args)
        {
            bool IsValid = ValidateNums(args);
            if (IsValid)
            {
                Console.WriteLine("Valid input. Proceeding with the program.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                InputUser();
            }

            bool exit = false;
            do { 
               DisplayMenu();
                Console.WriteLine("Please choose an option:");
                string choice = Console.ReadLine();
                if (choice == "j")
                {
                    exit = true;
                }
                chooseOption(choice);
                } while (!exit);




        }






        public static void DisplayMenu()
        {
    
                Console.WriteLine("a. Input a series");
                Console.WriteLine("b. Display in order");
                Console.WriteLine("c. Display in reverse order");
                Console.WriteLine("d. Display max number");
                Console.WriteLine("e. Display min number");
                Console.WriteLine("f. Display average");
                Console.WriteLine("g. Display count of numbers");
                Console.WriteLine("h. Display sum of numbers");
                Console.WriteLine("i. Display sorted numbers");
        }

        static void chooseOption(string choice)
        {
                switch (choice)
                {
                    case "a":
                        InputUser();
                        break;
                    case "b":
                        DisplayInOrder(Series.ToArray());
                        break;
                    case "c":
                        DisplayInReverse(Series.ToArray());
                        break;
                    case "d":
                        DisplaySorted(Series.ToArray());
                        break;
                    case "e":
                        DisplayMax(Series.ToArray());
                        break;
                    case "f":
                        DisplayMin(Series.ToArray());
                        break;
                    case "g":
                        DisplayAverage(Series.ToArray());
                        break;
                    case "h":
                        DisplayNumsCount(Series.ToArray());
                        break;
                    case "i":
                        DisplaySum(Series.ToArray());
                        break; 
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
        }


        public static void InputUser() {
            Console.WriteLine("Please enter a series of numbers separated by spaces:");
            string input = Console.ReadLine();
            ValidateNums(input.Split(' '));
        }
        

        static bool ValidateNums(string[] input) {
            if (input.Length < 3)
                return false;
            int[] nums = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i], out nums[i]))
                {
                    return false;
                }
                else if (nums[i] < 0)
                {
                    return false;
                }
            }
            Series = nums.ToList();
            return true;

        }


        public static void DisplayInOrder(int[] numbers) {
            foreach (int i in numbers) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        } 


        public static void DisplayInReverse(int[] numbers) { }

        public static void DisplaySorted(int[] numbers) { }


        public static void DisplayMax(int[] numbers) { }


        public static void DisplayMin(int[] numbers) { }


        public static void DisplayAverage(int[] numbers) { }


        public static void DisplayNumsCount(int[] numbers) { }


        public static void DisplaySum(int[] numbers) { }
    }

    
}