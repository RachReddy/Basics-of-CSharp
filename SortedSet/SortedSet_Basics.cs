using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharp
{
    class SortedSet_Basics
    {
        public static void Main()
        {
            // Creating a SortedSet<int>
            SortedSet<int> numbers = new SortedSet<int>();

            // Adding elements to the SortedSet
            numbers.Add(30);
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(10); // Duplicate element, will be ignored
            numbers.Add(40);

            // Checking if an element exists
            bool contains20 = numbers.Contains(20); // true

            // Removing an element
            numbers.Remove(30);

            // Clearing the SortedSet
            // numbers.Clear();

            // Checking the count of elements
            int count = numbers.Count; // 3

            int n = numbers.Max();  // 40 is maximum value in numbers sortedset
            Console.WriteLine(n);

            // Iterating through the SortedSet
            Console.WriteLine("Elements in SortedSet:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); //10, 20, 40
            }

        }
    }
}

/* NOTES
   
 - SortedSet<T> is a collection class which represents a set of unique elements that are sorted in ascending order.
 - SortedSet<T> is useful when you need a collection that ensures uniqueness of its elements and maintains them in sorted order.
 - HashSet only guarentess uniqueness and not order, elements are printed in random
 */
