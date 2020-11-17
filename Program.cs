using System;

namespace IsUnique
{
    class Program
    {
        // Method 1: Brute force Looping

        // static bool uniqueCharacters(string inputString)
        // {
        //     for (int firstIndex = 0; firstIndex < inputString.Length; firstIndex++)
        //     {
        //         for (int secondIndex = firstIndex + 1; secondIndex < inputString.Length; secondIndex++)
        //         {
        //             if (inputString[firstIndex] == inputString[secondIndex])
        //             {
        //                 return false;
        //             }
        //         }
        //     }
        //     return true;
        // }

        // Method 2: Sorting based on ASCII values of characters
        // Time Complexity: O(n log n)

        static bool uniqueCharacters(string inputString)
        {
            char[] characterArray = inputString.ToCharArray();

            Array.Sort(characterArray);

            for (int index = 0; index < characterArray.Length - 1; index++)
            {
                if (characterArray[index] != characterArray[index + 1])
                {
                    continue;
                }
                else
                {
                    return false;
                }

            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string");
            var input = Console.ReadLine();

            if (uniqueCharacters(input) == true)
            {
                Console.WriteLine($"The string {input} has all unique characters");
            }
            else
            {
                Console.WriteLine($"The string {input} has duplicate characters");
            }
        }
    }
}

// Test change