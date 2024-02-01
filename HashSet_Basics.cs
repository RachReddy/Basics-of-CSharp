using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharp
{
    class HashSet_Basics
    {
        public static void Main()
        {
            // Creating a HashSet<int>
            HashSet<int> numbers = new HashSet<int>();

            // Adding elements to the HashSet
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(10); // Duplicate element, will be ignored

            // Checking if an element exists
            bool contains20 = numbers.Contains(20); // true

            // Removing an element
            numbers.Remove(30);

            // Clearing the HashSet
            //numbers.Clear();

            // Checking the count of elements
            int count = numbers.Count;
            Console.WriteLine(count);// 3

            int n = numbers.Max();  // 20 is maximum value in numbers hashset
            Console.WriteLine(n);

            // Iterating through the HashSet
            Console.WriteLine("Elements in HashSet:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

/* NOTES: 
  - HashSet<T> is a collection class provided by the .NET Framework that represents a set of unique elements. 
  - It does not allow duplicate elements, and it provides O(1) complexity for basic operations such as adding, removing, and checking for the presence of an element.
 */