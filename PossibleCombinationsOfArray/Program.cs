using System;

namespace PossibleCombinationsOfArray
{
    class Program
    {
        static int counter = 0;
        static int counter1 = 0;
        static void Main(string[] args)
        {                     //0  1  2  3  4  5  6  7  8 
            int[] userArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int UserSize = 9;
            Console.WriteLine("Enter the value to check the combinations");
            int usersum = int.Parse(Console.ReadLine());
            CheckingNumbersToFindTheSum(userArray, UserSize, usersum);

        }

        static void CheckingNumbersToFindTheSum(int[] userArray, int UserSize, int usersum)
        {
            for (counter = 0; counter < UserSize; counter++)
            {
                for (counter1 = counter + 1; counter1 < UserSize; counter1++)
                {
                    if (userArray[counter] + userArray[counter1] == usersum)
                    {

                        Console.WriteLine($"{userArray[counter]}+{userArray[counter1]} == {usersum}");
                    }
                }
            }
        }



    }
}

