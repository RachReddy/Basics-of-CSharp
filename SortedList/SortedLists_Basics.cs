using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharp
{
    //SortedList<TKey, TValue> 
    class SortedLists_Basics
    {
        public static void Main()
        {
            // Creating a SortedList<TKey, TValue>
            SortedList<int, string> sortedList = new SortedList<int, string>();

            // Adding elements to the SortedList
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");

            // Accessing elements
            Console.WriteLine("Elements in SortedList:");
            foreach (KeyValuePair<int, string> kv in sortedList)
            {
                Console.WriteLine($"Key: {kv.Key}, Value: {kv.Value}");
            }

            // Checking if a key exists
            bool k_res= sortedList.ContainsKey(2); // true
            Console.WriteLine($"Contains key 2:" + k_res);

            // Checking if a Value exists
            bool v_res = sortedList.ContainsValue("One"); // true
            Console.WriteLine($"Contains value One is " + v_res);

            // Removing an element
            sortedList.Remove(2);

            //check size
            int size = sortedList.Count();
            Console.WriteLine(size);

            // Clearing the SortedList
            //sortedList.Clear();

           
        }
    }
}


/*
 - SortedList<TKey, TValue> is a collection class provided by the .NET Framework that represents a collection of key/value pairs that are sorted by the keys. 
 - It is similar to a dictionary, but the entries are automatically sorted by the keys in ascending order.
 */
