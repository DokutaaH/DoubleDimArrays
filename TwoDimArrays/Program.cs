using System;

namespace TwoDimArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1

            int[,] testTable1 = new int[,]
            {
                { 11, 21 },
                { 32, 43 },
                { 54, 65 }
            };
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum += testTable1[i, j];
                }
            }

            Console.WriteLine("The sum of all elements is " + sum);
            Console.WriteLine("======================================================");
            Console.WriteLine();

            // Задача 2

            int[,] testTable = new int[,]
            {
                { 1, 3 },
                { 2, 4 },
                { 3, 5 },
                { 4, 6 }
            };

            Console.Write("The even elements of an array are: ");

            for (int i = 0; i < testTable.GetLength(0); i++)
            {
                for (int j = 0; j < testTable.GetLength(1); j++)
                {
                    if (testTable[i, j] % 2 == 0)
                    {
                        Console.Write(testTable[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("======================================================");
            Console.WriteLine();

            // Задача 3

            int[,] testTable2 = new int[,]
            {
                { 0, 1, 2 },
                { 10, 11, 12 },
                { 20, 21, 22 },
                {30, 31, 32 }
            };

            int lineSum = 0;

            for (int l = 0; l < 4; l++)
            {
                for (int r = 0; r < 3; r++)
                {
                    lineSum += testTable2[l, r];
                }

                Console.Write($"Sum of elements in line {l} = {lineSum}");
                Console.WriteLine();

                lineSum = 0;
            }

            Console.WriteLine("======================================================");
            Console.WriteLine();

            // Задача 4

            Console.WriteLine("Enter N=");
            int n = 0;
            bool isParsed = false;

            do
            {
                string input = Console.ReadLine();
                isParsed = int.TryParse(input, out int parsedInput);

                if (isParsed)
                {
                    n = parsedInput;
                }
                else
                {
                    Console.WriteLine("Please enter a number");
                }

            } while (isParsed == false);

            Console.WriteLine();

            Console.WriteLine("Enter M=");
            int m = 0;
            isParsed = false;

            do
            {
                string input = Console.ReadLine();
                isParsed = int.TryParse(input, out int parsedInput);

                if (isParsed)
                {
                    m = parsedInput;
                }
                else
                {
                    Console.WriteLine("Please enter a number");
                }

            } while (isParsed == false);

            int[,] testTable3 = new int[n, m];
            int sumOfElements = 0;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    testTable3[i, j] = random.Next(0, 101);
                    sumOfElements += testTable3[i, j];
                    Console.Write(testTable3[i, j] + " ");
                }

                Console.WriteLine();
            }

            int avgOfElements = sumOfElements / testTable3.Length;

            Console.WriteLine();
            Console.WriteLine("The average of all elements in the array is " + avgOfElements);

            Console.WriteLine("======================================================");
            Console.WriteLine();

            // Задача 5

            int[,] testTable4 = new int[5, 5];

            Random random2 = new Random();

            Console.WriteLine("Initial array: ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    testTable4[i, j] = random2.Next(0, 101);
                    Console.Write(testTable4[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Swapped array: ");

            for (int j = 0; j < 5; j ++)
            {
                int temp = testTable4[j, 2];
                testTable4[j, 2] = testTable4[j, 3];
                testTable4[j, 3] = temp;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(testTable4[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(testTable4[i, i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Reverse diagonal: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(testTable4[i, 5-i-1] + " ");
            }
            Console.WriteLine();
        }
    }
}
