using System;
using System.Collections;

namespace learningCSharp
{
    class ArrayListBasics
    {
        public static void Main()
        {

            // Using ArrayList constructor
            ArrayList list1 = new ArrayList();
            list1.Add(1);
            list1.Add(2);

            // Using Add() method
            ArrayList list2 = new ArrayList();
            list2.Add("Apple");
            list2.Add("Banana");
            list2.Add("Orange");


            int num = (int) list1[0]; // Accessing the first element
            string firstElement = (string)list2[0];
            Console.WriteLine(firstElement); // Output: Apple


            int count = list1.Count;
            Console.WriteLine(count); // Output: 3

            list2.Remove("Banana");

            list1.Insert(1, 15); // Inserts 15 at index 1

            bool contains = list2.Contains("Apple");
            Console.WriteLine(contains); // Output: True

            //list1.Clear();

            //iterate
            foreach (object item in list2)
            {
                Console.WriteLine(item);
            }

            foreach(int item in list1)
            {
                Console.WriteLine( (int)item);   //output: 1 15 2
            }
        }
    }
}
