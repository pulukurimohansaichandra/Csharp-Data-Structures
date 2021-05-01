using System;

namespace Kthmaxandmin
{
    class Program
    {

        static int counter=0;
        static int counter1=0;
        static void Main(string[] args)
        {
            int usersize=0;
            Console.WriteLine("Enter the Number of elements ");
             usersize = int.Parse(Console.ReadLine());
            int[] userarray = new int[usersize];
            userarray = FillUserArray(userarray, usersize);
            userarray = ArrayAssending(userarray, usersize);
            int max = FindingKthmax(userarray, usersize);
            int min = FindingKthmin(userarray, usersize);
            Console.WriteLine($" The Required min number is {max} ");
            Console.WriteLine($" The Required max number is {min} ");
        }

        static int[] FillUserArray(int[] userarray, int usersize)
        {
            Console.WriteLine("Enter the Array Elements");
            for (counter = 0; counter < usersize; counter++)
            {
                userarray[counter] = int.Parse(Console.ReadLine());
            }
            return userarray;
        }

        static int[] ArrayAssending(int[] userarray, int usersize)
        {
            int temp;
            for (counter = 0; counter < usersize; counter++)
            {
                for (counter1 = counter + 1; counter1 < usersize; counter1++)
                {
                    if (userarray[counter1] > userarray[counter])
                    {
                        temp = userarray[counter1];
                        userarray[counter1] = userarray[counter];
                        userarray[counter] = temp;
                    }
                }
            }

            return userarray;
        }

        static int FindingKthmax(int[] userarray, int usersize)
        {
            Console.WriteLine("Enter the Kth max number in the array");
            int k = int.Parse(Console.ReadLine());
            int kthmax = userarray[(usersize ) - k];
            return kthmax;
        }

        static int FindingKthmin(int[] userarray, int usersize)
        {
            Console.WriteLine("Enter the Kth min number in the array");
            int k = int.Parse(Console.ReadLine());
            int kthmin = userarray[k-1];
            return kthmin;
        }

    }
}
