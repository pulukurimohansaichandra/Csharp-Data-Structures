using System;

namespace _3.MultipleDuplicates
{
    class Program
    {
        static int counter = 0;
        static int counter2=0;
        static void Main(string[] args)
        {
            int[] array;
            Console.WriteLine("Enter the Size of the Array");
            int arraySize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Maximum number in the array");
            int maxNumber = int.Parse(Console.ReadLine());
            array = new int[arraySize];
            array = FillTheUserArray(array, maxNumber, arraySize);
            FindingDuplicate(array, arraySize);
        }

        static int[] FillTheUserArray(int[] array, int maxNumber, int arraySize)
        {
            int userElement = 0;
            Console.WriteLine("Please enter the array numbers");

            for (counter = 0; counter < arraySize; counter++)
            {

                userElement = int.Parse(Console.ReadLine());
                if (userElement > maxNumber)
                {
                    Console.WriteLine("Entered Number is greater than the maximum limit ");
                    userElement = int.Parse(Console.ReadLine());
                }
                array[counter] = userElement;
            }
            return array;
        }

        static void FindingDuplicate(int[] array,int arraySize)
        {
            int [] dupnum=new int[arraySize];
            int counter =0;
           
          for(counter=0;counter<arraySize;counter++)
          {

              int temp =array[counter];
             for(counter2=counter+1;counter2<arraySize;counter2++)
             {

              if(temp==array[counter2])
              {

                counter++;

              }
             }
             if(counter>1)
             {
                 dupnum[counter]=temp;
             }
          }

          int dupLength=dupnum.Length;
          Console.WriteLine($"There are {dupLength} duplicate numbers");
          Console.WriteLine("And the duplicate numbers are ");
          
          for(counter=0;counter<dupLength;counter++)
          {
              Console.Write($",{dupnum[counter]}");
          }

        }
    }
}
