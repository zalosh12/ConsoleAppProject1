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
        static List<float> Series = new List<float>();
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
                else
                {
                    implementOption(choice);
                }
                } while (!exit);




        }






        public static void DisplayMenu()
        {
    
                Console.WriteLine("a. Input a series");
                Console.WriteLine("b. Display in order");
                Console.WriteLine("c. Display in reverse order");
                Console.WriteLine("d. Display in sorted order");
                Console.WriteLine("e. Display min number");
                Console.WriteLine("f. Display max number");
                Console.WriteLine("g. Display average");
                Console.WriteLine("h. Display number of elements");
                Console.WriteLine("i. Display the sum of numbers");
        }

        static void implementOption(string choice)
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
            float[] nums = new float[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (!float.TryParse(input[i], out nums[i]))
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


        public static void DisplayInOrder(float[] numbers) {
            foreach (int i in numbers) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        } 


        public static void DisplayInReverse(float[] numbers) {
            int len = numbers.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

        }

        public static void DisplaySorted(float[] numbers) {
            List<float> sorted = new List<float>(numbers);
            sorted.Sort();
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.Write($"{sorted[i]} ");
            }
            Console.WriteLine();
        }


        public static void DisplayMax(float[] numbers) {
            int biggest = 0;
            foreach (int i in numbers)
            {
                if (i > biggest)
                {
                    biggest = i;
                }
            }
            Console.WriteLine(biggest);
        }


        public static void DisplayMin(float[] numbers) {
            int smallest = 0;
            foreach (int i in numbers)
            {
                if (i > smallest)
                {
                    smallest = i;
                }
            }
            Console.WriteLine(smallest);
        }


        public static void DisplayAverage(float[] numbers) {
            float sum = 0;
            int len = numbers.Length;
            foreach (int i in numbers)
            {
                sum += i;
            }
            float average = sum / len;
            Console.WriteLine(average);

        }


        public static void DisplayNumsCount(float[] numbers) {
            int len = 0;
            foreach(int i in numbers)
            {
                len++;
            }
            Console.WriteLine(len);
        }


        public static void DisplaySum(float[] numbers) {
            float sum = 0;
            foreach(float i in numbers)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }

    
}