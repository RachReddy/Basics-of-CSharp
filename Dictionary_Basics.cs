using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharp
{
    class Dictionary_Basics
    {
        public static void Main()
        {

            // Creating a Dictionary<int, string>
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // Adding elements to the dictionary
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            // Accessing elements
            string value = dict[2]; // Retrieves "Two"

            // Checking if a key exists
            bool containsKey = dict.ContainsKey(3); // true

            // Removing an element
            dict.Remove(1);

            // Clearing the dictionary
            //dict.Clear();

            // Checking the count of elements
            int count = dict.Count; // 0

            // Iterating through the dictionary
            Console.WriteLine("Elements in Dictionary:");
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine($"Key: " + kvp.Key + "," + "Value:" + kvp.Value);
            }
        }
    }
}

/* NOTES
  - Dictionary<TKey, TValue> is a collection class that represents a collection of key/value pairs. 
  - It allows you to store elements in a way that each element is associated with a unique key, and you can use the key to retrieve the corresponding value efficiently.
*/

/* DIFFERNCE BTW TUPLE & DICTIONARY
  - Tuple is used to represent a fixed-size collection of heterogeneous elements (elements of different types), typically for grouping related values together.
    eg : A method needs to return both the name and age of a person.

  - Dictionary is used to represent a collection of key/value pairs where each key is unique within the collection, typically for key-based lookup and storage of data.
    eg : Storing user information where each user is identified by a unique ID.
 */