using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;

            if (userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 15)
            {
                Console.WriteLine("Are you even trying");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun playing video games");
            }
            else
            {
                Console.WriteLine("Git er done son!");
            }

            string input = "3";
            int totalHours = int.Parse(input);

            if(totalHours >= 8)
            {
                Console.WriteLine("You should be well rested");
            }
            else
            {
                Console.WriteLine("You might be tired today.");
                if(totalHours < 4)
                {
                    Console.WriteLine("Yikes... Get some sleep");
                }
            }
        }

        [TestMethod]
        public void IfElseIfStatements()
        {
            int age = 7;

            if(age <= 17)
            {
                Console.WriteLine("You're an adult");
            }
            else
            {
                if(age > 6)
                {
                    Console.WriteLine("You're a kid");
                }
                else if (age > 0)
                {
                    Console.WriteLine("You're too young to be on this computer");
                }
                else
                {
                    Console.WriteLine("You're not even born yet");
                }
            }

            if(age < 65 && age > 18)
            {
                Console.WriteLine("Age is between 18 and 65");
            }
            if(age == 55)
            {
                Console.WriteLine("You're a senior citezen now!");
            }
        }
    }
}
