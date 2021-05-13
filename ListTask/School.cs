using System;
using System.Collections.Generic;
namespace ListTask
{

    class School
    {

        int counter = 0;
        List<Member> memberslist = new List<Member>();
        // List<int> numbers = new List<int>();

        public void AddingUser(Member inputmember)
        {

            if (memberslist.Count == 0)
            {
                memberslist.Add(inputmember);
            }
            else
            {
                byte listname;
                byte inputname;
                for (counter = 0; counter < memberslist.Count; counter++)
                {
                    listname = (byte)(memberslist[counter].Name)[0];//Mohan -> M -109
                    inputname = (byte)(inputmember.Name)[0];// Ashish -> A 97
                    if (inputname < listname)
                    {
                        memberslist.Insert(counter, inputmember); //0th index -> Mohan ->1st index

                        break;
                    }
                }
            }

        }

        public void RemoveMember(Member inputmember)
        {

            if (Containsthemember(inputmember) != -1)
            {
                int index = Containsthemember(inputmember);
                memberslist.RemoveAt(index);



            }

            else
            {
                System.Console.WriteLine("Member does not exists");
            }

        }


        public void PrintingList()
        {
            System.Console.WriteLine("ID           Name          Role ");
            System.Console.WriteLine("--           ----          ----");
            foreach (Member item in memberslist)
            {
                System.Console.WriteLine($"{item.ID}           {item.Name}          {item.Role  }");
            }
        }

        int Containsthemember(Member inputmember)
        {

            for (int counter = 0; counter < memberslist.Count; counter++)
            {
                if (inputmember.Name == inputmember.Name)
                {
                    return counter;
                }
            }
            return -1;

        }
    }
}