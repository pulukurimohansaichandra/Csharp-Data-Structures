using System;
using System.Collections.Generic;

namespace ListTask2
{

    class Collections
    {
        List<int>  userNumbers=new List<int>();

        public void Addnumber(int inputnumber)
        {
            userNumbers.Add(inputnumber);
        }

        public void Removenumber()
        {

                userNumbers.RemoveAt(0);
                PrintingList();


        }

        public bool  NumberContains(int inputnumber)
        {

              if(userNumbers.Contains(inputnumber))
              {
                  return true;
              }

              return false;

        }

        public void ClearList()
        {
            userNumbers.Clear();
            PrintingList();
        }

        public void PrintingList()
        {
            int counter=0;
            System.Console.WriteLine("item no    item");
            System.Console.WriteLine("-------    -----");
            for(counter=0;counter<userNumbers.Count;counter++)
            {

                System.Console.Write($" {counter+1}      {userNumbers[counter]}");
                System.Console.WriteLine();

            }
        }

    }
}