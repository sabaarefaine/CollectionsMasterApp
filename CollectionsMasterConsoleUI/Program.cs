using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var randomNumbers = new int[50];

            Populater(randomNumbers);

            //Print the first number of the array
            Console.WriteLine(randomNumbers[0]);

            //Print the last number of the array
            Console.WriteLine(randomNumbers[49]);
            //(randomNumbers[randomNumbers.Length-1])

            Console.WriteLine("All Numbers Original");

            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(randomNumbers);

            //NumberPrinter();
            Console.WriteLine("-------------------");

            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");

            //Reverse the contents of the array and then print the array out to the console.
            Array.Reverse(randomNumbers);
            NumberPrinter(randomNumbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(randomNumbers);
            NumberPrinter(randomNumbers);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(randomNumbers);
            NumberPrinter(randomNumbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            
            var numberList = new List<int>();
            Console.WriteLine("Capacity:");
            //Print the capacity of the list to the console

            Console.WriteLine(numberList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);

            //Print the new capacity
            Console.WriteLine("Capacity:");
            Console.WriteLine(numberList.Capacity);

            Console.WriteLine("---------------------");
            NumberPrinter(numberList);
            Console.WriteLine("---------------------");


            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var search = int.Parse(Console.ReadLine());

            //needs two parameters to check
            NumberChecker(numberList, search);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            numberList = OddKiller(numberList);
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            

            //Clear the list
            

            #endregion
        }

        //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }



        }

        //Create a method that will remove all odd numbers from the list then print results
        //return type List
        private static List<int> OddKiller(List<int> numberList)
        {
            //created new list to return
            var newList = new List<int>();
            for (int i = 0; i < numberList.Count; i++)
            {
                if(numberList[i] % 2 == 0)
                {
                    newList.Add(numberList[i]);
                }
            }
            return newList;
          
            
        }

        //Create a method that prints if a user number is present in the list
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (searchNumber == numberList[i])
                {
                    Console.WriteLine($"found{searchNumber}");
                }
            }
        }

        //Populate the List with 50 random numbers between 0 and 50 you will need a method for this
        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(50));
            }

        }

        private static void Populater(int[] numbers)
        {
            //Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 100);
                
            }
           

        }        

        private static void ReverseArray(int[] array)
        {

            
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
