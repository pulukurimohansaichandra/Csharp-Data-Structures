using System;
using System.Collections.Generic;

namespace ListBasicTask
{

    class Collection
    {
        List<int> numberList = new List<int>();

        public void AddNumber(int inputnumber)
        {

            numberList.Add(inputnumber);

        }

        public void Remove()
        {
            numberList.RemoveAt(numberList.Count - 1);
            Print();

        }

        public bool ContainsNumber(int inputnumber)
        {

            if (numberList.Contains(inputnumber))
            {
                return true;
            }

            return false;

        }

        public void CleartheList()
        {
            numberList.Clear();
            Print();
        }

        public void Print()
        {
            int counter = 0, count = 1;
            System.Console.WriteLine(" item no     number ");
            System.Console.WriteLine(" -------     ------");
            for (counter = numberList.Count - 1; counter >= 0; counter--)
            {
                System.Console.Write($"      {count}           {numberList[counter]}");
                System.Console.WriteLine();
                count++;
            }
            System.Console.WriteLine();
        }




    }
}