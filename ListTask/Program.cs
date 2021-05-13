using System;
using System.Collections.Generic;

namespace ListTask
{
    class Program
    {
        static void Main(string[] args)
        {
            School Vbit = new School();

            Member member;

            char userChoice;
            byte userSelect;

            do
            {
                member = new Member();
                DisplayingUserInformation();
                userSelect = byte.Parse(Console.ReadLine());
                switch (userSelect)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Enter the Id of the member");
                            member.ID = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Enter the Name of the Member");
                            member.Name = Console.ReadLine();
                            System.Console.WriteLine("Enter the Role of the Member");
                            member.Role = Console.ReadLine();
                            Vbit.AddingUser(member);
                        }
                        break;
                    case 2:
                        {

                            System.Console.WriteLine("Enter the name that you want to delete ");
                            member.Name = Console.ReadLine();
                            System.Console.WriteLine("enter the role of the member");
                            member.Role = Console.ReadLine();
                            Vbit.RemoveMember(member);

                        }
                        break;


                }



                System.Console.WriteLine("Do you want to add the another member");
                userChoice = char.Parse(Console.ReadLine());

            } while (userChoice == 'y');
            Vbit.PrintingList();

        }

        static void DisplayingUserInformation()
        {
            System.Console.WriteLine("Press 1 for Adding the member");
            System.Console.WriteLine("Press 2 for Removing the member");


        }
    }
}
