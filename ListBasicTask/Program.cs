using System;

namespace ListBasicTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Collection numbercollection = new Collection();

            char usechoice;
            do
            {
                DisplayingUserChoices();
                byte userselect =byte.Parse(Console.ReadLine());
                switch(userselect)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Enter a number to add to the list ");
                        numbercollection.AddNumber(int.Parse(Console.ReadLine()));

                    }break;

                    case 2:
                    {

                        System.Console.WriteLine("Above entered number is removed succesfully");

                    }break;

                    case 3:
                    {
                        System.Console.WriteLine("Enter a number to check whether number is present in the list or not");
                        System.Console.WriteLine(numbercollection.ContainsNumber(int.Parse(Console.ReadLine())));

                    }break;

                    case 4:
                    {
                        numbercollection.CleartheList();

                    }break;

                    case 5:
                    {
                        numbercollection.Print();

                    }break;
                }

                System.Console.WriteLine("do you want to perform the operation again ");
                usechoice = char.Parse(Console.ReadLine());
            } while (usechoice == 'y');

        }

        static void DisplayingUserChoices()
        {
            System.Console.WriteLine("select 1 for Adding  the number");
            System.Console.WriteLine("select 2 for Remove  the number");
            System.Console.WriteLine("select 3 to check whether the list contains that  number");
            System.Console.WriteLine("select 4 for clear  the total list ");
            System.Console.WriteLine("select 5 for Print  the entire list ");
        }
    }
}
