using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasics
{
    public class StringBuffer_Example
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello");
            sb.Append(" World");
            sb.Append("!");

            sb.Insert(5, "beautiful ");

            int length = sb.Length;
            Console.WriteLine(length); // Output: 19

            //accessing
            char firstChar = sb[0];
            Console.WriteLine(firstChar); // Output: H

            //sb.Clear();

            //Convert StringBuilder to string using ToString()
            string result = sb.ToString(); 
            Console.WriteLine(result); // Output: Hello beautiful World!

            sb.Remove(6, 10); // Removes "beautiful "

            int capacity = sb.Capacity;
            Console.WriteLine(capacity); // Output: Capacity of the StringBuilder

        }
    }
}
