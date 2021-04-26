using System;

namespace ArrayAssending
{
    class Program
    {

        static int counter = 0;
        static int counter1 = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Array");
            int ArraySize = int.Parse(Console.ReadLine());
            int[] UserArray = new int[ArraySize];
            UserArray = FillArray(UserArray, ArraySize);
            ArrayInAssending(UserArray, ArraySize);
        }


        static int[] FillArray(int[] UserArray, int ArraySize)
        {

            Console.WriteLine("Enter the Array Elements");
            for (counter = 0; counter < ArraySize; counter++)
            {
                UserArray[counter] = int.Parse(Console.ReadLine());
            }

            return UserArray;

        }

        static void ArrayInAssending(int[] UserArray, int ArraySize)
        {
            int temp;

            for (counter1 = 0; counter1 < ArraySize; counter1++)
            {

                for (counter = counter1 + 1; counter < ArraySize; counter++)
                {
                    if (UserArray[counter1] > UserArray[counter])
                    {
                        temp = UserArray[counter];
                        UserArray[counter] = UserArray[counter1];
                        UserArray[counter1] = temp;

                    }
                }

            }
            Console.Write("The Assending Ordar Of The Numbers :=   ");
            for (counter = 0; counter < ArraySize; counter++)
            {

                Console.Write($"{UserArray[counter]} ");
            }
        }



    }
}
