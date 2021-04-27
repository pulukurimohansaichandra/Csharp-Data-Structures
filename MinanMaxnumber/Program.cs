using System;

namespace MinanMaxnumber
{
    class Program
    {

        static int counter=0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int userSize=int.Parse(Console.ReadLine());
            int[] userarray=new int[userSize];
            int[] duplicate=new int[userSize];
            userarray=FillUserArray(userarray,userSize);
            duplicate=FillDuplicate(duplicate,userarray,userSize);
            int minnum=Minnumber(userarray,userSize);
            int maxnum=Maxnumber(duplicate,userSize);
            Console.WriteLine($" The minimum number is {maxnum}");
            Console.WriteLine($" The maximum number is {minnum}");
        }

        static int[] FillUserArray(int [] userarray,int userSize)
        {
            Console.WriteLine("Enter the array elements");
            for(counter=0;counter<userSize;counter++)
            {
                userarray[counter]=int.Parse(Console.ReadLine());
            }
            return userarray;
        }

        static int[] FillDuplicate(int[] Duplicate,int[]userarray,int userSize)
        {
            
            for(counter=0;counter<userSize;counter++)
            {
                Duplicate[counter]=userarray[counter];
            }

            return Duplicate;

        }

        static int Minnumber(int [] userarray,int userSize)
        {
            int minnum=userarray[0];
            for(counter=1;counter<userSize;counter++)
            {
                if(userarray[counter]>minnum)
                {
                    minnum=userarray[counter];
                }
            }

            return minnum;
        }
        
        static int Maxnumber(int [] userarray,int userSize)
        {
            int maxnum=userarray[0];
            for(counter=1;counter<userSize;counter++)
            {
                if(userarray[counter]<maxnum)
                {
                    maxnum=userarray[counter];
                }
            }

            return maxnum;
        }
    }
}
