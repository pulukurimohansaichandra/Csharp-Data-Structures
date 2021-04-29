using System;

namespace NegativesAside
{
    class Program
    {

        static int counter = 0;

        static int counter1 = 0;
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

            int temp = 0;
            for (counter = 0; counter < userSize; counter++)
            {
                for (counter1 =counter+1; counter1 < userSize; counter1++)
                {
                    if ( userarray[counter]<0)
                    {
                        temp = userarray[counter];
                        userarray[counter] = userarray[counter1];
                        userarray[counter1] = temp;
                    }
                }

            }
            Console.WriteLine("The alterd elements are");
            for (counter = userSize-1; counter >= 0; counter--)
            {
                Console.Write(" "+userarray[counter]);
            }
        }

    }
}
