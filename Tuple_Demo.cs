using System;


namespace Tuple_Basics
{
    public class Tuple_Demo
    {
        static void Main()
        {
            // Creating a Tuple using Tuple class
            Tuple<int, string> personTuple1 = new Tuple<int, string>(1, "Alice");

            // Creating a Tuple using shorthand syntax
            var personTuple2 = Tuple.Create(2, "Bob");

            // Accessing Tuple elements using Item1, Item2 properties
            int id1 = personTuple1.Item1;
            string name1 = personTuple1.Item2;

            // Accessing Tuple elements using deconstruction
            var (id2, name2) = personTuple2;

            // Printing Tuple elements
            Console.WriteLine($"Person 1: ID - {id1}, Name - {name1}");
            // Output: Person 1: ID - 1, Name - Alice

            Console.WriteLine($"Person 2: ID - {id2}, Name - {name2}");
            // Output: Person 2: ID - 2, Name - Bob

            // Returning Tuples from methods
            var personTuple3 = GetPerson();
            Console.WriteLine($"Person 3: ID - {personTuple3.Item1}, Name - {personTuple3.Item2}");
            // Output: Person 3: ID - 3, Name - Charlie

            // Tuple with named elements
            var personTuple4 = (Id: 4, Name: "David");
            Console.WriteLine($"Person 4: ID - {personTuple4.Id}, Name - {personTuple4.Name}");
            // Output: Person 4: ID - 4, Name - David

            // Tuple with different data types
            var mixedTuple = (1, "Alice", true);
            int id3 = mixedTuple.Item1;
            string name3 = mixedTuple.Item2;
            bool isActive = mixedTuple.Item3;
            Console.WriteLine($"Person 5: ID - {id3}, Name - {name3}, IsActive - {isActive}");
            // Output: Person 5: ID - 1, Name - Alice, IsActive - True

            // Tuple comparison
            var tuple1 = (1, "Alice");
            var tuple2 = (1, "Alice");
            bool areEqual = tuple1.Equals(tuple2);
            Console.WriteLine($"Tuple comparison result: {areEqual}");
            // Output: Tuple comparison result: True
        }

        // Method returning a Tuple
        public static (int, string) GetPerson()
        {
            return (3, "Charlie");
        }



    }
}

/* NOTESS :
 
-Tuple is a data structure that can hold multiple elements of potentially different types.
-Tuples are immutable, meaning once created, their values cannot be modified. 
-They are commonly used when you need to return multiple values from a method, as they allow you to encapsulate these values into a single object.
 
 */