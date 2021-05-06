using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Operators()
        {
            int a = 22;
            int b = 15;

            //addition
            int sum = a + b;
            Console.WriteLine(sum); //37

            //subtraction
            int difference = a - b;
            Console.WriteLine(difference); //7

            //multiplication
            int product = a * b;
            Console.WriteLine(product); //330

            //division
            int quotient = a / b;
            Console.WriteLine(quotient); //1

            //remainder (modulus)
            int remainder = a % b;
            Console.WriteLine(remainder); //7 (the remainder after 15 goes into 22)


        }
    }
}
