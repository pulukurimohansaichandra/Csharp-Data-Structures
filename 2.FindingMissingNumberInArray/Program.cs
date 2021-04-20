using System;

namespace _2.FindingMissingNumberInArray
{
    class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Programe to find the missing number");
            int[] array;

            int maxArrayValueSize = 10;

            int arraySize = GetArraySizeFromUser();

            array = new int[arraySize];

            array = FillArrayValuesFromUser(array, arraySize, maxArrayValueSize);

            int missingNumber = FindingMissingNumberInArray(array, arraySize);

            if (missingNumber != 0)
            {
                Console.WriteLine($"The Missing Number is {missingNumber}");
            }
            else
            {
                Console.WriteLine($"There is no missing number in the array ");
            }

        }

        static int GetArraySizeFromUser()
        {
            Console.WriteLine($"Please enter the size of the array");
            int arraySize = int.Parse(Console.ReadLine());

            return arraySize;

        }

        static int[] FillArrayValuesFromUser(int[] array, int arraySize, int maxArrayValueSize)
        {


            Console.WriteLine("Please Enter the Values for array Note Enter the numbers in assending order");
            for (counter = 0; counter < arraySize; counter++)
            {
                int arrayElement= int.Parse(Console.ReadLine());; 
                if (arrayElement > maxArrayValueSize)
                {
                    Console.WriteLine("Please Enter the number less than 10");
                    arrayElement = int.Parse(Console.ReadLine());

                }

                array[counter]=arrayElement;

            }


            return array;


        }

        static int FindingMissingNumberInArray(int[] array, int arraySize)
        {

            int missingNumber = 0;
            int elementDiff;

            for (counter = 1; counter < arraySize; counter++)
            {
                elementDiff = array[counter] - array[counter-1];
                if (elementDiff == 2)
                {
                    missingNumber = array[counter] - 1;
                }   
            }

            return missingNumber;
        }
    }
}
