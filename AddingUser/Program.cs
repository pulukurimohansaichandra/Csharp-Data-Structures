using System;

namespace AddingUser
{
    class Program
    {

        static int counter = 0;
        static int counter1 = 0;

        static int usersize = 0;

        static int usernewsize = 0;
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the no users   ");
            usersize = int.Parse(Console.ReadLine());
            string[] user = new string[10];
            user = FillUserArray(user);
            Console.WriteLine($"Enter new users you want to add which are less than {10 - usersize} ");
            usernewsize = int.Parse(Console.ReadLine());
            user = AddingUserToUser(user);
            user = AssendingOrderOfArray(user);
            PrintingArray(user);
        }

        static string[] FillUserArray(string[] user)
        {
            Console.WriteLine("Enter the Users here");
            for (counter = 0; counter < usersize; counter++)
            {
                user[counter] = Console.ReadLine();
            }

            return user;
        }

        static string[] AssendingOrderOfArray(string[] user)
        {
            char str1 = ' ';
            char str2 = ' ';
            int str3 = 0;
            int str4 = 0;

            for (counter = 0; counter < (usernewsize + usersize); counter++)
            {

               // str1 = user[counter][0];
                //str3 = (int)str1;




                for (counter1 = counter + 1; counter1 < (usernewsize + usersize); counter1++)
                {
                    str1 = user[counter][0];
                    str3 = (int)str1;

                    str2 = user[counter1][0];
                    str4 = (int)str2;




                    if (str3 > str4)
                    {
                        string temp;
                        temp = user[counter1];
                        user[counter1] = user[counter];
                        user[counter] = temp;
                    }

                }
            }

            return user;
        }

        static string[] AddingUserToUser(string[] user)
        {

            Console.WriteLine("Enter the users");

            for (counter = usersize; counter < usernewsize + usersize; counter++)
            {
                user[counter] = Console.ReadLine();
            }





            return user;
        }

        static void PrintingArray(string[] user)
        {
            for (counter = 0; counter < (usersize + usernewsize); counter++)
            {
                Console.WriteLine($"The updated list :- {user[counter]}");

            }
        }


    }
}
