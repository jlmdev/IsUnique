using System;

namespace IsUnique
{
    class Program
    {
        static bool uniqueCharacters(string inputString)
        {
            for (int firstIndex = 0; firstIndex < inputString.Length; firstIndex++)
            {
                for (int secondIndex = firstIndex + 1; secondIndex < inputString.Length; secondIndex++)
                {
                    if (inputString[firstIndex] == inputString[secondIndex])
                    {
                        return false;
                    }
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
