using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Joel";
            string lastName = "Stults";

            //concatenation
            string concatenatedFullName = firstName + ' ' + lastName;
            Console.WriteLine(concatenatedFullName);

            //compositing
            string compositeFullName = string.Format("{0} {1} is learning to code!", firstName, lastName);
            
            Console.WriteLine(compositeFullName);

            //interpolation
            string interpolatedFullName = $"{firstName} {lastName} \"The Hammer\"";
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample, "?" };

            string firstString = $"{ stringArray[2]} { stringArray[5]}";
            Console.WriteLine(firstString);

            string firstString2 = stringArray[0];

            //lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("Hello");
            listOfIntegers.Add(23);
            listOfStrings.Add("World");

            Console.WriteLine(listOfIntegers[0]);
            Console.WriteLine(listOfStrings[1]); //prints world as found in index [1]

            listOfStrings.Remove(listOfStrings[0]); //removes hello as found in index [0]
            Console.WriteLine(listOfStrings[0]); //prints world again since we removed the prior [0] value

            //queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm second");
            firstInFirstOut.Enqueue("I'm third");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            string whosFirstNow = firstInFirstOut.Peek();
            Console.WriteLine(whosFirstNow);

            //dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(001, "EFA office");

            string badgeDoor = keyAndValue[001]; //grabs the value found at the 001 key

            Console.WriteLine(badgeDoor);

            //more collections you can look into: SortedList - HashSet - Stack
        }
    }
}
