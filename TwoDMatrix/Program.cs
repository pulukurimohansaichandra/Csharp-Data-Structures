using System;

namespace TwoDMatrix
{
    class Program
    {
        static int counter1 = 0;
        static int counter2 = 0;

        static void Main()
        {
            int FmatrixSize = 0;
            Console.WriteLine("Please Enter the First Matrix Size");
            FmatrixSize = int.Parse(Console.ReadLine());
            int SmatrixSize = 0;
            Console.WriteLine("Please Enter the Second Matrix Size");
            SmatrixSize = int.Parse(Console.ReadLine());
            int[,] firstMatrix = new int[FmatrixSize, FmatrixSize];
            int[,] SecondMatrix = new int[SmatrixSize, SmatrixSize];
            firstMatrix = UserFirstMatrix(firstMatrix, FmatrixSize);
            SecondMatrix = UserSecondMatrix(SecondMatrix, SmatrixSize);
            MatrixSum(firstMatrix, SecondMatrix);

        }



        static int[,] UserFirstMatrix(int[,] firstMartrix, int FmatrixSize)
        {
            Console.WriteLine("Enter the first Matrix values");
            for (counter1 = 0; counter1 < FmatrixSize; counter1++)
            {
                for (counter2 = 0; counter2 < FmatrixSize; counter2++)
                {
                    firstMartrix[counter1, counter2] = int.Parse(Console.ReadLine());
                }
            }

            return firstMartrix;
        }


        static int[,] UserSecondMatrix(int[,] SecondMatrix, int SmarixSize)
        {
            Console.WriteLine("Enter the Second Matrix values");
            for (counter1 = 0; counter1 < SmarixSize; counter1++)
            {
                for (counter2 = 0; counter2 < SmarixSize; counter2++)
                {
                    SecondMatrix[counter1, counter2] = int.Parse(Console.ReadLine());
                }
            }

            return SecondMatrix;
        }
        static void MatrixSum(int[,] FirstMatrix, int[,] SecondMatrix)
        {

            for (counter1 = 0; counter1 < (FirstMatrix.Length); counter1++)
            {
                for (counter2 = 0; counter2 < (SecondMatrix.Length); counter2++)
                {
                    Console.WriteLine($"The sum is {FirstMatrix[counter1, counter2] + SecondMatrix[counter1, counter2]}");
                }
            }
        }
    }
}
