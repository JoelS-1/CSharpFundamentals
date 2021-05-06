using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);

                total = total + 1;
            }

            int someCount = 0;
            bool keepLooping = true;

            while (keepLooping)
            {
                if (someCount <= 100)
                {
                    Console.Write(" " + someCount);
                    someCount ++;
                }
                else
                {
                    keepLooping = false;
                }

            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 28;

            //1 starting point
            //2 condition
            //3 what to do after each loop
            //4 body of the loop - what gets executed each loop

                    //1         //2         //3
            for (int i = 0; i < studentCount; i++)
            {
                //4
                Console.WriteLine(i);
            }

            //you could also use a while loop to do the same thing
            int e = 0;

            while (e > studentCount)
            {
                Console.WriteLine(++e);
            }
        }

        [TestMethod]
        public void ForEach()
        {
            //1 collection being worked on
            //2 name of the current iteration
            //3 type that is held in the collection
            //4 in keyword

                    //1
            string[] students = { "Aaron", "Alexandro", "Andrew", "Ben", "Chris" };
                     //3       2    4   1
            foreach (string student in students)
                {
                Console.WriteLine(student + " is a student in this class");
            }

            string myName = ("Joel Nathaniel Stults");

            foreach (char letter in myName)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void DoWhile()
        {
            int iterator = 0;

            do
            {
                Console.WriteLine("Hello");
                iterator++;
            }
            while (iterator < 5);
        }
        
    }
}
