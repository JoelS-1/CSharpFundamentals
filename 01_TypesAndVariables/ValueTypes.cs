using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            isDeclared = true; //initializing the variable

            bool isDeclaredAndInitialzied = false;
        }

        [TestMethod]
        public void Characters()
        {
            char letter = 'a';
            char numberCharacter = '7';
            char symbol = '?';
            char space = ' ';
            char specialNextLine = '\n';
            char specialTab = '\t';
        }
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;

            short shortExample = 32767;
            Int16 anotherShortExample = 32000;

            int intMin = -2147483648;
            Int32 intMax = 214783647;

            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.5649841f;
            double doubleExample = 1.654981654891d;
            decimal decimalExample = 1.654981654891m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Cupcake, Eclaire, Danish, Canoli} //must be declared outisde of a test method

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Eclaire;
            PastryType anotherPastry = PastryType.Danish;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(DateTime.Now);
            DateTime birthday = new DateTime(1993, 09, 28);

            TimeSpan age = today - birthday;
            decimal ageInDays = age.Days;
            
            Console.WriteLine(age);
            Console.WriteLine(ageInDays / 365);
        }
    }
}
