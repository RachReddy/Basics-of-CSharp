using System;
namespace learningCSharp
{
    class ArrayBasics
    {
        // Main Method
        public static void Main()
        {
            // Declaration
            int[] x;

            // Initialization
            int[] numbers;
            numbers = new int[5] { 1, 2, 3, 4, 5 };
            //OR int[] numbers=new int[5];

            // Accessing elements
            int thirdNumber = numbers[2]; // Accessing the third element
            Console.WriteLine(thirdNumber); // Output: 3

            // Length property
            int arrayLength = numbers.Length;
            Console.WriteLine(arrayLength); // Output: 5

            // Looping through an array
            for(int i = 0; i < numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //or
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


            // Shorthand array initialization
            int[] shorthandNumbers = { 1, 2, 3, 4, 5 };

            // Multi-dimensional array
            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            // Jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6 };
            jaggedArray[2] = new int[] { 7, 8, 9 };
        }
    }
}