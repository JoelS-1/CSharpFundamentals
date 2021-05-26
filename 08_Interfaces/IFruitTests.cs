using _08_Interfaces.Fruit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static _08_Interfaces.Fruit.Orange;

namespace _08_Interfaces
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            Banana banana1 = new Banana();

            var output = banana.Peel();
            Console.WriteLine(output);

            

            Console.WriteLine("The banana is peeled: " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            Orange orange = new Orange();

            var fruitSalad = new List<IFruit>
            {
            new Banana(),
            new Orange(),
            orange
            };
            //orange exclusive method is still accessible outside of IFruit collection
            orange.Squeeze();

            foreach(var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                //no longer accessible once in a collection of IFruit
                //fruit.squeeze();

                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called: {fruit.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();

            //even though the method only takes Ifruit, grape still qualifies
            //it just will not have access to grape specific special properties
            string output = GetFruitName(grape);

            Console.WriteLine(output);
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");

            foreach(var fruit in fruitSalad)
            {
                //checking if its of type orange, casting it as orange
                //pattern matching
                if (fruit is Orange orange)
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("It's a peeled orange");
                        //regain orange exlusive properties
                        Console.WriteLine(orange.Squeeze());
                    }
                    else
                    {
                        Console.WriteLine("It's an orange");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("It's a grape");
                    //without pattern matching, cast is necessary
                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("It's a peeled banana");
                }
                else
                {
                    Console.WriteLine("It's a Banana");
                }
            }

        }
    }
}
