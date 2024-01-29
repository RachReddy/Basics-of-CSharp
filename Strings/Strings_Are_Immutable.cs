using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasics
{
    public class Strings_Are_Immutable
    {
        static void Main()
        {
            string originalString = "Hello";
            Console.WriteLine("Original string: " + originalString);

            string modifiedString = originalString + " World";

            // Print the modified string
            Console.WriteLine("Modified string: " + modifiedString);

            // Print the original string to show it remains unchanged
            Console.WriteLine("Original string (unchanged): " + originalString);
        }
    }
}

//Original string: Hello
//Modified string: Hello World
//Original string (unchanged): Hello
