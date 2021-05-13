using System;

namespace StringArray
{
    class Program
    {

        static int counter = 0;
        static int counter1 = 0;
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            int stringLength = input.Length;
            char[] revArray = new char[stringLength];
            for (counter = 0, counter1 = stringLength - 1; counter < stringLength && counter1 >= 0; counter++, counter1--)
            {

                revArray[counter] = input[counter1];

            }
            for (counter = 0; counter < stringLength; counter++)
            {
                Console.Write(revArray[counter]);
            }
        }
    }
}
