using System;

namespace _4.MultipleMissingNumbers
{
    class Program
    {
        static int counter=0;
        static void Main(string[] args)
        {
            Display();
            int [] array;
            int [] missingnum;
            Console.WriteLine("Enter the Size of the array");
            int arrSize=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max Number in the array");
            int maxnum=int.Parse(Console.ReadLine());
            array=new int[arrSize];
            array=FillTheArrayValues(array,arrSize,maxnum);
            missingnum=new int[arrSize];
            FindMissingNum(array,arrSize);
  
        }

        static int [] FillTheArrayValues(int [] array,int arrSize,int maxnum)
        {
            Console.WriteLine("Enter the Array Elements");
            
            for(counter=0;counter<arrSize;counter++)
            {
                int userElement=int.Parse(Console.ReadLine());
                if(userElement>maxnum)
                {
                    Console.WriteLine($"Please Enter the number which is less than {maxnum}");
                    userElement=int.Parse(Console.ReadLine());
                }
                array[counter]=userElement;
            }

            return array;

        }

        static void FindMissingNum(int [] array,int arrSize)
        {
            
          int [] missingnum=new int[arrSize];
          for(counter=1;counter<arrSize;counter++)
          {
              if((array[counter]-array[counter-1])==2)
              {
                  missingnum[counter]=array[counter-1]+1;
              }
          }

          int missingarrLength=0,count=0;
          missingarrLength=missingnum.Length;

          for(counter=0;counter<missingarrLength;counter++)
          {
              
              if(missingnum[counter]!=0)
              { 
                count++;
              }
          }
          
          
          Console.WriteLine($"There are the {count} Missing Numbers ");
          
          for(counter=0;counter<missingarrLength;counter++)
          {
              Console.Write($"{missingnum[counter]},");
          }
            

        }

        static void Display()
        {
            Console.WriteLine();
            Console.WriteLine("           Finding the multiple Missing numbers                ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
        }


    }
}
