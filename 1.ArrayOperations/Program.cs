using System;

namespace _1.ArrayOperations
{
    class Program
    {
        static int counter=0;
        static void Main(string[] args)
        {
           
           int[] numbers=new int[10];
           int arrayLength=numbers.Length;
           int arraySum=0;
           numbers=FillElementsInTheArray(numbers,arrayLength);
           arraySum=SumOfTheArrayElements(numbers,arrayLength);
           Console.WriteLine($"Addition of Elements in a array");
           Console.WriteLine($"The Sum of the Array Elements is {arraySum} "); 
        }

        static int[] FillElementsInTheArray(int[] numbers,int arrayLength)
        {
            Console.WriteLine($"Please the enter the elements in the array ");
            for(counter=0;counter<arrayLength;counter++)
            {
                Console.WriteLine($"Please Enter the array element at the {counter} index");
                numbers[counter]=int .Parse(Console.ReadLine());
            }

            return numbers;
        }

        static int SumOfTheArrayElements(int[] numbers,int arrayLength)
        {
            int sum=0;
            for(counter=0;counter<arrayLength;counter++)
            {
                sum+=numbers[counter];
            }

            return sum;
        }
    }
}
