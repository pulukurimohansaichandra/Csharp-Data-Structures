using System;

namespace TwoDArrayMul
{
    class Program
    {
        static int counter1 = 0;
        static int counter3=0;
        static int counter2=0;
        static void Main(string[] args)
        {
            ArrayDeclaration();
        }

        static void ArrayDeclaration()
        {
            Console.WriteLine("Enter the size of the Size Matrix");
            int Size = int.Parse(Console.ReadLine());


            int[,] FirstMatrix = new int[Size, Size];
            int[,] SecondMatrix = new int[Size, Size];
            FirstMatrix = FillUserFirstArray(FirstMatrix, Size);
            SecondMatrix = FillUserSecondArray(SecondMatrix, Size);
            TwoDMultiplication(FirstMatrix, SecondMatrix, Size);
        }

        static int[,] FillUserFirstArray(int[,] FirstMatrix, int FirstMatrixSize)
        {
            Console.WriteLine("Enter the first Matrix values");
            for (counter1 = 0; counter1 < FirstMatrixSize; counter1++)
            {
                for (counter2 = 0; counter2 < FirstMatrixSize; counter2++)
                {
                    FirstMatrix[counter1, counter2] = int.Parse(Console.ReadLine());
                }
            }

            return FirstMatrix;
        }

        static int[,] FillUserSecondArray(int[,] SecondMatrix, int SecondMatrixSize)
        {
            Console.WriteLine("Enter the Second Matrix values");
            for (counter1 = 0; counter1 < SecondMatrixSize; counter1++)
            {
                for (counter2 = 0; counter2 < SecondMatrixSize; counter2++)
                {
                    SecondMatrix[counter1, counter2] = int.Parse(Console.ReadLine());
                }
            }

            return SecondMatrix;
        }

        static void TwoDMultiplication(int[,] FirstMatrix, int[,] SecondMatrix, int Size)
        {
            int sum = 0, temp = 0;

            

               
                for (counter1=0; counter1 < Size;counter1++ )
                {
                    for (counter2 = 0; counter2 < Size; counter2++)
                    {
                        temp = FirstMatrix[counter1, counter2] * SecondMatrix[counter2, counter1];
                        sum += temp;
                        Console.Write($"{sum} ");

                    }

                    sum=0;
                    temp=0;
                    Console.WriteLine();

                }
            }


        }
    }

