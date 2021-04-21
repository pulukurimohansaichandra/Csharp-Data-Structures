using System;

namespace FindTheMissingNumber
{
    class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            DisplayFunction("Finding the duplicate number");
            int[] array;
            DisplayFunction("Enter the array size");
            int arraySize = int.Parse(Console.ReadLine());
            DisplayFunction("Enter the maximum number in the array ");
            int maxNumber = int.Parse(Console.ReadLine());
            array = new int[arraySize];
            DisplayFunction("Please Enter the array elements");
            array = FillTheUserArray(array, arraySize, maxNumber);
            int duplicateNumber = FindtheDuplicateNumber(array, arraySize);
            Console.WriteLine($"the Duplicate number is {duplicateNumber}");

        }

        static int[] FillTheUserArray(int[] array, int arraySize, int maxNumber)
        {
            int arrayElement = 0;
            for (counter = 0; counter < arraySize; counter++)
            {
                arrayElement = int.Parse(Console.ReadLine());
                if (arrayElement > maxNumber)
                {
                    Console.WriteLine($"Please Enter the number less than 10");
                    arrayElement = int.Parse(Console.ReadLine());
                }
                array[counter]=arrayElement;
            }

            return array;
        }

        static int FindtheDuplicateNumber(int[] array, int arraySize)
        {
            int duplicateNumber = 0;

            for (counter = 1; counter < arraySize; counter++)
            {
                
                if (array[counter] == array[counter - 1])
                {
                    duplicateNumber = array[counter - 1];
                }
            }

            return duplicateNumber;
        }

        static void DisplayFunction(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
