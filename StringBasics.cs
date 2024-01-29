using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharp
{
    class StringBasics
    {
        public static void Main()
        {
            string greeting = "Hello World!";

            //Length property
            int length = greeting.Length;
            Console.WriteLine(length); // Output: 12

            //Accessing elements
            char firstCharacter = greeting[0];
            Console.WriteLine(firstCharacter); // Output: H

            //Concatination
            string name = "Alice";
            string message = "Hello, " + name + "!";
            Console.WriteLine(message); // Output: Hello, Alice!

            string concatMessage = String.Concat("Hello, ", name, "!");
            Console.WriteLine(concatMessage); // Output: Hello, Alice!

            //Substring(startindex)  or Substring(startindex, length of substring u want)
            string sub = greeting.Substring(7); 
            Console.WriteLine(sub); // Output: orld!
            string sub2 = greeting.Substring(7, 2);  // output or

            //Splitting
            string names = "Alice,Bob,Charlie";
            string[] nameArray = names.Split(',');
            foreach (string n in nameArray)
            {
                Console.WriteLine(n);
            }
            // Output:
            // Alice
            // Bob
            // Charlie

            //ToLower() and ToUpper()
            string lowercase = greeting.ToLower();
            string uppercase = greeting.ToUpper();
            Console.WriteLine(lowercase); // Output: hello, world!
            Console.WriteLine(uppercase); // Output: HELLO, WORLD!

            //Trim
            string str = "  Hello  ";
            string trimmed = str.Trim();
            Console.WriteLine(trimmed); // Output: Hello

            //Contains
            bool contains = greeting.Contains("Hello");
            Console.WriteLine(contains); // Output: True



            string str1 = "Hello";
            string str2 = "World";
            string str3 = "Hello";

            // Using == operator
            bool isEqual1 = (str1 == str2);
            Console.WriteLine($"Using == operator: {isEqual1}"); // Output: False

            // Using Equals() method
            bool isEqual2 = str1.Equals(str2);
            Console.WriteLine($"Using Equals() method: {isEqual2}"); // Output: False

            // Comparing two equal strings
            bool isEqual3 = (str1 == str3);
            Console.WriteLine($"Comparing equal strings: {isEqual3}"); // Output: True

            bool isEqual4 = str1.Equals(str3);
            Console.WriteLine($"Using Equals() method: {isEqual2}"); // Output: True
        }
    }
}
