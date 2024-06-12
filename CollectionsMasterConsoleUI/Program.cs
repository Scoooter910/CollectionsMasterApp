using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            

            #region Arrays
            
            int[] numberArray = new int[50];

            
            Populater(numberArray);


            //TODO: Print the first number of the array
            Console.WriteLine("First number in the array:");
            Console.WriteLine(numberArray[0]);

            //TODO: Print the last number of the array

            Console.WriteLine("Last number in the array:");
            Console.WriteLine(numberArray[numberArray.Length - 1]);


            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {numList.Count}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(numList);
            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity: {numList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int userNumber;
            bool isANumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);

            } while (isANumber == false);
;
            NumberChecker(numList, userNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numList);
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

       
            numList.Sort();
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var myArray = numList.ToArray();

            //TODO: Clear the list
            numList.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1; i >=0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool foundNumber = false;
            
            
                if (numberList.Contains(searchNumber))
                {
                    Console.WriteLine("The number is in the list");
                    foundNumber = true;
                    
                }
                else 
                {
                    Console.WriteLine("The number is not in the list");
                }
            }
        

        private static void Populater(List<int> numberList)
        {
            

            while (numberList.Count <51)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);
                numberList.Add(number);
                
            }
            NumberPrinter(numberList);
        }


        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
                
            }

        }        

        private static void ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            int index = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[index] = array[i];
                index++;
            }
            
               
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
