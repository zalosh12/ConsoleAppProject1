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
            ManageMenu(IsValid);
           

          
        }






        public static void DisplayMenu()
        {
            Console.WriteLine("a. Input a series");
            Console.WriteLine("b. Display in order");
            Console.WriteLine("c. Display in reverse order");
            Console.WriteLine("d. Display max number");
            Console.WriteLine("e. Display min number");
            Console.WriteLine("f. Display average");
            chooseOption();
        }

        public static void ManageMenu(bool Valid)
        {
            if (Valid)
            {
                DisplayMenu();
            }
            else
            {
                {   Console.WriteLine("Invalid input. Please enter a valid number.");
                    InputUser();
                }
            }
        }

        static void chooseOption()
        {
            bool exit = false;
            Console.WriteLine("Please choose an option:");
            string choice = Console.ReadLine();
            do
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
                        DisplayMax(Series.ToArray());
                        break;
                    case "e":
                        DisplayMin(Series.ToArray());
                        break;
                    case "f":
                        DisplayAverage(Series.ToArray());
                        break;
                    case "g":
                        DisplayNumsCount(Series.ToArray());
                        break;
                    case "h":
                        DisplaySum(Series.ToArray());
                        break;
                    case "i":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
                DisplayMenu();
            } while (!exit);
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