using System;

namespace DesendingBasedOnLastNumber
{
    class Program
    {
        static int arrayele1length = 0;
        static int arrayele2length = 0;

        static int counter = 0;
        static int counter1 = 0;

        static int userSize = 0;


        static void Main(string[] args)
        {
             Console.WriteLine();

            Console.WriteLine("                   Arranging the substrings in Desending order based on last letter of the substring                       ");
            Console.WriteLine("                   ----------------------------------------------------------------------------------                      ");
            Console.WriteLine();
            Console.WriteLine("Enter  the  number of Names");
            Console.WriteLine("----------------------------");
            userSize = int.Parse(Console.ReadLine());
            string[] userArray = new string[userSize];
            userArray = FillUserArray(userArray);
            userArray = DesendingOrderOfArray(userArray);
            PrintingArray(userArray);
        }

        static string[] FillUserArray(string[] user)
        {
            Console.WriteLine();
            Console.WriteLine("Enter the names here");
            for (counter = 0; counter < userSize; counter++)
            {
                user[counter] = Console.ReadLine();
            }

            return user;
        }

        static string[] DesendingOrderOfArray(string[] user)
        {
            char str1 = ' ';
            char str2 = ' ';
            string string1 = " ";
            string string2 = " ";
            int str3 = 0;
            int str4 = 0;
            string temp;

            for (counter = 0; counter < userSize; counter++)
            {
                for (counter1 = counter + 1; counter1 < userSize; counter1++)
                {

                    string1 = user[counter];
                    arrayele1length = string1.Length;
                    str1 = user[counter][arrayele1length - 1];
                    str3 = (int)str1;

                    string2 = user[counter1];
                    arrayele2length = string2.Length;
                    str2 = user[counter1][arrayele2length - 1];
                    str4 = (int)str2;

                    if (str3 < str4)
                    {
                        temp = user[counter];
                        user[counter] = user[counter1];
                        user[counter1] = temp;
                    }



                }
            }


            return user;
        }



        static void PrintingArray(string[] user)
        {
            for (counter = 0; counter < userSize; counter++)
            {
                int substringlength = 0;
                substringlength = user[counter].Length;
                Console.WriteLine("The updated list" + ":-" + user[counter] + "(" + user[counter][substringlength - 1] + ")");

            }
        }


    }
}
