using System;

namespace ListTask2
{
    class Program
    {
        static void Main(string[] args)
        {

            Collections userList = new Collections();
            char useselect;
            do
            {
                DisplayingUserChoices();

                byte userChoice = byte.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        {

                            System.Console.WriteLine("Enter the number to add ");
                            userList.Addnumber(int.Parse(Console.ReadLine()));

                        }
                        break;


                    case 2:
                        {

                            userList.Removenumber();

                        }
                        break;


                    case 3:
                        {
                            System.Console.WriteLine("Enter a number to search ");
                            System.Console.WriteLine(userList.NumberContains(int.Parse(Console.ReadLine())));


                        }
                        break;


                    case 4:
                        {

                            userList.ClearList();

                        }
                        break;

                    case 5:
                        {

                            userList.PrintingList();
                        }
                        break;
                }


                System.Console.WriteLine("Do you want to perform the operation again(y/n)");
                useselect = char.Parse(Console.ReadLine());

            } while (useselect == 'y');


        }

        static void DisplayingUserChoices()
        {
            System.Console.WriteLine("select 1 for Adding  the number");
            System.Console.WriteLine("    select 2 for Remove  the number");
            System.Console.WriteLine("select 3 to check whether the list contains that  number");
            System.Console.WriteLine("      select 4 for clear  the total list ");
            System.Console.WriteLine("select 5 for Print  the entire list ");
        }
    }
}
