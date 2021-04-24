using System;

namespace TaskLibrary
{
    class Program
    {
        static int counter=0;
        static void Main(string[] args)
        {
            Console.WriteLine("                     Library                    ");
            Console.WriteLine("----------------------------------------------- ");
            Librarian();
            
            
        }

        static void  Librarian()
        {
            int BooksSize;
            Console.WriteLine("Enter The Number of users");
            int UsersSize=int.Parse(Console.ReadLine());
            string [] Users=new string[UsersSize];
            Console.WriteLine("Enter the Number of Books");
             BooksSize=int.Parse(Console.ReadLine());
            string [] Books=new string[BooksSize];
            string [] userbooks=new string[BooksSize];
            Users=FillUsers(Users,UsersSize);
            Books=FillBooks(Books,BooksSize);
            char UserChoice;
            do
            {
             Console.WriteLine("Select User");
             Console.WriteLine("------------");
             for(counter=0;counter<UsersSize;counter++)
             {
                 Console.WriteLine($"{counter}.{Users[counter]}");
             }
             Console.WriteLine("Enter Here");
             int UserSelection=int.Parse(Console.ReadLine());
             userbooks=UserBookSelection(Users[UserSelection],Books, BooksSize);
             Console.WriteLine("Your Books are ");
             int counter2;
             for(counter2=0;counter2<userbooks.Length;counter2++)
             {
                ;
                 Console.WriteLine($"{counter2+1}. {userbooks[counter2]}");
             }
             Console.WriteLine("Do You Want to Switch the user (y/n)");
              UserChoice=char.Parse(Console.ReadLine());
            }while(UserChoice=='y');

            
        }
        

        static string [] UserBookSelection(string User,string [] Books,int BooksSize)
        {
            string [] UserBooks=new string[BooksSize];
            int counter1=0;
            char userBookchoice;
            Console.WriteLine($"Welcome {User}");
            do
            {
                Console.WriteLine("Select the Books");
                for(counter=0;counter<Books.Length;counter++)
                {
                    Console.WriteLine($"{counter+1}.{Books[counter]}");
                }

                Console.WriteLine("Enter Here");
                int bookChoice=int.Parse(Console.ReadLine());
                bookChoice-=1;
                UserBooks[counter1]=Books[bookChoice];


                 counter1++;
              Console.WriteLine("Do you want to choose another book (y/n)");
               userBookchoice = char.Parse(Console.ReadLine());
              
            }while(userBookchoice =='y');

            return UserBooks;
        }

        static string [] FillUsers(string [] Users,int UsersSize)
        {
            Console.WriteLine("Enter the users here");
            for(counter=0;counter<UsersSize;counter++)
            {
                string user=Console.ReadLine();
                Users[counter]=user;
            }
            

            return Users;
        }

        static string [] FillBooks(string [] Books,int BooksSize)
        {
            Console.WriteLine("Please Enter Books here");
            for(counter=0;counter<BooksSize;counter++)
            {
                string userbook=Console.ReadLine();
                Books[counter]=userbook;
            }

            return Books;
        }
    }
}
