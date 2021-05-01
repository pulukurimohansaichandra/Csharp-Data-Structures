using System;

namespace NegativesAside
{
    class Program
    {

        static int counter = 0;

        //static int counter1 = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int userSize = int.Parse(Console.ReadLine());
            int[] userarray = new int[userSize];
            userarray = FillUserarray(userarray, userSize);
            NegativeNumbersASide(userarray, userSize);
        }

        static int[] FillUserarray(int[] userarray, int userSize)
        {
            Console.WriteLine("Enter the array elements");
            for (counter = 0; counter < userSize; counter++)
            {
                userarray[counter] = int.Parse(Console.ReadLine());
            }

            return userarray;
        }

        static void NegativeNumbersASide(int[] userarray, int userSize)
        {
            int[] duparray = new int[userSize];
            int temp = userSize - 1;
            int temp1 = 0;
            for (counter = 0; counter < userSize; counter++)
            {
                if (userarray[counter] < 0)
                {
                    duparray[temp1] = userarray[counter];
                    temp1++;

                }
                else
                {
                    duparray[temp] = userarray[counter];
                    temp--;

                }
            }
            Console.WriteLine("The alterd elements are");
            for (counter = 0; counter < userSize; counter++)
            {
                Console.Write(" " + duparray[counter]);
            }
        }

    }
}
