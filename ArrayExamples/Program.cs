using System;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySortDemo();
            //JaggedArrayDemo1();

            //twoDimensionsExample1();
        }

        private static void JaggedArrayDemo1()
        {
            ///A jagged array is an array of arrays, and therefore its elements are reference types and are initialized to null.
            ///Learning reference - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays
            ///
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 101, 201, 301 };
            jaggedArray[2] = new int[] { 500, 600 };

            Console.WriteLine(jaggedArray.Length);
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Length of array at position {i} is {jaggedArray[i].Length}");
            }
            Console.WriteLine("Print Values of Array");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("");
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"\t {jaggedArray[i][j]}");
                }
            }
        }

        static void twoDimensionsExample1()
        {
            int[,] arr = new int[3, 5] { { 1, 2, 3, 4 ,5}, { 101, 102, 103, 104 ,105} , { 101, 102, 103, 104 ,105} };
            int len;
            Console.WriteLine($"Rank of array is {arr.Rank}");
            Console.WriteLine($"Total Length  is  {arr.Length}");

            arr[0, 0] = 10;

            len = arr.GetLength(0);
            Console.WriteLine($"Total number of rows  {0} is {len}");

            len = arr.GetLength(1);
            Console.WriteLine($"Number of columns  {1} is {len}");
        }
        static void ArraySortDemo()
        {
            int[] arr = new int[] { 10, 11, 3, 23, 5 };
            Array.Sort(arr);
            int minValue = int.MinValue;
            Console.WriteLine($"MinValye of int is {minValue}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"\t {arr[i]}");
            }
            Array.Reverse(arr);
            Console.WriteLine("");
            Console.WriteLine("Reverse Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"\t {arr[i]}");
            }
        }
    }
}
