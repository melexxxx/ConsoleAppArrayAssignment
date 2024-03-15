using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define an array of strings with names
            string[] stringArray = { "Daniel", "Adrian", "Klaudia", "Brian" };
            // Define an array of integers
            int[] integerArray = { 29, 33, 33, 12 };

            // Loop to get a name from the stringArray
            while (true)
            {
                // Prompt the user to provide an index number between 0 and 3
                Console.WriteLine("Hello, provide index number 0-3 to get a name:");
                // Read user input
                string input1 = Console.ReadLine();

                // Check if the input is a valid integer between 0 and 3
                if (int.TryParse(input1, out int stringIndexChoice) && stringIndexChoice >= 0 && stringIndexChoice <= 3)
                {
                    // Display the name corresponding to the index provided by the user
                    Console.WriteLine($"The name under this index is: {stringArray[stringIndexChoice]}");
                    // Pause execution for 2 seconds
                    Thread.Sleep(2000);
                    // Exit the loop if a valid index is provided
                    break;
                }
                else
                {
                    // Display an error message for invalid input
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 3.");
                }
            }

            // Loop to get a number from the integerArray
            while (true)
            {
                // Prompt the user to provide an index number between 0 and 3
                Console.WriteLine("Now, provide index number 0-3 to get a number:");
                // Read user input
                string input2 = Console.ReadLine();

                // Check if the input is a valid integer between 0 and 3
                if (int.TryParse(input2, out int integerIndexChoice) && integerIndexChoice >= 0 && integerIndexChoice <= 3)
                {
                    // Display the number corresponding to the index provided by the user
                    Console.WriteLine($"The number under this index is: {integerArray[integerIndexChoice]}");
                    // Pause execution for 2 seconds
                    Thread.Sleep(2000);
                    // Exit the loop if a valid index is provided
                    break;
                }
                else
                {
                    // Display an error message for invalid input
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 3.");
                }
            }

            // Create a list of 5 fruits
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Grapes", "Strawberry" };

            // Loop to get a fruit from the fruits list
            while (true)
            {
                // Prompt the user to provide an index number between 0 and 4
                Console.WriteLine("Now, provide index number 0-4 to get a fruit from the list:");
                // Read user input
                string input = Console.ReadLine();

                // Check if the input is a valid integer between 0 and 4
                if (int.TryParse(input, out int listIndexChoice) && listIndexChoice >= 0 && listIndexChoice <= 4)
                {
                    // Display the fruit corresponding to the index provided by the user
                    Console.WriteLine($"The fruit under this index is: {fruits[listIndexChoice]}");
                    // Pause execution for 2 seconds
                    Thread.Sleep(2000);
                    // Exit the loop if a valid index is provided
                    break;
                }
                else
                {
                    // Display an error message for invalid input
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 4.");
                }
            }

            // Prompt the user to press any key to exit
            Console.WriteLine("Press any key to exit...");
            // Wait for the user to press any key
            Console.ReadKey();
        }
    }
}
