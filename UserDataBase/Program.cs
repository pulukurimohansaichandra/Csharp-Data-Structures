using System;

namespace UserDataBase
{
    class Program
    {
        static int counter1 = 0;
        static int counter2 = 0;
        static int noUsers = 0;


        static void Main(string[] args)
        {
            EmployeeTable();
        }


        static void EmployeeTable()
        {

            Console.WriteLine("Please Enter the number of users");
            noUsers = int.Parse(Console.ReadLine());
            string[,] UserDetails = new string[noUsers, 5];

            char UserChoice;
            do
            {

                string databaseUserName = "";
                string databasePassword = "";
                string databaseRole = "";


                string[,] employeeDataBase = new string[,]
                {
              //  0       1        2
          /*0*/ {"User1","xxxxxxxx","User"},
          /*1*/ {"User2","xxxxxxxx","Manager"},
               };
                Console.WriteLine("Employee Login");
                Console.WriteLine("--------------");
                Console.WriteLine("Please Enter the UserName ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter the Password ");
                string password = Console.ReadLine();



                for (counter1 = 0; counter1 < 2; counter1++)
                {
                    for (counter2 = 0; counter2 < 3; counter2++)
                    {
                        switch (counter2)
                        {
                            case 0:
                                {
                                    databaseUserName = employeeDataBase[counter1, counter2];
                                }
                                break;
                            case 1:
                                {
                                    databasePassword = employeeDataBase[counter1, counter2];
                                }
                                break;
                            case 2:
                                {
                                    databaseRole = employeeDataBase[counter1, counter2];
                                }
                                break;
                        }

                    }

                    if (databaseUserName == username && databasePassword == password && databaseRole == "User")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Logged In Succesfully");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Redirecting to User Details");
                        Console.WriteLine();

                        UserDetails = DataBaseOfUserDetails(UserDetails);
                    }
                    else if (databaseUserName == username && databasePassword == password && databaseRole == "Manager")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Logged In Succesfully");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Redirecting to Manager Operations");
                        ManagerOperations(UserDetails);
                    }

                }

                Console.WriteLine();
                Console.WriteLine("Do You Login Again ");
                UserChoice = char.Parse(Console.ReadLine());


            } while (UserChoice == 'y');
        }



        static void ManagerOperations(string[,] UserDetails)
        {

            Console.WriteLine();
            Console.WriteLine("Welcome Manager");
            Console.WriteLine("---------------");
            Console.WriteLine("Please Select your Option");
            Console.WriteLine("Press 1 For Review of Data Base");
            Console.WriteLine("Press 2 For Check the valid User");
            int ManagerSelect = int.Parse(Console.ReadLine());
            switch (ManagerSelect)
            {
                case 1:
                    {

                        Console.WriteLine("                    Data Base Of User Details");
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine($"   UserID       FirstName      LastName     Gender     MailID");
                        Console.WriteLine("    ------       ---------       --------    ------     ------");
                        for (counter1 = 0; counter1 < noUsers; counter1++)
                        {
                            for (counter2 = 0; counter2 < 5; counter2++)
                            {


                                Console.Write($"        {UserDetails[counter1, counter2]}");

                            }
                            Console.WriteLine();
                        }




                    }
                    break;
                case 2:
                    {

                        Console.WriteLine("Check Whether the User Is Valid");
                        Console.WriteLine("Please Enter A KeyName");
                        string keyValue = Console.ReadLine();
                        string FirstName = "";
                        string LastName = "";
                        string FullName = "";
                        Console.WriteLine($"UserId   Firstname   LastName    Gender    Mailid");
                        Console.WriteLine("  -----   ---------   --------    ------    ------");
                        for (counter1 = 0; counter1 < noUsers; counter1++)
                        {
                            for (counter2 = 0; counter2 < 5; counter2++)
                            {
                                switch (counter2)
                                {
                                    case 1:
                                        {
                                            FirstName = UserDetails[counter1, counter2];

                                        }
                                        break;

                                    case 2:
                                        {
                                            LastName = UserDetails[counter1, counter2];
                                        }
                                        break;
                                }


                                FullName = FirstName + LastName;


                                if (keyValue == FirstName)
                                {

                                    Console.Write($"     {UserDetails[counter1, counter2]}");
                                }

                                else if (keyValue == LastName)
                                {

                                    Console.Write($"    {UserDetails[counter1, counter2]}");
                                }

                                else if (keyValue == FullName)
                                {

                                    Console.Write($"    {UserDetails[counter1, counter2]}");
                                }
                            }



                        }



                    }
                    break;

            }

        }
        static string[,] DataBaseOfUserDetails(string[,] UserDetails)
        {
            Console.WriteLine("Please Fill the User Details");
            Console.WriteLine("-----------------------------");

            for (counter1 = 0; counter1 < noUsers; counter1++)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Enter Details for User{counter1 + 1}");
                Console.WriteLine("-------------------------------------");
                for (counter2 = 0; counter2 < 5; counter2++)
                {
                    switch (counter2)
                    {
                        case 0:
                            {
                                UserDetails[counter1, counter2] = "" + (counter1 + 1);
                            }
                            break;
                        case 1:
                            {
                                Console.WriteLine("Enter The First Name");
                                UserDetails[counter1, counter2] = Console.ReadLine();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Enter The Last Name");
                                UserDetails[counter1, counter2] = Console.ReadLine();
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Enter The Gender");
                                UserDetails[counter1, counter2] = Console.ReadLine();
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Enter The Email");
                                UserDetails[counter1, counter2] = Console.ReadLine();
                            }
                            break;


                    }
                }
            }

            return UserDetails;
        }




    }
}
